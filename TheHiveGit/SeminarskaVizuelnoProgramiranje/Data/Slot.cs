using SeminarskaVizuelnoProgramiranje.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskaVizuelnoProgramiranje.Data
{
    public class Slot
    {
        public Point Position;
        public bool Hovered;
        public int State;
        public int BeeIndex;
        public int i;
        public int j;

        public Slot(int X, int Y)
        {
            Position.X = X;
            Position.Y = Y;

            Hovered = false;
            State = Constants.Free;
            BeeIndex = -1;
        }

        public void Draw(Graphics g)
        {
            if (State == Constants.Empty || State == Constants.Undefined)
            {
                return;
            }

            Image tmp;

            if (State == Constants.Free)
            {
                if (Hovered)
                {
                    tmp = Resources.selected;
                }
                else
                {
                    tmp = Resources.free;
                }
            }
            else
            {
                tmp = Resources.filled;
            }

            g.DrawImage(tmp, Position.X, Position.Y, 50, 50);

            // If State is not Filled or Free, then it has a Bee in it. Draw the bee.
            if (HasBee())
            {
                g.DrawImage(Game.getResourceImage(State), Position.X + 10, Position.Y + 10, 30, 30);
            }
            
        }

        public bool HasBee()
        {
            if (State != Constants.Filled && State != Constants.Free)
            {
                return true;
            }
            return false;
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
