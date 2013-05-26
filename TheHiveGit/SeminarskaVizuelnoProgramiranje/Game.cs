using SeminarskaVizuelnoProgramiranje.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using SeminarskaVizuelnoProgramiranje.Properties;
using System.Drawing.Imaging;

namespace SeminarskaVizuelnoProgramiranje
{
    public partial class Game : Form
    {
        public bool won = false;
        public int level;
        Constants Constants;
        int SelectedBeeIndex;
        int FilledSlots;
        int SlotCount;

        bool HintUsed;
        Timer HintTimer;
        int HintTimeLeft;

        int DropTimer;

        Point HoverPointOld;
        Point HoverPointNew;

        public Slot[][] Slots;
        public List<Bee> Bees;

        public Game(int lvl)
        {
            InitializeComponent();
            DoubleBuffered = true;

            HintUsed = true;
            HintTimeLeft = 30;
            HintTimer = new Timer();
            HintTimer.Interval = 1000;
            HintTimer.Tick += new EventHandler(HintTimerTick);

            HintTimer.Start();

            Constants = new Constants();

            InitializeLevel(lvl);

            Paint += new PaintEventHandler(OnPaint);

        }

        private void HintTimerTick(object sender, EventArgs e)
        {
            HintTimeLeft--;

            if (HintTimeLeft == 0)
            {
                HintUsed = false;
                lblHint.Text = "Hint ready";
                HintTimer.Stop();
                HintTimer.Dispose();
            }
            else
            {
                lblHint.Text = String.Format("Hint in 0:{0:00}", HintTimeLeft);
            }
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);

            foreach (Bee bee in Bees)
            {
                bee.Draw(e.Graphics);
            }

            foreach (Slot[] s in Slots)
            {
                foreach (Slot slot in s)
                {
                    if (slot != null)
                    {
                        slot.Draw(e.Graphics);
                    }
                }
            }
        }

        private void InitializeLevel(int lvl)
        {

            FilledSlots = 0;
            SlotCount = 0;
            DropTimer = 0;
            SelectedBeeIndex = -1;
            
            level = lvl;
            Text = "Level " + (level + 1);

            int[][] transformMatrix = TransformMatrix(Constants.LevelMatrices[level]);
            List<int> currentBees = Constants.LevelBees[level];

            HoverPointOld.X = -1;
            HoverPointOld.Y = -1;
            HoverPointNew.X = 0;
            HoverPointNew.Y = 0;

            Slots = new Slot[transformMatrix.Length][];
            Bees = new List<Bee>();

            for (int i = 0; i < currentBees.Count; i++)
            {
                Bees.Add(new Bee(50 + i * 60, 40, i, currentBees[i]));
            }

            float x = 50;
            float y = 100;

            for (int i = 0; i < transformMatrix.Length; i++)
            {
                int jumpOffset = 0;
                int jump = i % 2;

                if (i % 2 != 0)
                {
                    jumpOffset = 30;
                }

                x = 50 + jumpOffset;

                Slots[i] = new Slot[transformMatrix[i].Length];
                for (int j = jump; j < transformMatrix[i].Length; j += 2)
                {
                    if (transformMatrix[i][j] == Constants.Free)
                    {
                        Slots[i][j] = new Slot((int)x, (int)y);
                        SlotCount++;
                    }

                    x += 60;
                }
                y += 48;
            }
        }

        public void BeeEvent(Bee bee)
        {
            // Иницијализација на кооординатите
            int i = bee.DropCoordinates.X;
            int j = bee.DropCoordinates.Y;

            // Промена на состојбата на ќелијата, се зачувува видот на пчелата. Промена на индексот на пчелата
            Slots[i][j].State = bee.BeeType;
            Slots[i][j].BeeIndex = bee.i;
            int currentBee = bee.BeeType;

            // Ги земаме листите со координати кои ги означуваат насоките на движење на пчелите.
            int[][] array = getArray(currentBee);

            foreach (int[] pair in array)
            {
                // Со секој пар се добиваат различни координати за движење низ матрицата.
                int X = i + pair[0];
                int Y = j + pair[1];

                // Се додека не се излезе од матрицата или не дојдеме до дупка во матрицата или ќелија со пчела, 
                // пополнувањето во одредена насока продолжува
                while (X >= 0 && X < Slots.Length && Y >= 0 && Y < Slots[0].Length && Slots[X][Y] != null && Slots[X][Y].State < 2)
                {
                    if (Slots[X][Y].State == Constants.Free)
                    {
                        FilledSlots++;
                    }
                    Slots[X][Y].State = Constants.Filled;



                    X += pair[0];
                    Y += pair[1];
                }
            }

            // Зголемување на бројот на пополнети ќелии и извршување на функцијата WinLevel
            FilledSlots++;
            WinLevel();
        }

