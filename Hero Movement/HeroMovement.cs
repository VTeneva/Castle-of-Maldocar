using System;
using System.Collections.Generic;

class Program
{
    static List<Dictionary<string, int>> forbiddenCoords = new List<Dictionary<string, int>>(); //From Level CLass
    static Dictionary<string, int> currentHeroCoords = new Dictionary<string, int>();  //from Hero class

    static void Main()
    {
        Console.SetWindowSize(70, 50);
        Console.CursorVisible = false;
        ConsoleKeyInfo keyInfo;
        currentHeroCoords.Add("col", 10);  //from Hero/Level class
        currentHeroCoords.Add("row", 10);  //from Hero/Level class

        PrintString(0, 0, "Press ESC to EXIT.", ConsoleColor.White, ConsoleColor.Gray);

        PrintEnv();
        PrintHero(currentHeroCoords);

        while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
        {
            PrintSymbol(currentHeroCoords["col"], currentHeroCoords["row"], ' ', ConsoleColor.Black, ConsoleColor.Black);
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    UpdateHeroCoords(currentHeroCoords, "up");
                    break;

                case ConsoleKey.RightArrow:
                    UpdateHeroCoords(currentHeroCoords, "right");
                    break;

                case ConsoleKey.DownArrow:
                    UpdateHeroCoords(currentHeroCoords, "down");
                    break;

                case ConsoleKey.LeftArrow:
                    UpdateHeroCoords(currentHeroCoords, "left");
                    break;
            }
            PrintHero(currentHeroCoords);
        }

    }

    private static void PrintHero(Dictionary<string, int> currentHeroCoords)
    {
        PrintSymbol(currentHeroCoords["col"], currentHeroCoords["row"], 'o', ConsoleColor.White, ConsoleColor.Black);
    }

    private static void UpdateHeroCoords(Dictionary<string, int> currentHeroCoords, string direction)
    {
        Dictionary<string, int> newHeroCoords = new Dictionary<string, int>();
        bool allowed = true;

        switch (direction)
        {
            case "up":
                newHeroCoords.Add("row", currentHeroCoords["row"] - 1);
                newHeroCoords.Add("col", currentHeroCoords["col"]);
                break;
            case "down":
                newHeroCoords.Add("row", currentHeroCoords["row"] + 1);
                newHeroCoords.Add("col", currentHeroCoords["col"]);
                break;
            case "left":
                newHeroCoords.Add("row", currentHeroCoords["row"]);
                newHeroCoords.Add("col", currentHeroCoords["col"] - 1);
                break;
            case "right":
                newHeroCoords.Add("row", currentHeroCoords["row"]);
                newHeroCoords.Add("col", currentHeroCoords["col"] + 1);
                break;
        }

        foreach (var forbiddenCoord in forbiddenCoords)
        {
            if ((forbiddenCoord["row"] == newHeroCoords["row"]) && (forbiddenCoord["col"] == newHeroCoords["col"]))
            {
                allowed = false;
            }
        }

        if (allowed)
        {
            currentHeroCoords["row"] = newHeroCoords["row"];
            currentHeroCoords["col"] = newHeroCoords["col"];
        }
    }

    static void PrintEnv()
    {
        // Frame of hero's movements
        for (int x = 1; x < 51; x++)
        {
            PrintSymbol(x, 2, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
            PrintSymbol(x, 40, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);

            Dictionary<string, int> currentCoord1 = new Dictionary<string, int>();
            currentCoord1.Add("col", x);
            currentCoord1.Add("row", 2);
            forbiddenCoords.Add(currentCoord1);

            Dictionary<string, int> currentCoord2 = new Dictionary<string, int>();
            currentCoord2.Add("col", x);
            currentCoord2.Add("row", 40);
            forbiddenCoords.Add(currentCoord2);
        }

        for (int y = 3; y < 40; y++)
        {
            PrintSymbol(1, y, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
            PrintSymbol(50, y, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);

            Dictionary<string, int> currentCoord1 = new Dictionary<string, int>();
            currentCoord1.Add("col", 1);
            currentCoord1.Add("row", y);
            forbiddenCoords.Add(currentCoord1);

            Dictionary<string, int> currentCoord2 = new Dictionary<string, int>();
            currentCoord2.Add("col", 50);
            currentCoord2.Add("row", y);
            forbiddenCoords.Add(currentCoord2);
        }
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

