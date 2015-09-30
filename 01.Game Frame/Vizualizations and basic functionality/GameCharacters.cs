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
            Console.WriteLine(@"        ,       ");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine(@"      _/;	    ");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine(@"  a^-/@ }~(     ");
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine(@"~~'\-w / ((   <.");
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine(@"      \ \(/__  )");
            Console.SetCursorPosition(x, y + 5);
            Console.WriteLine(@"       \( _(_)' ");
            Console.SetCursorPosition(x, y + 6);
            Console.WriteLine(@"        _> _>	  ");
        }

        public static void Dwarf(int x, int y)
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(@" /\ ");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine(@" Oo ");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine(@"'{}'");

        }
    }
}