        public void BeeEventHover(int i, int j, int currentBee)
        {
            ClearHover();
            Slots[i][j].Hovered = true;
            HoverPointOld.X = HoverPointNew.X;
            HoverPointOld.Y = HoverPointNew.Y;

            int[][] array = getArray(currentBee);

            foreach (int[] pair in array)
            {
                int X = i + pair[0];
                int Y = j + pair[1];

                while (X >= 0 && X < Slots.Length && Y >= 0 && Y < Slots[0].Length && Slots[X][Y] != null && Slots[X][Y].State < 2)
                {
                    Slots[X][Y].Hovered = true;

                    X += pair[0];
                    Y += pair[1];
                }
            }

            Invalidate(true);

        }

        private void WinLevel()
        {
            // Проверка дали сите ќелии се пополнети
            if (FilledSlots == SlotCount)
            {
                // Се ресетира тајмерот на почетната состојба
                HintUsed = true;
                lblHint.Text = "Hint in 0:30";
                lblHint.ForeColor = Color.FromArgb(255, 150, 0);
                HintTimeLeft = 30;
                HintTimer.Start();

                // Проверка дали било поминато последното ниво
                if (level + 1 == Constants.LevelMatrices.Count)
                {
                    // Нема веќе нивоа за играње. Формата се затвора
                    won = true;
                    DialogResult dr = MessageBox.Show("Congratulations, you passed all levels!");
                    DialogResult = DialogResult.No;
                    Close();
                }
                else
                {
                    // Поминато е моменталното ниво, го иницијализираме следното.

                    // Се покажува текст дека сме го поминале нивото
                    lblLevelPassed.Text = "Level " + (level + 1) + " passed!";
                    lblLevelPassed.Visible = true;

                    // Иницијализација на новото ниво
                    won = false;
                    InitializeLevel(++level);
                    Invalidate(true);

                    // По 2.5 секунди текстот за поминато ниво се крие
                    Timer timer = new Timer();
                    timer.Interval = 2500;
                    timer.Tick += (arg1, arg2) =>
                    {
                        lblLevelPassed.Visible = false;
                        timer.Stop();
                        timer.Dispose();
                    };

                    timer.Start();
                }
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            int Hit = UpdateHoverCoords(e);
            base.OnMouseMove(e);

            if (Hit != Constants.Slot)
            {
                HoverPointNew.X = -1;
                HoverPointNew.Y = -1;

                if (SameHoverPoint())
                {
                    return;
                }
                else
                {
                    ClearHover();
                }
            }

            if (SelectedBeeIndex != -1 && !SameHoverPoint())
            {
                if (Slots[HoverPointNew.X][HoverPointNew.Y].State == Constants.Free)
                {
                    BeeEventHover(HoverPointNew.X, HoverPointNew.Y, Bees[SelectedBeeIndex].BeeType);
                }
                else
                {
                    ClearHover();
                }

            }
        }

        private bool SameHoverPoint()
        {
            if (HoverPointNew.X == HoverPointOld.X && HoverPointNew.Y == HoverPointOld.Y)
            {
                return true;
            }
            return false;
        }

        private int UpdateHoverCoords(MouseEventArgs e)
        {
            int X = e.X;
            int Y = e.Y;
            int Hit = Constants.Nothing;
            int i = -1;
            int j = -1;

            int modX = (X - 50) % 60;
            // Check if a bee is hit
            if (Y >= 40 && Y < 90)
            {
                if (X >= 100 && modX < 50)
                {
                    i = (X - 50) / 60;

                    if (i < Bees.Count)
                    {
                        Hit = Constants.Bee;
                    }
                }
            }
            // Check if a slot is hit
            else if (Y >= 100)
            {
                i = (Y - 100) / 48;
                int jumpOffset = (i % 2 == 0) ? 0 : 30;
                int jump = i % 2;
                int modY = (X - 50 - jumpOffset) % 60;

                if (i < Slots.Length && X >= 50 && modY < 50)
                {
                    j = (X - 50 - jumpOffset) / 60 * 2 + jump;
                    if (j < Slots[0].Length)
                    {
                        if (Slots[i][j] != null)
                        {
                            HoverPointNew.X = i;
                            HoverPointNew.Y = j;
                            Hit = Constants.Slot;
                        }
                    }
                }
            }

            return Hit;
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            int X = e.X;
            int Y = e.Y;
            int Hit = Constants.Nothing;
            int i = -1;
            int j = -1;

            int modX = (X - 50) % 60;

            // Check if a bee is hit
            if (Y >= 40 && Y < 90)
            {
                if (X >= 50 && modX < 50)
                {
                    i = (X - 50) / 60;

                    if (i < Bees.Count)
                    {
                        Hit = Constants.Bee;
                    }
                }
            }
            // Check if a slot is hit
            else if (Y >= 100)
            {
                i = (Y - 100) / 48;
                int jumpOffset = (i % 2 == 0) ? 0 : 30;
                int jump = i % 2;
                int modY = (X - 50 - jumpOffset) % 60;

                if (i < Slots.Length && X >= 50 && modY < 50)
                {
                    j = (X - 50 - jumpOffset) / 60 * 2 + jump;
                    if (j < Slots[0].Length)
                    {
                        Hit = Constants.Slot;
                        if (Slots[i][j] != null)
                        {
                            Invalidate(true);
                        }
                    }
                }
            }

            base.OnMouseClick(e);
            if (e.Button == MouseButtons.Right)
            {
                if (SelectedBeeIndex != -1)
                {
                    ReturnBee();
                    ClearHover();
                    return;
                }

                if (Hit == Constants.Slot)
                {
                    //ClearSlot(X, Y);
                    if (Slots[i][j] != null && Slots[i][j].HasBee())
                    {
                        int index = Slots[i][j].BeeIndex;
                        Bees[index].Dropped = false;
                        Bees[index].Visible = true;

                        ExecuteBeeEvents();
                    }
                }

            }
            else if (e.Button == MouseButtons.Left)
            {
                if (Hit == Constants.Bee)
                {
                    if (Bees[i].Visible)
                    {
                        BeeLeftClick(i);
                    }
                }
                else if (Hit == Constants.Slot)
                {
                    // NO BEE SELECTED
                    if (SelectedBeeIndex == -1)
                    {
                        PickUpBee(i, j);
                    }
                    // DROPPING BEE
                    else if (Slots[i][j] != null && Slots[i][j].State == Constants.Free)
                    {
                        DropBee(i, j);
                    }
                }
            }
        }

        public void PickUpBee(int i, int j)
        {
            if (Slots[i][j] != null && Slots[i][j].HasBee())
            {
                int index = Slots[i][j].BeeIndex;
                Bees[index].Dropped = false;
                BeeLeftClick(index);
                HoverPointOld.X = HoverPointOld.Y = -1;

                ExecuteBeeEvents();
            }
        }

        public void DropBee(int i, int j)
        {
            // Курсорот се поставува на default курсор.
            Cursor = Cursors.Default;

            // Селектираната пчела ја означуваме дека е поставена во ќелија.
            // Зачувуваме во кој чекор е поставена пчелата
            // Ги зачувуваме координатите на ќелијата.
            Bees[SelectedBeeIndex].Dropped = true;
            Bees[SelectedBeeIndex].DropTimer = DropTimer++;
            Bees[SelectedBeeIndex].DropCoordinates = new Point(i, j);

            // Означуваме дека веќе нема селектирана пчела.
            SelectedBeeIndex = -1;

            // Одново се повикува BeeEvent за секоја пчела која има Dropped = true, во растечки редослед во однос на нивниот DropTimer.
            ExecuteBeeEvents();
        }

        public void BeeLeftClick(int i)
        {
            if (SelectedBeeIndex != -1)
            {
                Bees[SelectedBeeIndex].Visible = true;
            }

            Bees[i].Visible = false;
            Invalidate(true);
            SelectedBeeIndex = i;
            Cursor c = new Cursor(getResource(Bees[i].BeeType).GetHicon());
            Cursor = c;
        }

        public void ReturnBee()
        {
            if (SelectedBeeIndex != -1)
            {
                Cursor = Cursors.Default;
                Bees[SelectedBeeIndex].Visible = true;
                Invalidate(true);
                SelectedBeeIndex = -1;
            }
        }

        private void ExecuteBeeEvents()
        {
            ClearSlots();

            List<Bee> tmpBees = Bees.OrderBy(x => x.DropTimer).ToList();

            foreach (Bee bee in tmpBees)
            {
                if (bee.Dropped)
                {
                    BeeEvent(bee);
                }
            }
            Invalidate(true);
        }

        private void ClearSlots()
        {
            for (int i = 0; i < Slots.Length; i++)
            {
                int jump = i % 2;

                for (int j = jump; j < Slots[i].Length; j += 2)
                {
                    if (Slots[i][j] != null)
                    {
                        Slots[i][j].State = Constants.Free;
                        Slots[i][j].Hovered = false;

                    }
                }
            }
            FilledSlots = 0;
        }

        private void ClearHover()
        {
            for (int i = 0; i < Slots.Length; i++)
            {
                int jump = i % 2;

                for (int j = jump; j < Slots[i].Length; j += 2)
                {
                    if (Slots[i][j] != null)
                    {
                        Slots[i][j].Hovered = false;
                    }
                }
            }
            HoverPointOld.X = -1;
            HoverPointOld.Y = -1;
            Invalidate(true);
        }

        public int[][] getArray(int bee)
        {
            switch (bee)
            {
                case Constants.HorizontalBee: return Constants.Horizontal;
                case Constants.LeftRightBee: return Constants.LeftRight;
                case Constants.RightLeftBee: return Constants.RightLeft;
                case Constants.LeftCrossBee: return Constants.LeftCross;
                case Constants.RightCrossBee: return Constants.RightCross;
                case Constants.HexBee: return Constants.Hex;
                case Constants.CrossBee: return Constants.Cross;
            }

            return null;
        }

        public static Image getResourceImage(int field)
        {
            return getResource(field) as Image;
        }

        public static Bitmap getResource(int field)
        {
            switch (field)
            {
                case Constants.Free: return Resources.free;
                case Constants.Filled: return Resources.filled;
                case Constants.HorizontalBee: return Resources.horizontal;
                case Constants.LeftRightBee: return Resources.left_right;
                case Constants.RightLeftBee: return Resources.right_left;
                case Constants.LeftCrossBee: return Resources.left_cross;
                case Constants.RightCrossBee: return Resources.right_cross;
                case Constants.HexBee: return Resources.hex;
                case Constants.CrossBee: return Resources.cross;
            }

            return null;
        }

        public static string beeName(int field)
        {
            switch (field)
            {
                case Constants.HorizontalBee: return "Horizontal --";
                case Constants.LeftRightBee: return "Left Right \\";
                case Constants.RightLeftBee: return "Right Left /";
                case Constants.LeftCrossBee: return "Left Cross -\\-";
                case Constants.RightCrossBee: return "Right Cross -/-";
                case Constants.HexBee: return "Hex -X-";
                case Constants.CrossBee: return "Cross X";
            }

            return null;
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to quit this level?", "Quit level", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                won = false;
                DialogResult = DialogResult.No;
                Close();
            }
        }

        private void RestartLevel()
        {
            Cursor = Cursors.Default;
            won = false;
            InitializeLevel(level);
            Invalidate(true);
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            RestartLevel();
        }

        private void Hint_Click(object sender, EventArgs e)
        {
            if (!HintUsed)
            {
                RestartLevel();
                HintUsed = true;
                lblHint.Text = "Hint used";
                lblHint.ForeColor = Color.Gray;
                BeeLeftClick(0);
                DropBee(Constants.LevelHints[level][0].X, Constants.LevelHints[level][0].Y);

            }

        }

        private int[][] TransformMatrix(int[][] matrix)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            int[][] Matrix = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                Matrix[i] = new int[2 * cols];
                for (int j = 0; j < cols; j++)
                {
                    if (i % 2 == 0)
                    {
                        Matrix[i][2 * j] = matrix[i][j];
                        Matrix[i][2 * j + 1] = Constants.Undefined;
                    }
                    else
                    {
                        Matrix[i][2 * j] = Constants.Undefined;
                        Matrix[i][2 * j + 1] = matrix[i][j];
                    }
                }
            }

            return Matrix;
        }
    }
}
