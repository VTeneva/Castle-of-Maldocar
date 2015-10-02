using System;

namespace _01.Game_Frame
{
    class Engine
    {
        public static void Main()
        {
            // Setting window size
            Console.WindowHeight = 50;
            Console.BufferHeight = Console.WindowHeight = 50;
            Console.BufferWidth = Console.WindowWidth = 80;

            //Start Screen
            FrontScreen front = new FrontScreen();
            front.PrintFrontScreen();
            string nickname = Console.ReadLine();

            Console.Clear();
            Console.CursorVisible = false;

            //Level 1


            //Level 2


            //Level 3


            //Level BeforeLast
            LevelBeforeLast beforeLast = new LevelBeforeLast();
            beforeLast.PlayLevel();
        }
    }
}
