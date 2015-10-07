using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Game_Frame
{
    class Skull
    {
        public Skull(int col, int row, string nameKey)
        {
            this.Key = nameKey;

            this.PrintSkull(col, row);

            this.ObjectSpecialCoordinates = SpecialCoordinates.SelectSpecialCoordinates(Key, Coordinates);
        }

        public string Key { get; set; }

        public string[] Object = new string[] {
                @"  .-'''-. ",
                @" / _   _ \",
                @" ](_' `_)[",
                @" `-. N ,-'",
                @"   `---'  "
                };

        public List<ConsoleColor> ColorsBack = new List<ConsoleColor> { ConsoleColor.Black };
        public List<ConsoleColor> Colors = new List<ConsoleColor> { ConsoleColor.Gray };

        public List<Dictionary<string, int>> Coordinates = new List<Dictionary<string, int>>();

        public List<Dictionary<string, int>> ObjectSpecialCoordinates { get; set; }
        public string MessageOnSpecial = @"Whoa! You found a SKULL! Do you want to add 
            it to your inventory? (Press <Y> for Yes)"; // Change this one

        public void PrintSkull(int col, int row)
        {
            Console.SetCursorPosition(col, row);
            Console.ForegroundColor = Colors[0];
            Console.BackgroundColor = ColorsBack[0];

            List<Dictionary<string, int>> coorDict = new List<Dictionary<string, int>>();
            for (int top = 0; top < this.Object.Length; top++)
            {
                for (int left = 0; left < this.Object[top].Length; left++)
                {
                    Console.Write(this.Object[top][left]);

                    Dictionary<string, int> coor = new Dictionary<string, int>();
                    coor.Add("col", left + col);
                    coor.Add("row", top + row);
                    coorDict.Add(coor);

                    Console.SetCursorPosition(coor["col"], coor["row"]);
                }
            }

            this.Coordinates = coorDict;
        }
    }
}
