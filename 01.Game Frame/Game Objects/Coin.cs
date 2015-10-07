using System;
using System.Collections.Generic;


namespace _01.Game_Frame
{
    public class Coin
    {
        public Coin(int col, int row, string nameKey)
        {
            this.Key = nameKey;

            List<Dictionary<string, int>> coor = new List<Dictionary<string, int>>();
            Dictionary<string, int> coord = new Dictionary<string, int>();
            coord.Add("col", col);
            coord.Add("row", row);
            coor.Add(coord);

            this.Coordinates = coor;

            this.PrintCoin();

            this.ObjectSpecialCoordinates = SpecialCoordinates.SelectSpecialCoordinates(Key, Coordinates);           
        }

        public string Key { get; set; }
        public char Symbol = '$';

        public ConsoleColor ColorBack = ConsoleColor.Black;
        public ConsoleColor Color = ConsoleColor.Yellow;

        public List<Dictionary<string, int>> Coordinates = new List<Dictionary<string, int>>();

        public List<Dictionary<string, int>> ObjectSpecialCoordinates { get; set; }
        public string MessageOnSpecial = @"Whoa! You found a coin! Do you want to add 
            it to your inventory? (Press <Y> for Yes)";

        public void PrintCoin()
        {
            Console.SetCursorPosition(Coordinates[0]["col"], Coordinates[0]["row"]);
            Console.ForegroundColor = Color;
            Console.BackgroundColor = ColorBack;
            Console.Write(Symbol);
        }
    }
}
