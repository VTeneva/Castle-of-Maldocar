using System;

class Program
{
    static void Main()
    {
        // Setting window size
        Console.BufferHeight = Console.WindowHeight = 50;
        Console.BufferWidth = Console.WindowWidth = 100;

        // Frame of hero's movements
        for (int x = 5; x < 56; x++)
        {
            PrintSymbol(x, 8, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
            PrintSymbol(x, 44, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
        }

        for (int y = 8; y < 45; y++)
        {
            PrintSymbol(5, y, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
            PrintSymbol(56, y, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
        }

        Console.SetCursorPosition(1, 3); // Can be removed. 
    }

    static void PrintSymbol(int x, int y, char symbol, ConsoleColor color, ConsoleColor backColor)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.BackgroundColor = backColor;
        Console.Write(symbol);
    }

    static void PrintString(int x, int y, string textOrSequnce, ConsoleColor color, ConsoleColor backColor)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.BackgroundColor = backColor;
        Console.WriteLine(textOrSequnce);
    }
}

