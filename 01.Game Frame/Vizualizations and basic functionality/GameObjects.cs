using System;

namespace _01.Game_Frame
{
    public class GameObject
    {
        // Test object - a sword
        public void DrawGhost(int x, int y)
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(@"    .-.  ");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine(@"   ( "") ");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine(@"   .' '. ");
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine(@"  (     )");
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine(@"   ;   /`");
            Console.SetCursorPosition(x, y + 5);
            Console.WriteLine(@"(__'  /  ");
            Console.SetCursorPosition(x, y + 6);
            Console.WriteLine(@"`.__.'   ");
        }

        public void DrawSword(int x, int y)
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(x, y);
            Console.Write(@"o-|");
            Console.SetCursorPosition(x + 3, y);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(@"====-");
            Console.WriteLine(@"☠");
        }

        public void DrawSkull(int x, int y)
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(x, y);
            Console.Write(@"  .-'''-.");
            Console.SetCursorPosition(x, y + 1);
            Console.Write(@" / _   _ \");
            Console.SetCursorPosition(x, y + 2);
            Console.Write(@" ](_' `_)[");
            Console.SetCursorPosition(x, y + 3);
            Console.Write(@" `-. N ,-' ");
            Console.SetCursorPosition(x, y + 4);
            Console.Write(@"   |   | ");
            Console.SetCursorPosition(x, y + 5);
            Console.Write(@"   `---'");
        }
    }
}