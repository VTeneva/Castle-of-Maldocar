using System;
using System.Collections.Generic;

namespace _01.Game_Frame
{
    public class GameFrameBasics
    {
        public static void GameFrame()
        {
            for (int x = 0; x < Console.WindowWidth; x++)
            {
                PrintSymbol(x, 4, '*', ConsoleColor.Gray, ConsoleColor.DarkGray);
                PrintSymbol(x, 48, '*', ConsoleColor.Gray, ConsoleColor.DarkGray);
            }

            for (int y = 4; y < 48; y++)
            {
                PrintSymbol(0, y, '*', ConsoleColor.Gray, ConsoleColor.DarkGray);
                PrintSymbol(53, y, '*', ConsoleColor.Gray, ConsoleColor.DarkGray);
                PrintSymbol(79, y, '*', ConsoleColor.Gray, ConsoleColor.DarkGray);
            }

            for (int x = 53; x < 79; x++)
            {
                PrintSymbol(x, 35, '*', ConsoleColor.Gray, ConsoleColor.DarkGray);
            }

            PrintString(62, 37, "INVENTORY", ConsoleColor.Yellow, ConsoleColor.Black);
        }

        public void MessageBoard(string message, ConsoleColor color)
        {
            PrintString(3, 1, message, color, ConsoleColor.Black);
        }

        public static void PrintSymbol(int x, int y, char symbol, ConsoleColor color, ConsoleColor backColor)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.BackgroundColor = backColor;
            Console.Write(symbol);
        }

        public static void PrintString(int x, int y, string textOrSequnce, ConsoleColor color, ConsoleColor backColor)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.BackgroundColor = backColor;
            Console.WriteLine(textOrSequnce);
        }

        public static void PressEnter()
        {
            ConsoleKeyInfo enterKey;
            enterKey = Console.ReadKey(true);

            while (enterKey.Key != ConsoleKey.Enter)
            {
                enterKey = Console.ReadKey(true);
            }
        }
    }
}

