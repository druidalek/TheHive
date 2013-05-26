using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskaVizuelnoProgramiranje.Data
{
    public class Constants
    {

        public const int Undefined = 10;
        public const int Free = 0;
        public const int Filled = 1;
        public const int Empty = 2;
        public const int HorizontalBee = 3;
        public const int LeftRightBee = 4;
        public const int RightLeftBee = 5;
        public const int CrossBee = 6;
        public const int LeftCrossBee = 7;
        public const int RightCrossBee = 8;
        public const int HexBee = 9;

        public const int Nothing = 0;
        public const int Bee = 1;
        public const int Slot = 2;


        public int[][] Horizontal;
        public int[][] LeftRight;
        public int[][] RightLeft;
        public int[][] Cross;
        public int[][] LeftCross;
        public int[][] RightCross;
        public int[][] Hex;

        public List<int[][]> LevelMatrices;
        public List<List<int>> LevelBees;
        public List<List<Point>> LevelHints;

        public Constants()
        {
            Horizontal = new int[][] { 
                new int[] { 0,  2 }, 
                new int[] { 0, -2 } 
            };
            LeftRight = new int[][] { 
                new int[] { -1, -1 }, 
                new int[] {  1,  1 } 
            };
            RightLeft = new int[][] { 
                new int[] { -1,  1 }, 
                new int[] {  1, -1 } 
            };
            Cross = new int[][] { 
                new int[] { -1, -1 }, 
                new int[] {  1,  1 }, 
                new int[] {  1, -1 }, 
                new int[] { -1,  1 } 
            };
            LeftCross = new int[][] { 
                new int[] { -1, -1 }, 
                new int[] {  1,  1 }, 
                new int[] {  0, -2 },
                new int[] {  0,  2 } 
            };
            RightCross = new int[][] { 
                new int[] {  0, -2 }, 
                new int[] {  0,  2 }, 
                new int[] {  1, -1 }, 
                new int[] {  -1, 1 } 
            };
            Hex = new int[][] { 
                new int[] {  0, -2 }, 
                new int[] {  0,  2 }, 
                new int[] { -1, -1 }, 
                new int[] {  1,  1 }, 
                new int[] {  1, -1 }, 
                new int[] { -1,  1 } 
            };

            
            LevelMatrices = new List<int[][]>();
            LevelBees = new List<List<int>>();
            LevelHints = new List<List<Point>>();

            List<string> matrixString = new List<string>();
            int[][] matrix;
            List<int> beesArray;
            List<Point> hints;

            //LEVEL 1
            matrixString.Add("0000.0000.--00.-0-0.-0--");
            beesArray = new List<int>() { Constants.HexBee, Constants.HorizontalBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(1, 5), new Point(0, 2) };
            LevelHints.Add(hints);

            //LEVEL 2
            matrixString.Add("0000.00--.000-.0-0-.00-0");
            beesArray = new List<int>() { Constants.HexBee, Constants.CrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(0, 2), new Point(3, 1) };
            LevelHints.Add(hints);

            //LEVEL 3
            matrixString.Add("-0-0.-00-.0000.0000.---0");
            beesArray = new List<int>() { Constants.HexBee, Constants.HorizontalBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(2, 4), new Point(3, 1) };
            LevelHints.Add(hints);

            //LEVEL 4
            matrixString.Add("0000.--00.0-0-.00--.0000");
            beesArray = new List<int>() { Constants.LeftCrossBee, Constants.HexBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(0, 6), new Point(4, 2) };
            LevelHints.Add(hints);

            //LEVEL 5
            matrixString.Add("0000.000-.0-00.-0-0.-0--");
            beesArray = new List<int>() { Constants.HexBee, Constants.RightLeftBee, Constants.LeftRightBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(1, 5), new Point(0, 2), new Point(0, 0) };
            LevelHints.Add(hints);

            //LEVEL 6
            matrixString.Add("--0-.0000.0000.0-0-.0-0-");
            beesArray = new List<int>() { Constants.RightCrossBee, Constants.RightCrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(1, 3), new Point(2, 6) };
            LevelHints.Add(hints);

            //LEVEL 7
            matrixString.Add("-00-.00--.000-.0000.0--0");
            beesArray = new List<int>() { Constants.RightCrossBee, Constants.CrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(3, 1), new Point(0, 2) };
            LevelHints.Add(hints);

            //LEVEL 8
            matrixString.Add("0000.0---.0000.0---.0000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HorizontalBee, Constants.HorizontalBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(2, 0), new Point(0, 0), new Point(4, 0) };
            LevelHints.Add(hints);

            //LEVEL 9
            matrixString.Add("00000.--00-.00000.-000-.-00-0.00---");
            beesArray = new List<int>() { Constants.HexBee, Constants.RightCrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(2, 6), new Point(0, 6) };
            LevelHints.Add(hints);

            //LEVEL 10
            matrixString.Add("-000-.000--.00000.00000.00---.0----");
            beesArray = new List<int>() { Constants.RightCrossBee, Constants.RightCrossBee, Constants.RightLeftBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(3, 1), new Point(2, 4), new Point(0, 2) };
            LevelHints.Add(hints);

            //LEVEL 11
            matrixString.Add("--00-0.--0-0-.--000-.000000.000000.0-0-0-.000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.RightCrossBee, Constants.HorizontalBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(3, 7), new Point(4, 2), new Point(6, 2) };
            LevelHints.Add(hints);

            //LEVEL 12
            matrixString.Add("000000.-0--00.-00-00.0-000-.0--00--.000000.--000-");
            beesArray = new List<int>() { Constants.HexBee, Constants.RightCrossBee, Constants.RightLeftBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(5, 7), new Point(0, 10), new Point(2, 2) };
            LevelHints.Add(hints);

            //LEVEL 13
            matrixString.Add("000000.0-00--.00-0--.0000--.-00-0-.-00-00.000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.LeftCrossBee, Constants.CrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(6, 10), new Point(0, 0), new Point(5, 3) };
            LevelHints.Add(hints);

            //LEVEL 14
            matrixString.Add("000---.000000.00-0--.-0-0---.--0-0-.000000.000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.HorizontalBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(1, 1), new Point(6, 10), new Point(5, 1) };
            LevelHints.Add(hints);

            //LEVEL 15
            matrixString.Add("000000.-0-00-.00-0-0.000000.000000.-0----.-00---");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.HorizontalBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(3, 1), new Point(0, 8), new Point(4, 8) };
            LevelHints.Add(hints);

            //LEVEL 16
            matrixString.Add("000---.000000.-000-0-.00000-.0-000-.--0000.---000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.CrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(1, 3), new Point(5, 9), new Point(6, 6) };
            LevelHints.Add(hints);

            //LEVEL 17
            matrixString.Add("000000.0--0--.-0-00--.000000.000000.-00-00.-0-00-");
            beesArray = new List<int>() { Constants.HexBee, Constants.RightCrossBee, Constants.LeftCrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(4, 4), new Point(3, 11), new Point(0, 6) };
            LevelHints.Add(hints);

            //LEVEL 18
            matrixString.Add("000---.000000.00-0---.-0-0-0.--0-00.000000.000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.HorizontalBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(1, 1), new Point(5, 9), new Point(6, 0) };
            LevelHints.Add(hints);

            //LEVEL 19
            matrixString.Add("-000--.000000.0000---.000000.00-00-.-0-00-.--0-00");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.LeftRightBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(1, 5), new Point(3, 1), new Point(0, 2) };
            LevelHints.Add(hints);

            //LEVEL 20
            matrixString.Add("0-0-0-.000000.-0-0---.0000--.000000.000000.-0-0-0");
            beesArray = new List<int>() { Constants.HexBee, Constants.LeftCrossBee, Constants.RightCrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(4, 4), new Point(5, 9), new Point(1, 3) };
            LevelHints.Add(hints);

            //LEVEL 21
            matrixString.Add("--0-00.--000-.000000.000000.000000.-00-0-.-00-00");
            beesArray = new List<int>() { Constants.HexBee, Constants.RightCrossBee, Constants.RightCrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(2, 6), new Point(4, 6), new Point(3, 11) };
            LevelHints.Add(hints);

            //LEVEL 22
            matrixString.Add("0-00--.000---.0000--.00-0-0.000000.000-0-.0-0000");
            beesArray = new List<int>() { Constants.HexBee, Constants.CrossBee, Constants.CrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(4, 2), new Point(2, 2), new Point(5, 9) };
            LevelHints.Add(hints);

            //LEVEL 23
            matrixString.Add("--0--0.-00-0-.000000.000000.000000.0-0-0-.-00--0");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.HorizontalBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(3, 7), new Point(4, 0), new Point(2, 0) };
            LevelHints.Add(hints);

            //LEVEL 24
            matrixString.Add("000000.000000.-00-0-.00-0--.000000.0-0---.000---");
            beesArray = new List<int>() { Constants.HexBee, Constants.RightCrossBee, Constants.HexBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(4, 0), new Point(1, 9), new Point(0, 6) };
            LevelHints.Add(hints);

            //LEVEL 25
            matrixString.Add("000---.000000.00-0-0.-0-000.--0-00.000000.000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.RightCrossBee, Constants.CrossBee, Constants.HorizontalBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(1, 1), new Point(6, 8), new Point(4, 8), new Point(5, 11) };
            LevelHints.Add(hints);

            //LEVEL 26
            matrixString.Add("0000--.0-00--.00-00-.-0-00-.--0-00.000000.000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.LeftCrossBee, Constants.HexBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(1, 1), new Point(6, 10), new Point(5, 11) };
            LevelHints.Add(hints);

            //LEVEL 27
            matrixString.Add("0-000-.0-00--.-000--.000000.-00-00.000-00.000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.RightLeftBee, Constants.RightLeftBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(5, 9), new Point(3, 3), new Point(1, 7), new Point(6, 4) };
            LevelHints.Add(hints);

            //LEVEL 28
            matrixString.Add("0-0-00.0-0-00.-0-000.-0-000.--000-.000000.000000");
            beesArray = new List<int>() { Constants.RightCrossBee, Constants.LeftCrossBee, Constants.CrossBee, Constants.LeftRightBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(6, 4), new Point(5, 9), new Point(2, 10), new Point(0, 0) };
            LevelHints.Add(hints);

            //LEVEL 29
            matrixString.Add("--0-00.000000.---000.000000.000000.0-000-.-000-0");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.LeftRightBee, Constants.HorizontalBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(1, 9), new Point(4, 8), new Point(5, 1), new Point(3, 1) };
            LevelHints.Add(hints);

            //LEVEL 30
            matrixString.Add("000000.0-000-.-000-0.-00--0.000---.000000.000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.CrossBee, Constants.HorizontalBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(0, 8), new Point(5, 1), new Point(1, 1), new Point(6, 8) };
            LevelHints.Add(hints);

            //LEVEL 31
            matrixString.Add("000-0-.0000--.0000--.0-00-0.-00000.-0-00-.-00-00");
            beesArray = new List<int>() { Constants.HexBee, Constants.CrossBee, Constants.HexBee, Constants.RightLeftBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(6, 8), new Point(2, 6), new Point(2, 0), new Point(0, 0) };
            LevelHints.Add(hints);

            //LEVEL 32
            matrixString.Add("000000.-00-0-.0000-0.000000.00--00.00--0-.0-0-00");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.CrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(0, 4), new Point(3, 11), new Point(4, 2) };
            LevelHints.Add(hints);

            //LEVEL 33
            matrixString.Add("--00--.000000.000000.00-000.000000.0---00.0---00");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.RightCrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(1, 5), new Point(4, 10), new Point(2, 2) };
            LevelHints.Add(hints);

            //LEVEL 34
            matrixString.Add("000000.000000.00--00.000000.-0000-.-000--.--00--");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.LeftCrossBee, Constants.RightLeftBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(1, 9), new Point(3, 1), new Point(0, 0), new Point(4, 8) };
            LevelHints.Add(hints);

            //LEVEL 35
            matrixString.Add("000000.000000.0000--.-000--.--000-.000000.---000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.HorizontalBee, Constants.LeftRightBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(5, 9), new Point(1, 1), new Point(0, 6), new Point(2, 4) };
            LevelHints.Add(hints);

            //LEVEL 36
            matrixString.Add("--00--.-000--.-0000-.00-00-.00--00.000000.000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.RightCrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(0, 4), new Point(5, 11), new Point(6, 0) };
            LevelHints.Add(hints);

            //LEVEL 37
            matrixString.Add("000000.--000-.---000.000000.000000.000000.-0--00");
            beesArray = new List<int>() { Constants.HexBee, Constants.LeftCrossBee, Constants.LeftCrossBee, Constants.LeftCrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(5, 9), new Point(3, 9), new Point(0, 8), new Point(4, 0) };
            LevelHints.Add(hints);

            //LEVEL 38
            matrixString.Add("-00-0-.-000-0.000000.000000.--000-.-0000-.000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.LeftRightBee, Constants.HorizontalBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(2, 6), new Point(6, 6), new Point(0, 2), new Point(3, 1) };
            LevelHints.Add(hints);

            //LEVEL 39
            matrixString.Add("00-0---.000---0.0000000.0000000.0000000.0-000--.0000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.RightCrossBee, Constants.LeftCrossBee, Constants.HorizontalBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(2, 4), new Point(3, 11), new Point(4, 4), new Point(6, 2) };
            LevelHints.Add(hints);

            //LEVEL 40
            matrixString.Add("--0-000.0000000.---0000.0000000.0000000.--00000.--00-0-");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.RightCrossBee, Constants.LeftRightBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(4, 12), new Point(3, 7), new Point(1, 11), new Point(2, 12) };
            LevelHints.Add(hints);

            //LEVEL 41
            matrixString.Add("-0000--.0000000.--00-0-.-000-0-.00000-0.0000000.0000000.0000000.0-0--00");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.LeftCrossBee, Constants.LeftCrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(1, 5), new Point(6, 2), new Point(5, 13), new Point(7, 9) };
            LevelHints.Add(hints);

            //LEVEL 42
            matrixString.Add("0000000.0000---.00-0---.0000---.000-0--.0000000.0000000.0-00-0-.0000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.LeftCrossBee, Constants.RightCrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(0, 4), new Point(8, 6), new Point(5, 5), new Point(6, 2) };
            LevelHints.Add(hints);

            //LEVEL 43
            matrixString.Add("0--00--.0000000.-0-0000.-00-00-.0000000.0000000.-0-00-0.0000000.0--000-");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.HexBee, Constants.HorizontalBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(1, 7), new Point(5, 7), new Point(7, 7), new Point(4, 12) };
            LevelHints.Add(hints);

            //LEVEL 44
            matrixString.Add("00-00-0.0000000.0000000.-00-00-.-000000.0-000-0.00000--.0-000--.-00000-");
            beesArray = new List<int>() { Constants.HexBee, Constants.CrossBee, Constants.HexBee, Constants.LeftCrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(2, 10), new Point(6, 0), new Point(6, 8), new Point(1, 1) };
            LevelHints.Add(hints);

            //LEVEL 45
            matrixString.Add("0-000--.0000000.00-00--.0000000.000-000.-00-00-.0000000.0-00000.0--00-0");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.HexBee, Constants.LeftRightBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(1, 7), new Point(3, 1), new Point(6, 10), new Point(0, 0) };
            LevelHints.Add(hints);

            //LEVEL 46
            matrixString.Add("000---0.000--0-.-000-0-.0000000.0000000.0-000-0.0000000.-00000-.--0-000");
            beesArray = new List<int>() { Constants.HexBee, Constants.LeftCrossBee, Constants.LeftCrossBee, Constants.CrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(4, 8), new Point(3, 3), new Point(6, 2), new Point(8, 10) };
            LevelHints.Add(hints);

            //LEVEL 47
            matrixString.Add("-000-00.0000000.0000000.0000000.-0-000-.000-00-.0-0-000.-000-00.-0-0--0");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.HexBee, Constants.CrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(1, 13), new Point(2, 0), new Point(3, 7), new Point(0, 6) };
            LevelHints.Add(hints);

            //LEVEL 48
            matrixString.Add("0000000.00--0--.0-0-00-.0-00-0-.0000000.-000--0.0000000.0000000.-0-0-00");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.RightCrossBee, Constants.LeftCrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(0, 2), new Point(6, 4), new Point(7, 13), new Point(4, 12) };
            LevelHints.Add(hints);

            //LEVEL 49
            matrixString.Add("0000000.0000000.--0000-.-0-0-0-.-0-00-0.0-0-0-0.0000000.00---00.0000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.HexBee, Constants.HorizontalBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(1, 9), new Point(6, 0), new Point(8, 12), new Point(0, 0) };
            LevelHints.Add(hints);

            //LEVEL 50
            matrixString.Add("0-00-00.0000000.-00000-.-0-00--.0000000.0-000--.0-00-0-.0000-0-.0000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.LeftCrossBee, Constants.RightLeftBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(4, 8), new Point(8, 2), new Point(1, 1), new Point(0, 6) };
            LevelHints.Add(hints);

            //LEVEL 51
            matrixString.Add("00-0--0.0000000.000--0-.-00-0-0.00000-0.0000000.00-000-.0000000.--0-00-");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.HexBee, Constants.RightLeftBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(1, 1), new Point(7, 9), new Point(5, 1), new Point(0, 12) };
            LevelHints.Add(hints);

            //LEVEL 52
            matrixString.Add("0000000.0000000.-000-00.-000-00.-00-0-0.000-000.0000000.0--000-.0---0-0");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.CrossBee, Constants.LeftCrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(0, 8), new Point(6, 10), new Point(3, 3), new Point(1, 11) };
            LevelHints.Add(hints);

            //LEVEL 53
            matrixString.Add("00000--.0000000.0000--0.000--0-.0000-0-.00000--.00000--.0000000.00-000-");
            beesArray = new List<int>() { Constants.CrossBee, Constants.HexBee, Constants.HexBee, Constants.CrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(7, 1), new Point(7, 7), new Point(1, 3), new Point(4, 2) };
            LevelHints.Add(hints);

            //LEVEL 54
            matrixString.Add("00-0--0.0-00-0-.0000000.0000000.-00-000.0000000.0-00-00.--000-0.--000--");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.HexBee, Constants.RightLeftBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(2, 0), new Point(3, 3), new Point(5, 11), new Point(0, 12) };
            LevelHints.Add(hints);

            //LEVEL 55
            matrixString.Add("0000000.-000-0-.0-0000-.000-0--.0000000.00-0-0-.0000000.0000000.0-00-0-");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.HexBee, Constants.LeftCrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(0, 6), new Point(7, 5), new Point(6, 2), new Point(4, 6) };
            LevelHints.Add(hints);

            //LEVEL 56
            matrixString.Add("0000000.0000000.0000000.0000-0-.-000--0.-000--0.--000--.0000000.-0-000-");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.LeftCrossBee, Constants.LeftCrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(1, 9), new Point(7, 7), new Point(2, 0), new Point(0, 2) };
            LevelHints.Add(hints);

            //LEVEL 57
            matrixString.Add("0000000.-000000.-0000-0.00-00-0.00-000-.0-0-000.0000000.-0---00.-0---00");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.HexBee, Constants.RightLeftBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(0, 10), new Point(1, 5), new Point(6, 12), new Point(3, 1) };
            LevelHints.Add(hints);

            //LEVEL 58
            matrixString.Add("0000000.0000000.0000000.00-0-00.0-0-00-.0-0-0--.0000000.-0-0-0-.--000-0");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.HexBee, Constants.LeftCrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(0, 4), new Point(1, 1), new Point(2, 12), new Point(6, 2) };
            LevelHints.Add(hints);

            //LEVEL 59
            matrixString.Add("0---000.0--000-.-0-0-00.0000000.0000000.0000000.-0-0-0-.00000--.0000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.HexBee, Constants.LeftCrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(4, 4), new Point(3, 13), new Point(8, 4), new Point(5, 13) };
            LevelHints.Add(hints);

            //LEVEL 60
            matrixString.Add("--00-0-.--00000.---00-0.0000000.---0000.0000000.0-0-000.00-0000.0000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.HexBee, Constants.CrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(3, 13), new Point(5, 9), new Point(8, 2), new Point(0, 6) };
            LevelHints.Add(hints);

            //LEVEL 61
            matrixString.Add("0000000.0000---.-0000--.-00-0--.0000000.0000-0-.00-00-0.0000000.0000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.LeftCrossBee, Constants.HorizontalBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(4, 4), new Point(0, 6), new Point(7, 9), new Point(8, 6) };
            LevelHints.Add(hints);

            //LEVEL 62
            matrixString.Add("0000000.---0-00.0000000.0-0-000.000-00-.00-00--.0000000.0000000.0-00---");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.HexBee, Constants.HorizontalBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(2, 12), new Point(7, 5), new Point(6, 2), new Point(0, 2) };
            LevelHints.Add(hints);

            //LEVEL 63
            matrixString.Add("-0000-0.-000-00.0000000.0-0000-.-00000-.-0-000-.0000000.0000000.0-00-00");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.HexBee, Constants.CrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(2, 6), new Point(6, 8), new Point(7, 5), new Point(0, 6) };
            LevelHints.Add(hints);

            //LEVEL 64
            matrixString.Add("0-000--.00-0---.0000000.000-0-0.0-0--00.0000000.00-0-00.0000000.0000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.HexBee, Constants.HorizontalBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(2, 2), new Point(5, 11), new Point(7, 1), new Point(8, 6) };
            LevelHints.Add(hints);

            //LEVEL 65
            matrixString.Add("-000--0.0000-0-.0000000.0-000--.-0-000-.-0-0000.--00000.0000000.0000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.LeftCrossBee, Constants.HexBee, Constants.CrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(2, 0), new Point(8, 10), new Point(7, 11), new Point(3, 9) };
            LevelHints.Add(hints);

            //LEVEL 66
            matrixString.Add("0000000.0000000.-0000-0.0000000.--00-0-.-00000-.-0000-0.00-00-0.00-000-");
            beesArray = new List<int>() { Constants.HexBee, Constants.LeftCrossBee, Constants.CrossBee, Constants.HexBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(3, 5), new Point(0, 0), new Point(4, 10), new Point(1, 9) };
            LevelHints.Add(hints);

            //LEVEL 67
            matrixString.Add("0000000.00-0--0.000-0-0.-00-00-.0000000.0-0000-.-0-00-0.-0000-0.0000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.HexBee, Constants.LeftRightBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(4, 10), new Point(8, 4), new Point(0, 2), new Point(2, 2) };
            LevelHints.Add(hints);

            //LEVEL 68
            matrixString.Add("--00-00.--00-00.0000000.0000000.0000000.---0000.---0000.--00000.--00000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.RightCrossBee, Constants.CrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(3, 13), new Point(4, 10), new Point(2, 10), new Point(7, 11) };
            LevelHints.Add(hints);

            //LEVEL 69
            matrixString.Add("0-000-0.0-0-00-.-000-0-.-0-0000.0000000.0000000.0000000.0-0000-.-00-000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.HexBee, Constants.CrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(5, 13), new Point(6, 0), new Point(4, 8), new Point(8, 8) };
            LevelHints.Add(hints);

            //LEVEL 70
            matrixString.Add("-0--000.-0--000.0000000.0-0000-.-0-0000.0000000.0000000.-00000-.-000-0-");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.RightCrossBee, Constants.CrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(6, 4), new Point(2, 10), new Point(5, 9), new Point(8, 10) };
            LevelHints.Add(hints);

            //LEVEL 71
            matrixString.Add("0000000.000--00.0000000.--0000-.---000-.0000000.0--000-.0-0000-.0000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.RightCrossBee, Constants.LeftCrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(0, 2), new Point(5, 9), new Point(2, 10), new Point(8, 2) };
            LevelHints.Add(hints);

            //LEVEL 72
            matrixString.Add("0----00.0---00-.00--00-.00-00-0.-0000-0.0000000.0000000.0000000.0000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.RightCrossBee, Constants.LeftCrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(5, 7), new Point(6, 4), new Point(8, 8), new Point(7, 7) };
            LevelHints.Add(hints);

            //LEVEL 73
            matrixString.Add("-000-0-.0000000.0000000.-000--0.00-00--.0000000.00--00-.-0--000.0000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.LeftCrossBee, Constants.LeftCrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(5, 1), new Point(8, 12), new Point(1, 3), new Point(2, 12) };
            LevelHints.Add(hints);

            //LEVEL 74
            matrixString.Add("--00-00.0000000.-00000-.0000000.0000000.--0000-.0000000.-00-000.-00--00");
            beesArray = new List<int>() { Constants.HexBee, Constants.RightCrossBee, Constants.HexBee, Constants.LeftCrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(3, 9), new Point(1, 3), new Point(4, 6), new Point(6, 10) };
            LevelHints.Add(hints);

            //LEVEL 75
            matrixString.Add("0-00--0.000--0-.0000000.00--0--.000-0--.0000000.0000---.0000000.0000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.HexBee, Constants.HorizontalBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(2, 2), new Point(5, 1), new Point(7, 5), new Point(8, 0) };
            LevelHints.Add(hints);

            //LEVEL 76
            matrixString.Add("00-0-0-.0000000.00--0-0.00-000-.0000000.-00-000.--000-0.0000000.-0-000-");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.CrossBee, Constants.RightCrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(1, 1), new Point(4, 10), new Point(6, 4), new Point(7, 11) };
            LevelHints.Add(hints);

            //LEVEL 77
            matrixString.Add("0000000.0-000-0.-00-000.-0--000.-00--00.0000000.0--0000.---0000.0000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.HexBee, Constants.RightLeftBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(0, 6), new Point(5, 13), new Point(8, 8), new Point(1, 13) };
            LevelHints.Add(hints);

            //LEVEL 78
            matrixString.Add("00---00.0000000.000-000.0000000.0000000.-0000--.--000--.-0000--.0000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.HexBee, Constants.LeftRightBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(1, 11), new Point(4, 6), new Point(8, 6), new Point(0, 0) };
            LevelHints.Add(hints);

            //LEVEL 79
            matrixString.Add("0000000.0000000.0-00000.-00000-.0000000.0--000-.0--0000.--00000.--00-00");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.HexBee, Constants.RightLeftBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(0, 2), new Point(1, 5), new Point(4, 10), new Point(2, 10) };
            LevelHints.Add(hints);

            //LEVEL 80
            matrixString.Add("0000000.0-00-0-.000000-.000-0--.000-00-.0000000.0000--0.0000000.0-000--");
            beesArray = new List<int>() { Constants.LeftCrossBee, Constants.HexBee, Constants.HexBee, Constants.CrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(0, 0), new Point(5, 1), new Point(7, 5), new Point(1, 7) };
            LevelHints.Add(hints);

            //LEVEL 81
            matrixString.Add("0-0-000.0-0-000.0000000.-0-000-.--00000.--000-0.0-0000-.0000000.0000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.LeftCrossBee, Constants.CrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(2, 10), new Point(8, 2), new Point(7, 7), new Point(5, 9) };
            LevelHints.Add(hints);

            //LEVEL 82
            matrixString.Add("-000-00.-00000-.0-0000-.0000000.-0-000-.-00000-.0000000.0000000.-000-00");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.LeftCrossBee, Constants.LeftRightBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(3, 9), new Point(6, 4), new Point(7, 11), new Point(0, 2) };
            LevelHints.Add(hints);

            //LEVEL 83
            matrixString.Add("00000000.-0-0--00.00000000.--0-00-0.--00-0-0.00000000.00000000.0--0000-.00000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.RightCrossBee, Constants.LeftCrossBee, Constants.HexBee, Constants.HorizontalBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(0, 14), new Point(6, 2), new Point(2, 8), new Point(8, 10), new Point(5, 5) };
            LevelHints.Add(hints);

            //LEVEL 84
            matrixString.Add("0-0--00-.00000000.00000000.00-00--0.0-000--0.--000-0-.0-00-00-.00000000.00000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.HexBee, Constants.RightCrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(2, 2), new Point(7, 11), new Point(8, 2), new Point(1, 11) };
            LevelHints.Add(hints);

            //LEVEL 85
            matrixString.Add("00000000.00000000.00000000.00-0-0--.0-00-00-.--0-0-0-.--000--0.00000000.00000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.RightCrossBee, Constants.HorizontalBee, Constants.HorizontalBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(1, 9), new Point(7, 7), new Point(0, 4), new Point(2, 6), new Point(8, 10) };
            LevelHints.Add(hints);

            //LEVEL 86
            matrixString.Add("0-0-00--.00000---.00000000.00000000.00000---.-00-0---.00000000.00000000.00-00-0-");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.HexBee, Constants.HorizontalBee, Constants.LeftRightBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(2, 2), new Point(3, 7), new Point(7, 1), new Point(6, 8), new Point(4, 2) };
            LevelHints.Add(hints);

            //LEVEL 87
            matrixString.Add("00000000.-000-0--.-000000-.0-000-00.00000000.00000000.---00000.00000000.--0--000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.HexBee, Constants.HexBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(0, 4), new Point(5, 7), new Point(7, 13), new Point(4, 14) };
            LevelHints.Add(hints);

            //LEVEL 88
            matrixString.Add("00000000.0-000--0.0--00--0.00000000.--00000-.00000000.000--00-.00--000-.00000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.RightCrossBee, Constants.RightCrossBee, Constants.LeftRightBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(3, 7), new Point(5, 11), new Point(0, 2), new Point(8, 0), new Point(6, 0) };
            LevelHints.Add(hints);

            //LEVEL 89
            matrixString.Add("0-0--0-0.00000000.-0-0000-.-0-0000-.0-0000-0.00000000.00000000.00000000.-0000-0-");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.LeftCrossBee, Constants.HexBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(7, 3), new Point(5, 9), new Point(1, 11), new Point(6, 6) };
            LevelHints.Add(hints);

            //LEVEL 90
            matrixString.Add("0000-0--.00000---.00000000.00000---.0-0000--.0-0000-0.-0000000.00000000.00000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.HexBee, Constants.LeftRightBee, Constants.LeftRightBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(2, 2), new Point(8, 12), new Point(7, 3), new Point(0, 6), new Point(0, 2) };
            LevelHints.Add(hints);

            //LEVEL 91
            matrixString.Add("0-0-00-0.00000000.00--000-.00000000.0000-000.00000000.00000000.-000---0.-0-00---");
            beesArray = new List<int>() { Constants.HexBee, Constants.CrossBee, Constants.LeftCrossBee, Constants.LeftCrossBee, Constants.RightCrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(3, 1), new Point(0, 10), new Point(6, 6), new Point(5, 13), new Point(1, 13) };
            LevelHints.Add(hints);

            //LEVEL 92
            matrixString.Add("00-0000-.000000--.00000000.-00-000-.-0000000.00000000.0--00-00.--000-00.00000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.CrossBee, Constants.LeftCrossBee, Constants.LeftCrossBee, Constants.CrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(5, 7), new Point(0, 6), new Point(8, 8), new Point(2, 12), new Point(0, 8) };
            LevelHints.Add(hints);

            //LEVEL 93
            matrixString.Add("0-0---00.00000000.00000000.00--00-0.00000000.-0000-0-.00000000.--00-0--.00000000");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.RightCrossBee, Constants.RightCrossBee, Constants.HorizontalBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(8, 6), new Point(6, 6), new Point(4, 14), new Point(1, 3), new Point(2, 4) };
            LevelHints.Add(hints);

            //LEVEL 94
            matrixString.Add("--0000--.-00000-0.-0-00000.00000000.00000000.-00-0000.00000000.00--0000.00--0000");
            beesArray = new List<int>() { Constants.CrossBee, Constants.HexBee, Constants.HexBee, Constants.CrossBee, Constants.RightCrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(0, 4), new Point(6, 12), new Point(3, 13), new Point(0, 8), new Point(4, 6) };
            LevelHints.Add(hints);

            //LEVEL 95
            matrixString.Add("00-0-00-.000-0-0-.00000000.00000000.00000000.0-00--0-.00000000.00-000--.-0--00--");
            beesArray = new List<int>() { Constants.HexBee, Constants.CrossBee, Constants.LeftCrossBee, Constants.RightCrossBee, Constants.LeftCrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(4, 6), new Point(6, 0), new Point(6, 6), new Point(3, 15), new Point(2, 14) };
            LevelHints.Add(hints);

            //LEVEL 96
            matrixString.Add("000---0-.00000000.0000-0--.00000---.-0000---.00000000.00000000.00000000.--00000--");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.LeftCrossBee, Constants.LeftCrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(7, 7), new Point(5, 7), new Point(1, 5), new Point(6, 4) };
            LevelHints.Add(hints);

            //LEVEL 97
            matrixString.Add("00000000.00000000.00000000.00000000.---000--.00000000.--0000--.-00000--.-000-00-");
            beesArray = new List<int>() { Constants.HexBee, Constants.RightCrossBee, Constants.LeftCrossBee, Constants.RightCrossBee, Constants.HorizontalBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(5, 7), new Point(3, 11), new Point(2, 6), new Point(1, 9), new Point(0, 6) };
            LevelHints.Add(hints);

            //LEVEL 98
            matrixString.Add("-0-00---.00-0---0.00000000.00000000.0000-00-.00000000.-00-000-.00000000.0-0000-0");
            beesArray = new List<int>() { Constants.HexBee, Constants.HexBee, Constants.HexBee, Constants.LeftCrossBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(2, 0), new Point(3, 5), new Point(5, 11), new Point(7, 3) };
            LevelHints.Add(hints);

            //LEVEL 99
            matrixString.Add("0--000-0.0--0000-.00000000.-0--0000.00000000.00000000.00000000.---0-000.---00000");
            beesArray = new List<int>() { Constants.HexBee, Constants.CrossBee, Constants.HexBee, Constants.LeftCrossBee, Constants.HorizontalBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(6, 14), new Point(4, 14), new Point(4, 10), new Point(2, 2), new Point(5, 1) };
            LevelHints.Add(hints);

            //LEVEL 100
            matrixString.Add("0--000--.0--000-0.00000000.0000000-.-000-000.00000000.-000-000.00000-00.00-00-00");
            beesArray = new List<int>() { Constants.HexBee, Constants.CrossBee, Constants.HexBee, Constants.CrossBee, Constants.LeftRightBee };
            LevelBees.Add(beesArray);
            hints = new List<Point>() { new Point(5, 15), new Point(4, 12), new Point(2, 8), new Point(4, 4), new Point(3, 1) };
            LevelHints.Add(hints);


            foreach (string m in matrixString)
            {
                matrix = StringToMatrix(m);
                LevelMatrices.Add(matrix);
            }


        }

        public int[][] StringToMatrix(string s)
        {
            string[] split = s.Split('.');

            int[][] matrix = new int[split.Length][];

            for (int i = 0; i < split.Length; i++)
            {
                matrix[i] = new int[split[i].Length];
                for (int j = 0; j < split[i].Length; j++)
                {
                    if (split[i][j] == '0')
                    {
                        matrix[i][j] = Constants.Free;
                    }
                    else
                    {
                        matrix[i][j] = Constants.Empty;
                    }
                }
            }

            return matrix;
        }

        public int[] StringToArray(string s)
        {
            int[] array = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                array[i] = int.Parse(s[i].ToString());
            }

            return array;
        }
    }
}
