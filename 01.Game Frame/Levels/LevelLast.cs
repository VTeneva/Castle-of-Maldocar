//using System;
//using System.Text;
//using System.Threading;

//namespace _01.Game_Frame
//{
//    class LevelLast
//    {
//        ////sizes
//        //const int frameThickness = 1;
//        //const int gapThickness = 1;
//        //const int borderTopDownThickness = 3;
//        //const int borderSideThickness = 4;
//        //const int gameFieldLength = 42;
//        //const int gameFieldHeight = 35;

//        ////coordinates
//        //const int frameLeft = 0; //x
//        //const int frameTop = 4; //y
//        //const int gapLeft = frameLeft + frameThickness; //x
//        //const int gapTop = frameTop + frameThickness; //y
//        //const int borderLeft = gapLeft + gapThickness; //x
//        //const int borderTop = gapTop + gapThickness; //y
//        //const int gameFieldLeft = borderLeft + borderSideThickness; //x
//        //const int gameFieldTop = borderTop + borderTopDownThickness; //y
//        //const int gameFieldRight = gameFieldLeft + gameFieldLength - 1; //x
//        //const int gameFieldBottom = gameFieldTop + gameFieldHeight - 1; //y
//        //const int borderRight = gameFieldRight + borderSideThickness; //x
//        //const int borderBottom = gameFieldBottom + borderTopDownThickness; //y
//        //const int gapRight = borderRight + gapThickness; //x
//        //const int gapBottom = borderBottom + gapThickness; //y
//        //const int frameRight = gapRight + frameThickness; //x
//        //const int frameBottom = gapBottom + frameThickness; //y


//        public void PlayLevel()
//        {
//            Console.Clear();
//            Console.CursorVisible = false;
//            GameFrameBasics.GameFrame();

//            BossBattle();
//            Console.ReadKey();
//        }

//        public void BossBattle()
//        {
//            Random rand = new Random();
//            WriteBossBattleFrame();

//            GameCharacters.Dragon dragon = new GameCharacters.Dragon(0, 0, false, GC.gameFieldLeft, GC.gameFieldTop, GC.gameFieldRight, GC.gameFieldBottom - 10);
//            GameCharacters.Hero hero = new GameCharacters.Hero(0, 0, false, GC.gameFieldLeft, GC.gameFieldTop, GC.gameFieldRight, GC.gameFieldBottom - 10);

//            while (true)
//            {
//                Thread.Sleep(150);
//                CleanGameField();

//                //dragon.Move();
//                //dragon.MoveFireballs();
//                //dragon.CreateFireball(rand.Next(1,4));

//                //GameCharacters.Hero.PrintHero(0, GC.gameFieldBottom - GameCharacters.Hero.height + 1, 0, false, 0, 0);

//            }
//        }

//        public void WriteBossBattleFrame()
//        {
//            Random rand = new Random();
//            for (int i = GC.borderTop; i < GC.gameFieldTop; i++)
//            {
//                for (int j = GC.borderLeft; j <= GC.borderRight; j++)
//                {
//                    switch (rand.Next(0, 30))
//                    {
//                        case 0:
//                            GameFrameBasics.PrintSymbol(j, i, '#', ConsoleColor.Green, ConsoleColor.DarkGreen); //leaf
//                            break;
//                        case 1:
//                            GameFrameBasics.PrintSymbol(j, i, '@', ConsoleColor.DarkRed, ConsoleColor.DarkGreen); //rose
//                            break;
//                        case 2:
//                        case 3:
//                            GameFrameBasics.PrintSymbol(j, i, ' ', ConsoleColor.Green, ConsoleColor.DarkGreen); //verdancy
//                            break;
//                        case 4:
//                        case 5:
//                            GameFrameBasics.PrintSymbol(j, i, '/', ConsoleColor.Green, ConsoleColor.DarkGreen); //stem
//                            break;
//                        case 6:
//                        case 7:
//                            GameFrameBasics.PrintSymbol(j, i, '\\', ConsoleColor.Green, ConsoleColor.DarkGreen); //stem
//                            break;
//                        case 8:
//                            GameFrameBasics.PrintSymbol(j, i, 'v', ConsoleColor.DarkMagenta, ConsoleColor.DarkGreen); //grapes
//                            break;
//                        default:
//                            GameFrameBasics.PrintSymbol(j, i, '-', ConsoleColor.Green, ConsoleColor.DarkGreen); //stem
//                            break;
//                    }
//                }
//            }
//            for (int i = GC.gameFieldBottom + 1; i <= GC.borderBottom; i++)
//            {
//                for (int j = GC.borderLeft; j <= GC.borderRight; j++)
//                {
//                    GameFrameBasics.PrintSymbol(j, i, ',', ConsoleColor.Green, ConsoleColor.DarkGreen);
//                }
//            }
//            for (int i = GC.borderLeft; i <= GC.borderRight; i++)
//            {
//                if (i == GC.gameFieldLeft)
//                {
//                    i = GC.gameFieldRight + 1;
//                }
//                for (int j = 0 + rand.Next(GC.borderTop, GC.gameFieldTop + 1); j <= GC.gameFieldBottom + 1; j++)
//                {
//                    switch (rand.Next(0, 30))
//                    {
//                        case 0:
//                        case 1:
//                            GameFrameBasics.PrintSymbol(i, j, '#', ConsoleColor.Green, ConsoleColor.DarkGreen); //leaf
//                            break;
//                        case 2:
//                        case 3:
//                            GameFrameBasics.PrintSymbol(i, j, ' ', ConsoleColor.Green, ConsoleColor.DarkGreen); //verdancy
//                            break;
//                        case 4:
//                        case 5:
//                            GameFrameBasics.PrintSymbol(i, j, '/', ConsoleColor.Green, ConsoleColor.DarkGreen); //stem
//                            break;
//                        case 6:
//                        case 7:
//                            GameFrameBasics.PrintSymbol(i, j, '\\', ConsoleColor.Green, ConsoleColor.DarkGreen); //stem
//                            break;
//                        default:
//                            GameFrameBasics.PrintSymbol(i, j, '|', ConsoleColor.Green, ConsoleColor.DarkGreen); //stem
//                            break;
//                    }
//                }
//            }
//        }
//        public static void CleanGameField()
//        {
//            Console.ResetColor();
//            for (int y = GC.gameFieldTop; y <= GC.gameFieldBottom; y++)
//            {
//                Console.SetCursorPosition(GC.gameFieldLeft, y);
//                Console.WriteLine(new string(' ', GC.gameFieldLength));
//            }
//        }
//    }
//}
