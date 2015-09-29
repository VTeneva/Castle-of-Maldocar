using System;

class Inventory
{
    static void Main()
    {
        // Setting window size
        Console.BufferHeight = Console.WindowHeight = 50;
        Console.BufferWidth = Console.WindowWidth = 100;

        for (int x = 0; x < Console.WindowWidth; x++)
        {
            PrintSymbol(x, 4, '*', ConsoleColor.Gray, ConsoleColor.DarkGray);
            PrintSymbol(x, 48, '*', ConsoleColor.Gray, ConsoleColor.DarkGray);
        }

        for (int y = 4; y < 48; y++)
        {
            PrintSymbol(0, y, '*', ConsoleColor.Gray, ConsoleColor.DarkGray);
            PrintSymbol(61, y, '*', ConsoleColor.Gray, ConsoleColor.DarkGray);
            PrintSymbol(99, y, '*', ConsoleColor.Gray, ConsoleColor.DarkGray);
        }

        for (int x = 61; x < 99; x++)
        {
            PrintSymbol(x, 35, '*', ConsoleColor.Gray, ConsoleColor.DarkGray);
        }

        PrintString(75, 37, "INVENTORY", ConsoleColor.Yellow, ConsoleColor.Black);
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

