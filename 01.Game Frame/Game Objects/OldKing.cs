using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Game_Frame
{
    class OldKing
    {
        public OldKing(int col, int row, string nameKey)
        {
            this.Key = nameKey;

            this.PrintOldKing(col, row);

            this.ObjectSpecialCoordinates = SpecialCoordinates.SelectSpecialCoordinates(Key, Coordinates);
        }

        public string Key { get; set; }

        public string[] Object = new string[] {
                @" MMM ",
                @" o,O ",
                @"'{(}'",
                @" o o ",
                };

        public List<ConsoleColor> ColorsBack = new List<ConsoleColor> { ConsoleColor.Black, ConsoleColor.White };
        public List<ConsoleColor> Colors = new List<ConsoleColor> { ConsoleColor.Yellow, ConsoleColor.Black,
            ConsoleColor.White, ConsoleColor.Red, ConsoleColor.Blue };

        public List<Dictionary<string, int>> Coordinates = new List<Dictionary<string, int>>();

        public List<Dictionary<string, int>> ObjectSpecialCoordinates { get; set; }
        public string MessageOnSpecial = @"Look at this old king here. Poor old man! Some gold will might bring his smile back. Press <G> to give him 5 coins or press <N> to ignore his sorrow. "; 

        public void PrintOldKing(int col, int row)
        {
            Console.SetCursorPosition(col, row);
            Console.ForegroundColor = Colors[0];
            Console.BackgroundColor = ColorsBack[0];

            List<Dictionary<string, int>> coorDict = new List<Dictionary<string, int>>();
            for (int top = 0; top < this.Object.Length; top++)
            {
                for (int left = 0; left < this.Object[top].Length; left++)
                {
                    Dictionary<string, int> coor = new Dictionary<string, int>();
                    coor.Add("col", left + col);
                    coor.Add("row", top + row);
                    coorDict.Add(coor);

                    Console.SetCursorPosition(coor["col"], coor["row"]);
                    Console.Write(this.Object[top][left]);
                }
            }
            this.Coordinates = coorDict;
        }
    }
}
