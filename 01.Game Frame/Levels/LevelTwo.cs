using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Game_Frame
{
    public class LevelTwo
    {
        public void SecondLevel()
        {
            for (int x = 2; x < 60; x++)
            {
                GameFrameBasics.PrintSymbol(x, 6, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
                GameFrameBasics.PrintSymbol(x, 7, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
                GameFrameBasics.PrintSymbol(x, 8, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
                GameFrameBasics.PrintSymbol(x, 44, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
                GameFrameBasics.PrintSymbol(x, 45, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
                GameFrameBasics.PrintSymbol(x, 46, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
            }

            for (int y = 8; y < 45; y++)
            {
                GameFrameBasics.PrintSymbol(2, y, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
                GameFrameBasics.PrintSymbol(3, y, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
                GameFrameBasics.PrintSymbol(4, y, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
                GameFrameBasics.PrintSymbol(5, y, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
                GameFrameBasics.PrintSymbol(56, y, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
                GameFrameBasics.PrintSymbol(57, y, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
                GameFrameBasics.PrintSymbol(58, y, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
                GameFrameBasics.PrintSymbol(59, y, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
            }
        }
    }
}
