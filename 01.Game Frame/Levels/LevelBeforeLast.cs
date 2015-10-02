using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Game_Frame
{
    public class LevelBeforeLast
    {
        public void PlayLevel()
        {
            Console.Clear();
            Console.CursorVisible = false;

            GameFrameBasics.GameFrame();
            BeforeLast();

            HeroMovement levelBeforeLast = new HeroMovement();
            levelBeforeLast.PrintGameFrame();

            Dictionary<string, int> currentHeroCoords = new Dictionary<string, int>();  //from Hero class
            ConsoleKeyInfo keyInfo;
            currentHeroCoords.Add("col", 6);  // Starting position - column
            currentHeroCoords.Add("row", 25);  // Starting position - row

            levelBeforeLast.PrintHero(currentHeroCoords);

            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Enter)
            {
                GameFrameBasics.PrintSymbol(currentHeroCoords["col"], currentHeroCoords["row"], ' ', ConsoleColor.Black, ConsoleColor.Black);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        levelBeforeLast.UpdateHeroCoords(currentHeroCoords, forbiddenCoordsLevelBeforeLast, "up");
                        break;

                    case ConsoleKey.RightArrow:
                        levelBeforeLast.UpdateHeroCoords(currentHeroCoords, forbiddenCoordsLevelBeforeLast, "right");
                        break;

                    case ConsoleKey.DownArrow:
                        levelBeforeLast.UpdateHeroCoords(currentHeroCoords, forbiddenCoordsLevelBeforeLast, "down");
                        break;

                    case ConsoleKey.LeftArrow:
                        levelBeforeLast.UpdateHeroCoords(currentHeroCoords, forbiddenCoordsLevelBeforeLast, "left");
                        break;
                }

                levelBeforeLast.PrintHero(currentHeroCoords);
            }

            GameObject ghost = new GameObject();
            ghost.DrawGhost(39,19);
        }

        // Forbidden coordinates specific for level Before Last.
        public List<Dictionary<string, int>> forbiddenCoordsLevelBeforeLast = new List<Dictionary<string, int>>();

        // Objects coordinates
        public List<string> crossCoordinates = new List<string> {

            "44,24",    "43,25",    "44,25",    "45,25",    "44,26",   "44,27"
        };

        public List<string> coinsCoordinates = new List<string> {

            "10,27",    "11,14",    "21,21",
        };

        public List<string> treesCoordinates = new List<string> {

            "42,11",    "42,13",    "43,13",    "44,13",    "45,13",    "45,31",    "38,25",    "29,23",    "46,31",    "32,9",
            "24,15",    "25,15",    "41,15",    "42,15",    "43,15",    "44,15",    "45,15",    "46,15",    "40,23",    "31,9",
            "24,17",    "25,17",    "41,17",    "42,17",    "43,17",    "44,17",    "45,17",    "46,17",    "39,23",
            "28,18",    "34,18",    "29,19",    "31,19",    "33,19",    "39,19",    "40,19",    "41,19",    "40,25",
            "42,19",    "43,19",    "44,19",    "45,19",    "46,19",    "47,19",    "23,16",    "44,21",    "32,23",
            "23,20",    "24,20",    "27,20",    "30,20",    "32,20",    "45,21",    "46,21",    "47,21",    "39,25",
            "25,21",    "28,21",    "29,21",    "39,21",    "40,21",    "41,21",    "42,21",    "43,21",    "33,9",
            "22,22",    "23,22",    "27,22",    "31,22",    "24,23",    "25,23",    "26,23",    "28,23",    "25,9",
            "22,24",    "23,24",    "31,24",    "24,25",    "25,25",    "26,25",    "27,25",    "29,25",    "26,9",
            "23,26",    "28,26",    "38,27",    "39,27",    "40,27",    "26,28",    "43,31",    "44,31",    "27,9",
            "38,29",    "39,29",    "40,29",    "38,31",    "39,31",    "40,31",    "41,31",    "42,31",    "28,9",
            "39,33",    "40,33",    "41,33",    "42,33",    "43,33",    "44,33",    "45,33",    "46,33",    "29,9",
            "41,35",    "42,35",    "43,35",    "44,35",    "45,35",    "42,37",    "43,37",    "44,37",    "30,9",                         
        };

        public List<string> hedgeCoordinates = new List<string> {
            "7,11","8,11","9,11","10,11","11,11","12,11","13,11","14,11","16,11","7,12","14,12","16,12","18,12","19,12","20,12",
            "21,12","22,12","23,12","24,12","25,12","26,12","27,12","28,12","29,12","30,12","31,12","32,12","33,12","7,13","9,13",
            "10,13","11,13","12,13","14,13","16,13","18,13","7,14","12,14","14,14","16,14","18,14","20,14","21,14","22,14",
            "23,14","24,14","25,14","26,14","27,14","28,14","29,14","30,14","31,14","32,14","33,14","34,14","7,15","8,15","9,15",
            "10,15","11,15","12,15","14,15","16,15","18,15","20,15","14,16","16,16","18,16","20,16","6,17","7,17","8,17","9,17",
            "10,17","11,17","14,17","16,17","18,17","20,17","11,18","14,18","16,18","18,18","20,18","7,19","8,19","9,19","11,19",
            "12,19","13,19","14,19","16,19","18,19","20,19","7,20","9,20","16,20","18,20","20,20","7,21","9,21","11,21","12,21",
            "13,21","14,21","16,21","18,21","20,21","7,22","9,22","11,22","14,22","16,22","18,22","20,22","9,23","11,23","16,23",
            "18,23","20,23","6,24","7,24","8,24","9,24","11,24","12,24","13,24","14,24","15,24","16,24","18,24","20,24","20,25",
            "6,26","7,26","9,26","10,26","11,26","12,26","13,26","14,26","15,26","16,26","17,26","18,26","20,26","7,27","9,27",
            "11,27","18,27","20,27","7,28","9,28","11,28","13,28","14,28","15,28","16,28","18,28","20,28","7,29","9,29","11,29",
            "13,29","18,29","20,29","7,30","9,30","11,30","13,30","14,30","15,30","16,30","17,30","18,30","20,30","22,30",
            "23,30","24,30","25,30","26,30","27,30","28,30","29,30","30,30","31,30","32,30","33,30","7,31","9,31","11,31","33,31",
            "7,32","9,32","11,32","12,32","13,32","14,32","15,32","16,32","17,32","18,32","19,32","20,32","21,32","22,32","23,32",
            "24,32","25,32","26,32","27,32","28,32","29,32","30,32","31,32","33,32","7,33","9,33","11,33","33,33","7,34","9,34",
            "11,34","13,34","14,34","15,34","16,34","17,34","18,34","19,34","20,34","21,34","22,34","23,34","24,34","25,34","26,34",
            "27,34","28,34","29,34","30,34","31,34","33,34","7,35","9,35","11,35","13,35","31,35","33,35","7,36","9,36","11,36",
            "13,36","15,36","16,36","17,36","18,36","19,36","20,36","21,36","22,36","23,36","24,36","25,36","26,36","27,36","28,36",
            "29,36","31,36","33,36","7,37","9,37","11,37","13,37","15,37","29,37","31,37","33,37","7,38","9,38","11,38","13,38",            
            "16,38","17,38","18,38","19,38","20,38","21,38","22,38","23,38","24,38","29,38","31,38","33,38","7,39","9,39","11,39",
            "13,39","29,39","31,39","33,39","7,40","9,40","11,40","13,40","14,40","15,40","16,40","17,40","18,40","19,40","20,40",
            "21,40","22,40","23,40","24,40","25,40","26,40","27,40","28,40","29,40","31,40","33,40","7,41","9,41","11,41","31,41",
            "33,41","7,42","8,42","9,42","11,42","12,42","13,42","14,42","15,42","16,42","17,42","18,42","19,42","20,42","21,42",
            "22,42","23,42","24,42","25,42","26,42","27,42","28,42","29,42","30,42","31,42","33,42","33,43","7,9","8,9","9,9",
            "10,9","11,9","12,9","13,9","14,9","23,9","16,10","17,10","18,10","19,10","20,10","21,10","22,10","23,10","15,38",
            "18,25","35,9","35,10","35,11","35,12","35,13","35,14",
        };

        // Printing the level's objects on the console.
        public void BeforeLast()
        {
            for (int x = 2; x < 52; x++)
            {
                GameFrameBasics.PrintSymbol(x, 6, 'H', ConsoleColor.DarkRed, ConsoleColor.DarkYellow);
                GameFrameBasics.PrintSymbol(x, 7, 'H', ConsoleColor.DarkRed, ConsoleColor.DarkYellow);
                GameFrameBasics.PrintSymbol(x, 8, 'H', ConsoleColor.DarkRed, ConsoleColor.DarkYellow);
                GameFrameBasics.PrintSymbol(x, 44, 'H', ConsoleColor.DarkRed, ConsoleColor.DarkYellow);
                GameFrameBasics.PrintSymbol(x, 45, 'H', ConsoleColor.DarkRed, ConsoleColor.DarkYellow);
                GameFrameBasics.PrintSymbol(x, 46, 'H', ConsoleColor.DarkRed, ConsoleColor.DarkYellow);
            }

            for (int y = 8; y < 45; y++)
            {
                GameFrameBasics.PrintSymbol(2, y, 'H', ConsoleColor.DarkRed, ConsoleColor.DarkYellow);
                GameFrameBasics.PrintSymbol(3, y, 'H', ConsoleColor.DarkRed, ConsoleColor.DarkYellow);
                GameFrameBasics.PrintSymbol(4, y, 'H', ConsoleColor.DarkRed, ConsoleColor.DarkYellow);
                GameFrameBasics.PrintSymbol(5, y, 'H', ConsoleColor.DarkRed, ConsoleColor.DarkYellow);
                GameFrameBasics.PrintSymbol(48, y, 'H', ConsoleColor.DarkRed, ConsoleColor.DarkYellow);
                GameFrameBasics.PrintSymbol(49, y, 'H', ConsoleColor.DarkRed, ConsoleColor.DarkYellow);
                GameFrameBasics.PrintSymbol(50, y, 'H', ConsoleColor.DarkRed, ConsoleColor.DarkYellow);
                GameFrameBasics.PrintSymbol(51, y, 'H', ConsoleColor.DarkRed, ConsoleColor.DarkYellow);
            }

            for (int i = 0; i < treesCoordinates.Count; i++)
            {
                foreach (string coord in treesCoordinates)
                {
                    List<int> currCoord = new List<int>();
                    currCoord = coord.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                    GameFrameBasics.PrintSymbol(currCoord[0], currCoord[1], 'G', ConsoleColor.DarkGreen, ConsoleColor.Black);

                    Dictionary<string, int> treeHead = new Dictionary<string, int>();
                    treeHead.Add("col", currCoord[0]);
                    treeHead.Add("row", currCoord[1]);
                    forbiddenCoordsLevelBeforeLast.Add(treeHead);
                }
            }

            for (int i = 0; i < treesCoordinates.Count; i++)
            {
                foreach (string coord in treesCoordinates)
                {
                    List<int> currCoord = new List<int>();
                    currCoord = coord.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                    GameFrameBasics.PrintSymbol(currCoord[0], currCoord[1] + 1, '|', ConsoleColor.DarkRed, ConsoleColor.Black);

                    Dictionary<string, int> treeStem = new Dictionary<string, int>();
                    treeStem.Add("col", currCoord[0]);
                    treeStem.Add("row", currCoord[1] + 1);
                    forbiddenCoordsLevelBeforeLast.Add(treeStem);
                }
            }

            for (int i = 0; i < hedgeCoordinates.Count; i++)
            {
                foreach (string coord in hedgeCoordinates)
                {
                    List<int> currCoord = new List<int>();
                    currCoord = coord.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                    GameFrameBasics.PrintSymbol(currCoord[0], currCoord[1], '%', ConsoleColor.DarkGreen, ConsoleColor.Black);

                    Dictionary<string, int> hedge = new Dictionary<string, int>();
                    hedge.Add("col", currCoord[0]);
                    hedge.Add("row", currCoord[1]);
                    forbiddenCoordsLevelBeforeLast.Add(hedge);
                }
            }
            for (int i = 0; i < coinsCoordinates.Count; i++)
            {
                foreach (string coord in coinsCoordinates)
                {
                    List<int> currCoord = new List<int>();
                    currCoord = coord.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                    GameFrameBasics.PrintSymbol(currCoord[0], currCoord[1], '$', ConsoleColor.Yellow, ConsoleColor.Black);

                    Dictionary<string, int> coin = new Dictionary<string, int>();
                    coin.Add("col", currCoord[0]);
                    coin.Add("row", currCoord[1]);
                    forbiddenCoordsLevelBeforeLast.Add(coin);
                }
            }

            for (int i = 0; i < crossCoordinates.Count; i++)
            {
                foreach (string coord in crossCoordinates)
                {
                    List<int> currCoord = new List<int>();
                    currCoord = coord.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                    GameFrameBasics.PrintSymbol(currCoord[0], currCoord[1], ' ', ConsoleColor.DarkGray, ConsoleColor.DarkGray);

                    Dictionary<string, int> cross = new Dictionary<string, int>();
                    cross.Add("col", currCoord[0]);
                    cross.Add("row", currCoord[1]);
                    forbiddenCoordsLevelBeforeLast.Add(cross);
                }
            }

            GameFrameBasics.PrintSymbol(44, 29, 'X', ConsoleColor.Red, ConsoleColor.Black);
        }
    }
}
