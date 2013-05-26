using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskaVizuelnoProgramiranje.Data
{
    public class Bee
    {
        public Point Position;
        public Point DropCoordinates;
        public bool Visible;
        public bool Dropped;
        public int DropTimer;
        public int BeeType;
        public int i;

        public Bee(int X, int Y, int i, int bee)
        {
            Position.X = X;
            Position.Y = Y;
            this.i = i;
            Visible = true;
            Dropped = false;
            DropTimer = -1;

            BeeType = bee;
        }

        public void Draw(Graphics g)
        {
            if (Visible)
            {
                g.DrawImage(Game.getResourceImage(BeeType), Position.X, Position.Y, 50, 50);
            }
            
        }

        public bool IsHit(Point P)
        {
            int x = P.X;
            int y = P.Y;

            if (x >= Position.X && x <= Position.X + 50 && y >= Position.Y && y <= Position.Y + 50)
            {
                return true;
            }
            return false;
        }
    }
}
