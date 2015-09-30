using System;
using System.Collections.Generic;

namespace _01.Game_Frame
{
    public class GameFrameBasics
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

        static void PressEnter()
        {
            ConsoleKeyInfo enterKey;
            enterKey = Console.ReadKey(true);

            while (enterKey.Key != ConsoleKey.Enter)
            {
                enterKey = Console.ReadKey(true);
            }
        }

        public static void Main()
        {
            // Setting window size
            Console.BufferHeight = Console.WindowHeight = 50;
            Console.BufferWidth = Console.WindowWidth = 100;

            //Start Screen
            FrontScreen();

            //Clears console after enter pressed
            PressEnter();

            PrintString(35, Console.WindowHeight / 3 + 19, "Enter your name:", ConsoleColor.White, ConsoleColor.Black);
            Console.SetCursorPosition(52, Console.WindowHeight / 3 + 19);

            string nickname = Console.ReadLine();

            Console.Clear();
            Console.CursorVisible = false;
            //Level 1

            GameFrame();
            MessageBoard("You are a great warrior that is prisoned in the castle of the dragon Mardocar.", ConsoleColor.DarkYellow);

            LevelOne first = new LevelOne();
            first.FirstLevel();

            Dictionary<string, int> currentHeroCoords = new Dictionary<string, int>();  //from Hero class
            ConsoleKeyInfo keyInfo;
            currentHeroCoords.Add("col", 10);  //from Hero/Level class
            currentHeroCoords.Add("row", 10);  //from Hero/Level class

            HeroMovement level1 = new HeroMovement();
            level1.PrintGameFrame();

            level1.PrintHero(currentHeroCoords);

            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Enter)
            {
                PrintSymbol(currentHeroCoords["col"], currentHeroCoords["row"], ' ', ConsoleColor.Black, ConsoleColor.Black);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        level1.UpdateHeroCoords(currentHeroCoords, "up");
                        break;

                    case ConsoleKey.RightArrow:
                        level1.UpdateHeroCoords(currentHeroCoords, "right");
                        break;

                    case ConsoleKey.DownArrow:
                        level1.UpdateHeroCoords(currentHeroCoords, "down");
                        break;

                    case ConsoleKey.LeftArrow:
                        level1.UpdateHeroCoords(currentHeroCoords, "left");
                        break;
                }
                level1.PrintHero(currentHeroCoords);
            }

            PressEnter();
            PrintString(75, 10, "END LEVEL 1.", ConsoleColor.Red, ConsoleColor.Black);
            PressEnter();

            //Level 2
            Console.Clear();
            GameFrame();
            MessageBoard("Good job, " + nickname + "! You managed to escape from the tower. .", ConsoleColor.DarkYellow);

            PressEnter();

            LevelTwo second = new LevelTwo();
            second.SecondLevel();
        }
    }
}

