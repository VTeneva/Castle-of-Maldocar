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

        public static void Dwarf(int x, int y)
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(@" /\ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine(@" Oo ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine(@"'{}'");

        }
    }
}
