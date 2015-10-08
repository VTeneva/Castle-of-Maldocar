using System;
using System.Text;
using System.Threading;

namespace _01.Game_Frame
{
    class LevelLast
    {

        public void PlayLevel()
        {
            Console.Clear();
            Console.CursorVisible = false;
            Instructions.PrintInstructions(Instructions.instructionsLast); //Instructions

            GameFrameBasics.GameFrame();

            while (!BossBattle())
            {
                GameOver();
            }
        }

        public bool BossBattle()
        {
            Random rand = new Random();
            WriteBossBattleFrame();
            int dragonLife = 25000;
            int heroLife = 1000;

            GameCharacters.Dragon dragon = new GameCharacters.Dragon(0, 0, false, GC.gameFieldLeft, GC.gameFieldTop, GC.gameFieldRight, GC.gameFieldBottom - 10);
            GameCharacters.Hero hero = new GameCharacters.Hero(GC.gameFieldLength >> 1, GC.gameFieldBottom - GameCharacters.Hero.height + 1, true, GC.gameFieldLeft, GC.gameFieldTop, GC.gameFieldRight, GC.gameFieldBottom);

            while (true)
            {
                Thread.Sleep(150);
                CleanGameField();

                dragon.Move();

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    while (Console.KeyAvailable)
                    {
                        pressedKey = Console.ReadKey(true);
                    }
                    if (pressedKey.Key == ConsoleKey.UpArrow)
                    {
                        hero.Shooting();
                    }
                    else if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        hero.Move(true);
                    }
                    else if (pressedKey.Key == ConsoleKey.LeftArrow)
                    {
                        hero.Move(false);
                    }
                    else
                    {
                        hero.DoNothing();
                        if (pressedKey.Key == ConsoleKey.W) dragonLife = 0; //cheat
                        if (pressedKey.Key == ConsoleKey.L) heroLife = 0; //cheat
                    }
                }
                else
                {
                    hero.DoNothing();
                }

                dragon.MoveFireballs();
                dragon.CreateFireball(rand.Next(1, 4));
                hero.MoveBullets();

                int dragonDamageTaken = 0;
                int heroDamageTaken = 0;
                CheckForDamage(dragon, hero, ref dragonDamageTaken, ref heroDamageTaken, ref rand);
                dragonLife -= dragonDamageTaken;
                heroLife -= heroDamageTaken;
                if (dragonLife < 0)
                {
                    dragonLife = 0;
                }
                if (heroLife < 0)
                {
                    heroLife = 0;
                }
                Console.ResetColor();
                Console.SetCursorPosition(2, 1);
                Console.WriteLine("Dragon Health: {0:00000} ", dragonLife);
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Hero Health: {0:0000} ", heroLife);

                if (heroLife == 0)
                {
                    return false;
                }
                else if (dragonLife == 0)
                {
                    return true;
                }
            }
        }

        public void CheckForDamage(GameCharacters.Dragon dragon, GameCharacters.Hero hero, ref int dragonDamageTaken, ref int heroDamageTaken, ref Random rand)
        {
            for (int i = 0; i < dragon.fireballs.Count; i++)
            {
                if (hero.positionX + 1 <= dragon.fireballs[i].positionX && dragon.fireballs[i].positionX <= hero.positionX + 4)
                {
                    if (hero.positionY + 2 <= dragon.fireballs[i].positionY && dragon.fireballs[i].positionY <= hero.positionY + 4)
                    {
                        dragon.fireballs.RemoveAt(i);
                        heroDamageTaken += rand.Next(1, 200 + 1); //Dragon Damage
                    }
                }
            }
            for (int i = 0; i < hero.bullets.Count; i++)
            {
                if (dragon.currentPositonX - 8 <= hero.bullets[i].positionX && hero.bullets[i].positionX <= dragon.currentPositonX + 8)
                {
                    if (dragon.currentPositonY - 2 <= hero.bullets[i].positionY && hero.bullets[i].positionY <= dragon.currentPositonY + 2)
                    {
                        hero.bullets.RemoveAt(i);
                        dragonDamageTaken += rand.Next(50, 100 + 1); //Hero Damage
                    }
                }
            }
        }

        public void WriteBossBattleFrame()
        {
            Random rand = new Random();
            for (int i = GC.borderTop; i < GC.gameFieldTop; i++)
            {
                for (int j = GC.borderLeft; j <= GC.borderRight; j++)
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
            for (int i = GC.gameFieldBottom + 1; i <= GC.borderBottom; i++)
            {
                for (int j = GC.borderLeft; j <= GC.borderRight; j++)
                {
                    GameFrameBasics.PrintSymbol(j, i, ',', ConsoleColor.Green, ConsoleColor.DarkGreen);
                }
            }
            for (int i = GC.borderLeft; i <= GC.borderRight; i++)
            {
                if (i == GC.gameFieldLeft)
                {
                    i = GC.gameFieldRight + 1;
                }
                for (int j = 0 + rand.Next(GC.borderTop, GC.gameFieldTop + 1); j <= GC.gameFieldBottom + 1; j++)
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
            for (int y = GC.gameFieldTop; y <= GC.gameFieldBottom; y++)
            {
                Console.SetCursorPosition(GC.gameFieldLeft, y);
                Console.WriteLine(new string(' ', GC.gameFieldLength));
            }
        }
        public static void GameOver()
        {
            CleanGameField();
            string text = "GAME OVER";
            int x = GC.gameFieldLeft + (GC.gameFieldLength >> 1) - (text.Length>>1);
            int y = GC.gameFieldTop + (GC.gameFieldHeight >> 2);
            Console.SetCursorPosition(x, y);
            Console.WriteLine(text);
            text = "Press Enter to reply . . .";
            x = GC.gameFieldLeft + (GC.gameFieldLength >> 1) - (text.Length >> 1);
            y = y + 2;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(text);
            ConsoleKeyInfo pressedKey;
            do
            {
                pressedKey = Console.ReadKey(true);
            } while (pressedKey.Key!=ConsoleKey.Enter);
        }
    }
}
