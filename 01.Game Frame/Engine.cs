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
            //Victory Screen
            VictoryScreen.PrintVictoryScreen();

            // Victory Music
            Music victoryMusic = new Music();
            victoryMusic.Play(Music.VictoryTheme);

            if (Console.ReadKey(true).Key == ConsoleKey.N)
            {
                victoryMusic.Stop(Music.VictoryTheme);
            }

            GameFrameBasics.PressEnter();

            Console.Clear();
            victoryMusic.Stop(Music.VictoryTheme);
            
            /* FrontScreen.PrintFrontScreen();

            // Music added
            Music music = new Music();
            music.Play(Music.MusicTheme);

            if (Console.ReadKey(true).Key == ConsoleKey.N)
            {
                music.Stop(Music.MusicTheme);
            }

            GameFrameBasics.PressEnter();

            Console.Clear();
            music.Stop(Music.MusicTheme);*/

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
            //Victory Screen
            VictoryScreen.PrintVictoryScreen();

            // Victory Music
            //Music victoryMusic = new Music();
            victoryMusic.Play(Music.VictoryTheme);

            if (Console.ReadKey(true).Key == ConsoleKey.N)
            {
                victoryMusic.Stop(Music.VictoryTheme);
            }

            GameFrameBasics.PressEnter();

            Console.Clear();
            victoryMusic.Stop(Music.VictoryTheme);
        }
    }
}
