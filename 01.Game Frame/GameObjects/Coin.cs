using _01.Game_Frame;
using System;
using System.Collections.Generic;


namespace _01.Game_Frame
{
    public class Coin
    {
        public Coin(int col, int row, List<string> special)
        {
            this.Coordinates.Add("col", col);
            this.Coordinates.Add("row", row);

            this.PrintCoin();

            //SpecialCoordinates.SelectSpecialCoordinates(Key, this.ObjectSpecialCoordinates, Coordinates);           
        }

        public string Key = "coin";
        public char Symbol = '$';

        public ConsoleColor ColorBack = ConsoleColor.Black;
        public ConsoleColor Color = ConsoleColor.Yellow;

        public Dictionary<string, int> Coordinates; 
        
        public List<Dictionary<string, int>> ObjectSpecialCoordinates { get; set; }
        public string MessageOnSpecial = @"Whoa! You found a coin! Do you want to add 
            it to your inventory? (Press <Y> for Yes)";

        public void PrintCoin()
        {
            Console.SetCursorPosition(Coordinates["col"], Coordinates["row"]);
            Console.ForegroundColor = Color;
            Console.BackgroundColor = ColorBack;
            Console.Write(Symbol);
        }
    }
}
