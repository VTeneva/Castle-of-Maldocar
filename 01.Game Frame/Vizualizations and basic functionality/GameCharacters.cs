using System;

namespace _01.Game_Frame
{
    class GameCharacters
    {
        public static void Dragon(int x, int y)
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(@"       ,");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine(@"     /'{    ,//");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine(@"    / `| ,/` /");
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine(@"   |// |/ -- \");
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine(@"  /* / /   /```");
            Console.SetCursorPosition(x, y + 5);
            Console.WriteLine(@"  ""} ) .-,|");
            Console.SetCursorPosition(x, y + 6);
            Console.WriteLine(@"   // ,` _\");
            Console.SetCursorPosition(x, y + 7);
            Console.WriteLine(@"  ,\\   {");
            Console.SetCursorPosition(x, y + 8);
            Console.WriteLine(@" /|/|-'  \");
            Console.SetCursorPosition(x, y + 9);
            Console.WriteLine(@" ````|_\_ `_-_-/");
            Console.SetCursorPosition(x, y + 10);
            Console.WriteLine(@"       |{|{");
            Console.SetCursorPosition(x, y + 11);
            Console.WriteLine(@"       \/\/");
        }

        public static void OldKing(int x, int y)
        {
            Console.ResetColor();
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(@" MMM ");

            Console.SetCursorPosition(x, y + 1);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(@" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(@"o,O");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(@" ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(x, y + 2);
            Console.Write(@"'");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"{(}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(@"'");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine(@" o o ");
        }
    }
}
