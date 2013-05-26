using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.IsolatedStorage;
using SeminarskaVizuelnoProgramiranje.Data;
using SeminarskaVizuelnoProgramiranje.Properties;

namespace SeminarskaVizuelnoProgramiranje
{
    public partial class SelectLevel : Form
    {
        public static int maxLevel; 
        Constants Constants;
        public List<Label> levels;

        public SelectLevel()
        {
            InitializeComponent();
            DoubleBuffered = true;

            Constants = new Constants();
            levels = new List<Label>();

            //Properties.Settings.Default.Level = 50;
            //Properties.Settings.Default.Save();         

            maxLevel = Properties.Settings.Default.Level;


            float y = 50;

            for (int i = 0; i < Constants.LevelMatrices.Count; i++)
            {
                int rows =  i / 10;
                int cols = i % 10;

                int jumpOffset = 0;

                if (rows % 2 != 0)
                {
                    jumpOffset = 30;
                }

                float x = 50 + jumpOffset;
                
                
                int countLvl = i + 1;

                Label lbl = new Label();
                lbl = new Label();
                lbl.Click += new EventHandler(Play);
                lbl.Location = new Point((int)x + 60 * cols, (int)y + 50 * rows);
                lbl.TextAlign = ContentAlignment.MiddleCenter;

                if (i < maxLevel)
                {
                    lbl.Image = Resources.filled;
                }
                else if (i == maxLevel)
                {
                    lbl.Image = Resources.selected;
                }
                else
                {
                    lbl.Image = Resources.free;
                }
                

                lbl.Height = 50;
                lbl.Width = 50;
                lbl.Text = countLvl + "";
                lbl.Font = new Font("Calibri", 10);
                lbl.ForeColor = Color.Black;
                lbl.Tag = i;
                lbl.Cursor = Cursors.Hand;
                lbl.BackColor = Color.Transparent;

                levels.Add(lbl);
                Controls.Add(lbl);
            }

            y += 48;
        }

        private void Play(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            StartGame((int)lb.Tag);
        }

        private void StartGame(int level) {
           if (level > maxLevel)
           {
                return;
           }

            Hide();
            Game newGame = new Game(level);
            newGame.ShowDialog();
            int oldLevel = level;
            level = newGame.level;
            Show();

            if (maxLevel <= level)
            {
                maxLevel = level;
                if (newGame.won)
                {
                    maxLevel++;
                }
                Properties.Settings.Default.Level = maxLevel;
                Properties.Settings.Default.Save();                
            }

            for (int i = oldLevel; i < maxLevel; i++)
            {
                levels[i].Image = Resources.filled;
            }

            if (maxLevel < levels.Count)
            {
                levels[maxLevel].Image = Resources.selected;
            }

            if (newGame.DialogResult == DialogResult.Yes)
            {
                StartGame(level + 1);
            }
        }

        private void pbMenuButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
