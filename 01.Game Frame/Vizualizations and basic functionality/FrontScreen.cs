using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Game_Frame
{
    public class FrontScreen
    {
        // Front screen - 63 symbols
        public void PrintFrontScreen()
        {
            GameFrameBasics.PrintString(9, Console.WindowHeight / 3 - 6, @"  ,----..                            ___     ,--,              ", ConsoleColor.Cyan, ConsoleColor.Black);
            GameFrameBasics.PrintString(9, Console.WindowHeight / 3 - 5, @" /   /   \                         ,--./|_ ,--./|              ", ConsoleColor.Cyan, ConsoleColor.Black);
            GameFrameBasics.PrintString(9, Console.WindowHeight / 3 - 4, @"|   :     :                        |  | :,'|  | :              ", ConsoleColor.Cyan, ConsoleColor.Black);
            GameFrameBasics.PrintString(9, Console.WindowHeight / 3 - 3, @".   |  ;. /              .--.--.   :  : ' ::  : '              ", ConsoleColor.Cyan, ConsoleColor.Black);
            GameFrameBasics.PrintString(9, Console.WindowHeight / 3 - 2, @".   ; /--`   ,--.--.    /  /    '.;__/'  / |  | |      ,---.   ", ConsoleColor.Cyan, ConsoleColor.Black);
            GameFrameBasics.PrintString(9, Console.WindowHeight / 3 - 1, @";   | ;     /       \  |  :  /`./|  |   |  |  | |     /     \  ", ConsoleColor.Cyan, ConsoleColor.Black);
            GameFrameBasics.PrintString(9, Console.WindowHeight / 3, @"|   : |    .--.  .-. | |  :  ;_  :__,'| |  |  | :    /    /  | ", ConsoleColor.Cyan, ConsoleColor.Black);
            GameFrameBasics.PrintString(9, Console.WindowHeight / 3 + 1, @".   | '___  \__\/: . .  \  \ __ `. '  : |__'  : |__ .    '   | ", ConsoleColor.Cyan, ConsoleColor.Black);
            GameFrameBasics.PrintString(9, Console.WindowHeight / 3 + 2, @"'   ; : .'| .--.; |   `  --.   \   | '.' |  | '.' | '   ;   /  ", ConsoleColor.Cyan, ConsoleColor.Black);
            GameFrameBasics.PrintString(9, Console.WindowHeight / 3 + 3, @"'   | '/  :/  /  ,.  |  /  /`--'  /;  |    ;  :    ;'   |__/   ", ConsoleColor.Cyan, ConsoleColor.Black);
            GameFrameBasics.PrintString(9, Console.WindowHeight / 3 + 4, @"|   :    /;  :   .'   \'--'.     / |  .   /|  .   / |   :  __  ", ConsoleColor.Cyan, ConsoleColor.Black);
            GameFrameBasics.PrintString(9, Console.WindowHeight / 3 + 5, @" \   \ .' |  ,     .-./  `--'---'   ---`-'  ---`-'   \   \/ /  ", ConsoleColor.Cyan, ConsoleColor.Black);
            GameFrameBasics.PrintString(9, Console.WindowHeight / 3 + 6, @"  `---`    `--`---'                                   `----'   ", ConsoleColor.Cyan, ConsoleColor.Black);

            GameFrameBasics.PrintString(11, Console.WindowHeight / 3 + 8, @"        __                        _                       ", ConsoleColor.Red, ConsoleColor.Black);
            GameFrameBasics.PrintString(11, Console.WindowHeight / 3 + 9, @"  ___  / _|   /\/\   __ _ _ __ __| | ___   ___ __ _ _ __ ", ConsoleColor.Red, ConsoleColor.Black);
            GameFrameBasics.PrintString(11, Console.WindowHeight / 3 + 10, @" / _ \| |_   /    \ / _` | '__/ _` |/ _ \ / __/ _` | '__|", ConsoleColor.Red, ConsoleColor.Black);
            GameFrameBasics.PrintString(11, Console.WindowHeight / 3 + 11, @"| (_) |  _| / /\/\ \ (_| | | | (_| | (_) | (_| (_| | |   ", ConsoleColor.Red, ConsoleColor.Black);
            GameFrameBasics.PrintString(11, Console.WindowHeight / 3 + 12, @" \___/|_|   \/    \/\__,_|_|  \__,_|\___/ \___\__,_|_|   ", ConsoleColor.Red, ConsoleColor.Black);

            GameFrameBasics.PrintString(25, Console.WindowHeight / 3 + 17, "PRESS ENTER TO START THE GAME!", ConsoleColor.White, ConsoleColor.Black);

            GameFrameBasics.PrintString(0, Console.WindowHeight - 5, @"    _______         _______         _______         _______         _______    ", ConsoleColor.Yellow, ConsoleColor.Black);
            GameFrameBasics.PrintString(0, Console.WindowHeight - 4, @"   |___|___|       |___|___|       |___|___|       |___|___|       |___|___|   ", ConsoleColor.Yellow, ConsoleColor.Black);
            GameFrameBasics.PrintString(0, Console.WindowHeight - 3, @"___|_|___|_|_______|_|___|_|_______|_|___|_|_______|_|___|_|_______|_|___|_|___", ConsoleColor.Yellow, ConsoleColor.Black);
            GameFrameBasics.PrintString(0, Console.WindowHeight - 2, @"___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___", ConsoleColor.Yellow, ConsoleColor.Black);
            GameFrameBasics.PrintString(0, Console.WindowHeight - 1, @"_|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|_", ConsoleColor.Yellow, ConsoleColor.Black);
            Console.SetCursorPosition(55, Console.WindowHeight / 3 + 16);

            //Clears console after enter pressed
            GameFrameBasics.PressEnter();

            GameFrameBasics.PrintString(35, Console.WindowHeight / 3 + 19, "Enter your name:", ConsoleColor.White, ConsoleColor.Black);
            Console.SetCursorPosition(52, Console.WindowHeight / 3 + 19);

        }
    }
}
