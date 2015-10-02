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

            ////Level 1
            //GameFrameBasics.GameFrame();

            //LevelOne first = new LevelOne();
            //first.FirstLevel();

            //Dictionary<string, int> currentHeroCoords = new Dictionary<string, int>();  //from Hero class
            //ConsoleKeyInfo keyInfo;
            //currentHeroCoords.Add("col", 10);  //from Hero/Level class
            //currentHeroCoords.Add("row", 10);  //from Hero/Level class

            //HeroMovement level1 = new HeroMovement();
            //level1.PrintGameFrame();

            //level1.PrintHero(currentHeroCoords);

            //while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Enter)
            //{
            //    GameFrameBasics.PrintSymbol(currentHeroCoords["col"], currentHeroCoords["row"], ' ', ConsoleColor.Black, ConsoleColor.Black);
            //    switch (keyInfo.Key)
            //    {
            //        case ConsoleKey.UpArrow:
            //            level1.UpdateHeroCoords(currentHeroCoords, "up");
            //            break;

            //        case ConsoleKey.RightArrow:
            //            level1.UpdateHeroCoords(currentHeroCoords, "right");
            //            break;

            //        case ConsoleKey.DownArrow:
            //            level1.UpdateHeroCoords(currentHeroCoords, "down");
            //            break;

            //        case ConsoleKey.LeftArrow:
            //            level1.UpdateHeroCoords(currentHeroCoords, "left");
            //            break;
            //    }
            //    level1.PrintHero(currentHeroCoords);
            //}

            //GameFrameBasics.PressEnter();

            ////Level 2
            //Console.Clear();
            //GameFrameBasics.GameFrame();
            //GameFrameBasics.PressEnter();

            //LevelTwo second = new LevelTwo();
            //second.SecondLevel();

            //Level BeforeLast
            LevelBeforeLast beforeLast = new LevelBeforeLast();
            beforeLast.PlayLevel();

        }
    }
}
