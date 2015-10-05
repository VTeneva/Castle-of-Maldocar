﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01.Game_Frame
{
    public class LevelOne
    {
        public void PlayLevel()
        {
            Console.Clear();
            Console.CursorVisible = false;

            GameFrameBasics.GameFrame();
            One();

            Inventory gameInventory = new Inventory();
            gameInventory.DrawItem("sword", 35, 30);

            HeroMovement levelOne = new HeroMovement();
            levelOne.Movement(6, 25, forbiddenCoordsLevelOne);
            
            

        }

        // Forbidden coordinates specific for level Before Last.
        public List<Dictionary<string, int>> forbiddenCoordsLevelOne = new List<Dictionary<string, int>>();

        // Printing the level's objects on the console.
        public void One()
        {
            for (int x = 2; x < 52; x++)
            {
                if ((x / 2) % 2 == 1)
                {
                    GameFrameBasics.PrintSymbol(x, 6, '#', ConsoleColor.Gray, ConsoleColor.DarkGray);
                    GameFrameBasics.PrintSymbol(x, 46, '#', ConsoleColor.Gray, ConsoleColor.DarkGray);
                }
                GameFrameBasics.PrintSymbol(x, 7, '#', ConsoleColor.Gray, ConsoleColor.DarkGray);
                GameFrameBasics.PrintSymbol(x, 45, '#', ConsoleColor.Gray, ConsoleColor.DarkGray);
            }

            for (int x = 4; x < 50; x++)
            {
                GameFrameBasics.PrintSymbol(x, 8, '#', ConsoleColor.Gray, ConsoleColor.DarkGray);
                GameFrameBasics.PrintSymbol(x, 44, '#', ConsoleColor.Gray, ConsoleColor.DarkGray);
            }

            for (int y = 8; y < 45; y++)
            {
                if ((y / 2) % 2 == 1)
                {
                    GameFrameBasics.PrintSymbol(2, y, '#', ConsoleColor.Gray, ConsoleColor.DarkGray);
                    GameFrameBasics.PrintSymbol(3, y, '#', ConsoleColor.Gray, ConsoleColor.DarkGray);
                    GameFrameBasics.PrintSymbol(50, y, '#', ConsoleColor.Gray, ConsoleColor.DarkGray);
                    GameFrameBasics.PrintSymbol(51, y, '#', ConsoleColor.Gray, ConsoleColor.DarkGray);
                }
            }

            for (int y = 9; y < 44; y++)
            {
                GameFrameBasics.PrintSymbol(4, y, '#', ConsoleColor.Gray, ConsoleColor.DarkGray);
                GameFrameBasics.PrintSymbol(5, y, '#', ConsoleColor.Gray, ConsoleColor.DarkGray);
                GameFrameBasics.PrintSymbol(48, y, '#', ConsoleColor.Gray, ConsoleColor.DarkGray);
                GameFrameBasics.PrintSymbol(49, y, '#', ConsoleColor.Gray, ConsoleColor.DarkGray);
            }
        }
    }
}
