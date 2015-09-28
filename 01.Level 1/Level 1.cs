using System;

class Program
{
    static void FrontScreen()
    {
        PrintString(20, Console.WindowHeight / 3 - 6, @"  ,----..                            ___     ,--,              ", ConsoleColor.Cyan, ConsoleColor.Black);
        PrintString(20, Console.WindowHeight / 3 - 5, @" /   /   \                         ,--./|_ ,--./|              ", ConsoleColor.Cyan, ConsoleColor.Black);
        PrintString(20, Console.WindowHeight / 3 - 4, @"|   :     :                        |  | :,'|  | :              ", ConsoleColor.Cyan, ConsoleColor.Black);
        PrintString(20, Console.WindowHeight / 3 - 3, @".   |  ;. /              .--.--.   :  : ' ::  : '              ", ConsoleColor.Cyan, ConsoleColor.Black);
        PrintString(20, Console.WindowHeight / 3 - 2, @".   ; /--`   ,--.--.    /  /    '.;__/'  / |  | |      ,---.   ", ConsoleColor.Cyan, ConsoleColor.Black);
        PrintString(20, Console.WindowHeight / 3 - 1, @";   | ;     /       \  |  :  /`./|  |   |  |  | |     /     \  ", ConsoleColor.Cyan, ConsoleColor.Black);
        PrintString(20, Console.WindowHeight / 3, @"|   : |    .--.  .-. | |  :  ;_  :__,'| |  |  | :    /    /  | ", ConsoleColor.Cyan, ConsoleColor.Black);
        PrintString(20, Console.WindowHeight / 3 + 1, @".   | '___  \__\/: . .  \  \ __ `. '  : |__'  : |__ .    '   | ", ConsoleColor.Cyan, ConsoleColor.Black);
        PrintString(20, Console.WindowHeight / 3 + 2, @"'   ; : .'| .--.; |   `  --.   \   | '.' |  | '.' | '   ;   /  ", ConsoleColor.Cyan, ConsoleColor.Black);
        PrintString(20, Console.WindowHeight / 3 + 3, @"'   | '/  :/  /  ,.  |  /  /`--'  /;  |    ;  :    ;'   |__/   ", ConsoleColor.Cyan, ConsoleColor.Black);
        PrintString(20, Console.WindowHeight / 3 + 4, @"|   :    /;  :   .'   \'--'.     / |  .   /|  .   / |   :  __  ", ConsoleColor.Cyan, ConsoleColor.Black);
        PrintString(20, Console.WindowHeight / 3 + 5, @" \   \ .' |  ,     .-./  `--'---'   ---`-'  ---`-'   \   \/ /  ", ConsoleColor.Cyan, ConsoleColor.Black);
        PrintString(20, Console.WindowHeight / 3 + 6, @"  `---`    `--`---'                                   `----'   ", ConsoleColor.Cyan, ConsoleColor.Black);

        PrintString(22, Console.WindowHeight / 3 + 8, @"        __                        _                       ", ConsoleColor.Red, ConsoleColor.Black);
        PrintString(22, Console.WindowHeight / 3 + 9, @"  ___  / _|   /\/\   __ _ _ __ __| | ___   ___ __ _ _ __ ", ConsoleColor.Red, ConsoleColor.Black);
        PrintString(22, Console.WindowHeight / 3 + 10, @" / _ \| |_   /    \ / _` | '__/ _` |/ _ \ / __/ _` | '__|", ConsoleColor.Red, ConsoleColor.Black);
        PrintString(22, Console.WindowHeight / 3 + 11, @"| (_) |  _| / /\/\ \ (_| | | | (_| | (_) | (_| (_| | |   ", ConsoleColor.Red, ConsoleColor.Black);
        PrintString(22, Console.WindowHeight / 3 + 12, @" \___/|_|   \/    \/\__,_|_|  \__,_|\___/ \___\__,_|_|   ", ConsoleColor.Red, ConsoleColor.Black);


        PrintString(35, Console.WindowHeight / 3 + 20, "PRESS ENTER TO START THE GAME!", ConsoleColor.White, ConsoleColor.Black);
    }

    static void GameFrame()
    {
        for (int x = 0; x < Console.WindowWidth; x++)
        {
            PrintSymbol(x, 4, '*', ConsoleColor.Gray, ConsoleColor.DarkGray);
            PrintSymbol(x, 48, '*', ConsoleColor.Gray, ConsoleColor.DarkGray);
        }


        for (int y = 4; y < 48; y++)
        {
            PrintSymbol(60, y, '*', ConsoleColor.Gray, ConsoleColor.DarkGray);
            PrintSymbol(0, y, '*', ConsoleColor.Gray, ConsoleColor.DarkGray);
            PrintSymbol(99, y, '*', ConsoleColor.Gray, ConsoleColor.DarkGray);
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

    static void Main()
    {
        // Setting window size
        Console.BufferHeight = Console.WindowHeight = 50;
        Console.BufferWidth = Console.WindowWidth = 100;

        //Start Screen
        //FrontScreen();
        //Console.SetCursorPosition(66, Console.WindowHeight / 3 + 20);

        ////Clears console after enter pressed - TO BE CHANGED TO ANY KEY PRESSED?
        //ConsoleKeyInfo cki;
        //do
        //{
        //    cki = Console.ReadKey();
        //} while (cki.Key != ConsoleKey.Enter);

        //PrintString(35, Console.WindowHeight / 3 + 25, "Enter your nickname:", ConsoleColor.White, ConsoleColor.Black);
        //Console.SetCursorPosition(56, Console.WindowHeight / 3 + 25);

        //string nickname = Console.ReadLine();

        //Console.Clear();

        //Level 1
        GameFrame();
        Console.SetCursorPosition(66, Console.WindowHeight / 3 + 20);
    }
}

