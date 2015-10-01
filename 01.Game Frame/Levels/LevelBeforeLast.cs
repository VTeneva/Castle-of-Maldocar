using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Game_Frame
{
    public class Graphics
    {
        public void BeforeLast()
        {
            for (int x = 2; x < 52; x++)
            {
                GameFrameBasics.PrintSymbol(x, 6, 'H', ConsoleColor.DarkGreen, ConsoleColor.DarkYellow);
                GameFrameBasics.PrintSymbol(x, 7, 'H', ConsoleColor.DarkGreen, ConsoleColor.DarkYellow);
                GameFrameBasics.PrintSymbol(x, 8, 'H', ConsoleColor.DarkGreen, ConsoleColor.DarkYellow);
                GameFrameBasics.PrintSymbol(x, 44, 'H', ConsoleColor.DarkGreen, ConsoleColor.DarkYellow);
                GameFrameBasics.PrintSymbol(x, 45, 'H', ConsoleColor.DarkGreen, ConsoleColor.DarkYellow);
                GameFrameBasics.PrintSymbol(x, 46, 'H', ConsoleColor.DarkGreen, ConsoleColor.DarkYellow);
            }

            for (int y = 8; y < 45; y++)
            {
                GameFrameBasics.PrintSymbol(2, y, 'H', ConsoleColor.DarkGreen, ConsoleColor.DarkYellow);
                GameFrameBasics.PrintSymbol(3, y, 'H', ConsoleColor.DarkGreen, ConsoleColor.DarkYellow);
                GameFrameBasics.PrintSymbol(4, y, 'H', ConsoleColor.DarkGreen, ConsoleColor.DarkYellow);
                GameFrameBasics.PrintSymbol(5, y, 'H', ConsoleColor.DarkGreen, ConsoleColor.DarkYellow);
                GameFrameBasics.PrintSymbol(48, y, 'H', ConsoleColor.DarkGreen, ConsoleColor.DarkYellow);
                GameFrameBasics.PrintSymbol(49, y, 'H', ConsoleColor.DarkGreen, ConsoleColor.DarkYellow);
                GameFrameBasics.PrintSymbol(50, y, 'H', ConsoleColor.DarkGreen, ConsoleColor.DarkYellow);
                GameFrameBasics.PrintSymbol(51, y, 'H', ConsoleColor.DarkGreen, ConsoleColor.DarkYellow);
            }

            for (int i = 0; i < treesCoordinates.Count; i++)
            {
                foreach (string coord in treesCoordinates)
                {
                    List<int> currCoord = new List<int>();
                    currCoord = coord.Split(',').Select(int.Parse).ToList();
                    GameFrameBasics.PrintSymbol(currCoord[0], currCoord[1], '@', ConsoleColor.DarkGreen, ConsoleColor.Black);
                    GameFrameBasics.PrintSymbol(currCoord[0], currCoord[1] + 1, '|', ConsoleColor.DarkRed, ConsoleColor.Black);

                    Dictionary<string, int> treeHead = new Dictionary<string, int>();
                    treeHead.Add("col", currCoord[0]);
                    treeHead.Add("row", currCoord[1]);
                    forbiddenCoordsLevelBeforeLast.Add(treeHead);

                    Dictionary<string, int> treeStem = new Dictionary<string, int>();
                    treeStem.Add("col", currCoord[0]);
                    treeStem.Add("row", currCoord[1]);
                    forbiddenCoordsLevelBeforeLast.Add(treeStem);
                }
            }
        }

        public List<string> treesCoordinates = new List<string> {

            "42,11",    "42,13",    "43,13",    "44,13",    "45,13",
            "24,15",    "25,15",    "41,15",    "42,15",    "43,15",    "44,15",    "45,15",    "46,15",
            "24,17",    "25,17",    "41,17",    "42,17",    "43,17",    "44,17",    "45,17",    "46,17",
            "28,18",    "34,18",    "29,19",    "31,19",    "33,19",    "39,19",    "40,19",    "41,19",
            "42,19",    "43,19",    "44,19",    "45,19",    "46,19",    "47,19",    "23,16",
            "23,20",    "24,20",    "27,20",    "30,20",    "32,20",    "45,21",    "46,21",    "47,21",
            "25,21",    "28,21",    "29,21",    "39,21",    "40,21",    "41,21",    "42,21",    "43,21",    "44,21",
            "22,22",    "23,22",    "27,22",    "31,22",    "24,23",    "25,23",    "26,23",    "28,23",    "29,23",    "32,23",    "39,23",    "40,23",
            "22,24",    "23,24",    "31,24",    "24,25",    "25,25",    "26,25",    "27,25",    "29,25",    "38,25",    "39,25",    "40,25",
            "23,26",    "28,26",    "38,27",    "39,27",    "40,27",    "26,28",    "43,31",    "44,31",    "45,31",    "46,31",
            "38,29",    "39,29",    "40,29",    "38,31",    "39,31",    "40,31",    "41,31",    "42,31",
            "39,33",    "40,33",    "41,33",    "42,33",    "43,33",    "44,33",    "45,33",    "46,33",
            "41,35",    "42,35",    "43,35",    "44,35",    "45,35",    "42,37",    "43,37",    "44,37",
        };

        public List<Dictionary<string, int>> forbiddenCoordsLevelBeforeLast = new List<Dictionary<string, int>>(); 
    }
}
