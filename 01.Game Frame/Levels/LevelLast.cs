using System;
using System.Text;
using System.Threading;

namespace _01.Game_Frame
{
    class LevelLast
    {
        //sizes
        const int frameThickness = 1;
        const int gapThickness = 1;
        const int borderTopDownThickness = 3;
        const int borderSideThickness = 4;
        const int gameFieldLength = 42;
        const int gameFieldHeight = 34;

        //coordinates
        const int frameLeft = 0; //x
        const int frameTop = 4; //y
        const int gapLeft = frameLeft + frameThickness; //x
        const int gapTop = frameTop + frameThickness; //y
        const int borderLeft = gapLeft + gapThickness; //x
        const int borderTop = gapTop + gapThickness; //y
        const int gameFieldLeft = borderLeft + borderSideThickness; //x
        const int gameFieldTop = borderTop + borderTopDownThickness; //y
        const int gameFieldRight = gameFieldLeft + gameFieldLength - 1; //x
        const int gameFieldBottom = gameFieldTop + gameFieldHeight - 1; //y
        const int borderRight = gameFieldRight + borderSideThickness; //x
        const int borderBottom = gameFieldBottom + borderTopDownThickness; //y
        const int gapRight = borderRight + gapThickness; //x
        const int gapBottom = borderBottom + gapThickness; //y
        const int frameRight = gapRight + frameThickness; //x
        const int frameBottom = gapBottom + frameThickness; //y


        public void PlayLevel()
        {
            Console.Clear();
            Console.CursorVisible = false;
            GameFrameBasics.GameFrame();

            BossBattle();
            Console.ReadKey();
        }

        public void BossBattle()
        {
            Random rand = new Random();
            WriteBossBattleFrame();

            //GameCharacters.Dragon dragon = new GameCharacters.Dragon(0, 0, false, gameFieldLeft, gameFieldTop, gameFieldRight, gameFieldBottom - 10);

            int frame = 0;
            while (true)
            {
                Thread.Sleep(150);
                CleanGameField();

                if (frame == 11) frame = 0;
                //dragon.Move();
                //GameCharacters.Dragon(20, 20, frame++, true, 0, 0);
            }
        }

        public void WriteBossBattleFrame()
        {
            Random rand = new Random();
            for (int i = borderTop; i < gameFieldTop; i++)
            {
                for (int j = borderLeft; j <= borderRight; j++)
                {
                    switch (rand.Next(0, 30))
                    {
                        case 0:
                            GameFrameBasics.PrintSymbol(j, i, '#', ConsoleColor.Green, ConsoleColor.DarkGreen); //leaf
                            break;
                        case 1:
                            GameFrameBasics.PrintSymbol(j, i, '@', ConsoleColor.DarkRed, ConsoleColor.DarkGreen); //rose
                            break;
                        case 2:
                        case 3:
                            GameFrameBasics.PrintSymbol(j, i, ' ', ConsoleColor.Green, ConsoleColor.DarkGreen); //verdancy
                            break;
                        case 4:
                        case 5:
                            GameFrameBasics.PrintSymbol(j, i, '/', ConsoleColor.Green, ConsoleColor.DarkGreen); //stem
                            break;
                        case 6:
                        case 7:
                            GameFrameBasics.PrintSymbol(j, i, '\\', ConsoleColor.Green, ConsoleColor.DarkGreen); //stem
                            break;
                        case 8:
                            GameFrameBasics.PrintSymbol(j, i, 'v', ConsoleColor.DarkMagenta, ConsoleColor.DarkGreen); //grapes
                            break;
                        default:
                            GameFrameBasics.PrintSymbol(j, i, '-', ConsoleColor.Green, ConsoleColor.DarkGreen); //stem
                            break;
                    }
                }
            }
            for (int i = gameFieldBottom + 1; i <= borderBottom; i++)
            {
                for (int j = borderLeft; j <= borderRight; j++)
                {
                    GameFrameBasics.PrintSymbol(j, i, ',', ConsoleColor.Green, ConsoleColor.DarkGreen);
                }
            }
            for (int i = borderLeft; i <= borderRight; i++)
            {
                if (i == gameFieldLeft)
                {
                    i = gameFieldRight;
                }
                for (int j = 0 + rand.Next(borderTop, gameFieldTop + 1); j <= gameFieldBottom + 1; j++)
                {
                    switch (rand.Next(0, 30))
                    {
                        case 0:
                        case 1:
                            GameFrameBasics.PrintSymbol(i, j, '#', ConsoleColor.Green, ConsoleColor.DarkGreen); //leaf
                            break;
                        case 2:
                        case 3:
                            GameFrameBasics.PrintSymbol(i, j, ' ', ConsoleColor.Green, ConsoleColor.DarkGreen); //verdancy
                            break;
                        case 4:
                        case 5:
                            GameFrameBasics.PrintSymbol(i, j, '/', ConsoleColor.Green, ConsoleColor.DarkGreen); //stem
                            break;
                        case 6:
                        case 7:
                            GameFrameBasics.PrintSymbol(i, j, '\\', ConsoleColor.Green, ConsoleColor.DarkGreen); //stem
                            break;
                        default:
                            GameFrameBasics.PrintSymbol(i, j, '|', ConsoleColor.Green, ConsoleColor.DarkGreen); //stem
                            break;
                    }
                }
            }
        }
        public static void CleanGameField()
        {
            Console.ResetColor();
            for (int y = gameFieldTop; y <= gameFieldTop + gameFieldHeight; y++)
            {
                Console.SetCursorPosition(gameFieldLeft, y);
                Console.WriteLine(new string(' ', gameFieldLength));
            }
        }
    }
}
