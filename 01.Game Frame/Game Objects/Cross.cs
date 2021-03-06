﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Game_Frame
{
    class Cross
    {
        public Cross(int col, int row, string nameKey)
        {
            this.Key = nameKey;

            this.PrintCross(col, row);

            this.ObjectSpecialCoordinates = SpecialCoordinates.SelectSpecialCoordinates(Key, Coordinates);
        }

        public string Key { get; set; }

        public string[] Object = new string[] {
                @" # ",
                @"###",
                @" # ",
                @" # ",
                };

        public List<ConsoleColor> ColorsBack = new List<ConsoleColor> { ConsoleColor.Gray, ConsoleColor.Black };
        public List<ConsoleColor> Colors = new List<ConsoleColor> { ConsoleColor.DarkGray };

        public List<Dictionary<string, int>> Coordinates = new List<Dictionary<string, int>>();

        public List<Dictionary<string, int>> ObjectSpecialCoordinates { get; set; }
        public string MessageOnSpecial = @"What a creepy place! I can feel the silence...Oh, God! Why is this grave still open? I might dig somehing....";

        public void PrintCross(int col, int row)
        {
            Console.SetCursorPosition(col, row);

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

                    Console.ForegroundColor = Colors[0];
                    Console.BackgroundColor = ColorsBack[0];

                    if (this.Object[top][left] == ' ')
                    {
                        Console.BackgroundColor = ColorsBack[1];
                    }
                    Console.Write(this.Object[top][left]);
                }
            }
            this.Coordinates = coorDict;
        }
    }
}
