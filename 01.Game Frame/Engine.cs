using System;

namespace _01.Game_Frame
{
    class Engine
    {
        public static void Main()
        {
            // Setting window size
            Console.BufferHeight = Console.WindowHeight = 50;
            Console.BufferWidth = Console.WindowWidth = 80;

            //Start Screen
            Console.CursorVisible = false;
            FrontScreen.PrintFrontScreen();

            // Music added
            Music music = new Music();
            music.Play();

            if (Console.ReadKey(true).Key == ConsoleKey.N)
            {
                music.Stop();
            }

            GameFrameBasics.PressEnter();

            Console.Clear();
            music.Stop();

            //Level 1
            LevelOne one = new LevelOne();
            one.PlayLevel();

            //Level 2


            //Level 3


            //Level BeforeLast
            LevelBeforeLast beforeLast = new LevelBeforeLast();
            beforeLast.PlayLevel();
			
			//Level Last
			//LevelLast last = new LevelLast();
            //last.PlayLevel();
        }
    }
}
