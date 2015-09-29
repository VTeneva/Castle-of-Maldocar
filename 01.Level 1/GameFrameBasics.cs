using System;

class GameFrameBasics
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

        PrintString(35, Console.WindowHeight / 3 + 17, "PRESS ENTER TO START THE GAME!", ConsoleColor.White, ConsoleColor.Black);

        PrintString(0, Console.WindowHeight - 5, @"      _______         _______         _______         _______         _______         _______      ", ConsoleColor.Yellow, ConsoleColor.Black);
        PrintString(0, Console.WindowHeight - 4, @"     |___|___|       |___|___|       |___|___|       |___|___|       |___|___|       |___|___|     ", ConsoleColor.Yellow, ConsoleColor.Black);
        PrintString(0, Console.WindowHeight - 3, @"_____|_|___|_|_______|_|___|_|_______|_|___|_|_______|_|___|_|_______|_|___|_|_______|_|___|_|_____", ConsoleColor.Yellow, ConsoleColor.Black);
        PrintString(0, Console.WindowHeight - 2, @"_|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|_", ConsoleColor.Yellow, ConsoleColor.Black);
        PrintString(0, Console.WindowHeight - 1, @"___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___", ConsoleColor.Yellow, ConsoleColor.Black);
        Console.SetCursorPosition(66, Console.WindowHeight / 3 + 16);
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

    static void MessageBoard(string message, ConsoleColor color)
    {
        PrintString(3, 1, message, color, ConsoleColor.Black);
    }

    static void FirstLevel()
    {
        for (int x = 2; x < 60; x++)
        {
            if ((x / 2) % 2 == 1)
            {
                PrintSymbol(x, 6, '#', ConsoleColor.Gray, ConsoleColor.DarkGray);
                PrintSymbol(x, 46, '#', ConsoleColor.Gray, ConsoleColor.DarkGray);
            }
            PrintSymbol(x, 7, '#', ConsoleColor.Gray, ConsoleColor.DarkGray);
            PrintSymbol(x, 45, '#', ConsoleColor.Gray, ConsoleColor.DarkGray);
        }

        for (int x = 4; x < 58; x++)
        {
            PrintSymbol(x, 8, '#', ConsoleColor.Gray, ConsoleColor.DarkGray);
            PrintSymbol(x, 44, '#', ConsoleColor.Gray, ConsoleColor.DarkGray);
        }

        for (int y = 8; y < 45; y++)
        {
            if ((y / 2) % 2 == 1)
            {
                PrintSymbol(2, y, '#', ConsoleColor.Gray, ConsoleColor.DarkGray);
                PrintSymbol(3, y, '#', ConsoleColor.Gray, ConsoleColor.DarkGray);
                PrintSymbol(58, y, '#', ConsoleColor.Gray, ConsoleColor.DarkGray);
                PrintSymbol(59, y, '#', ConsoleColor.Gray, ConsoleColor.DarkGray);
            }
        }

        for (int y = 9; y < 44; y++)
        {
            PrintSymbol(4, y, '#', ConsoleColor.Gray, ConsoleColor.DarkGray);
            PrintSymbol(5, y, '#', ConsoleColor.Gray, ConsoleColor.DarkGray);
            PrintSymbol(56, y, '#', ConsoleColor.Gray, ConsoleColor.DarkGray);
            PrintSymbol(57, y, '#', ConsoleColor.Gray, ConsoleColor.DarkGray);
        }
    }

    static void SecondLevel()
    {
        for (int x = 2; x < 60; x++)
        {
            PrintSymbol(x, 6, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
            PrintSymbol(x, 7, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
            PrintSymbol(x, 8, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
            PrintSymbol(x, 44, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
            PrintSymbol(x, 45, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
            PrintSymbol(x, 46, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
        }

        for (int y = 8; y < 45; y++)
        {
            PrintSymbol(2, y, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
            PrintSymbol(3, y, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
            PrintSymbol(4, y, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
            PrintSymbol(5, y, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
            PrintSymbol(56, y, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
            PrintSymbol(57, y, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
            PrintSymbol(58, y, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
            PrintSymbol(59, y, 'I', ConsoleColor.Green, ConsoleColor.DarkGreen);
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

    static void PressEnter()
    {
        ConsoleKeyInfo cki;
        cki = Console.ReadKey();

        while (cki.Key != ConsoleKey.Enter)
        {
            cki = Console.ReadKey();
        } 
    }


    static void Main()
    {
        // Setting window size
        Console.BufferHeight = Console.WindowHeight = 50;
        Console.BufferWidth = Console.WindowWidth = 100;

        //Start Screen
        FrontScreen();

        //Clears console after enter pressed - TO BE CHANGED TO ANY KEY PRESSED?
        PressEnter();

        PrintString(35, Console.WindowHeight / 3 + 19, "Enter your name:", ConsoleColor.White, ConsoleColor.Black);
        Console.SetCursorPosition(52, Console.WindowHeight / 3 + 19);

        string nickname = Console.ReadLine();

        Console.Clear();

        //Level 1
        GameFrame();
        MessageBoard("You are a great warrior that is prisoned in the castle of the dragon Mardocar.", ConsoleColor.DarkYellow);

        Console.SetCursorPosition(3, 2);
        PressEnter();

        FirstLevel();
        Console.SetCursorPosition(3, 2);

        PressEnter();
        PrintString(75, 10, "END LEVEL 1.", ConsoleColor.Red, ConsoleColor.Black);
        PressEnter();

        //Level 2
        Console.Clear();
        GameFrame();
        MessageBoard("Good job, " + nickname + "! You managed to escape from the tower. .", ConsoleColor.DarkYellow);

        Console.SetCursorPosition(3, 2);
        PressEnter();

        SecondLevel();
        Console.SetCursorPosition(3, 2);
    }
}

