﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Game_Frame
{
    public class LevelOne
    {
        public static int skullCoordsX = 35;
        public static int skullCoordsY = 29;

        public void PlayLevel()
        {                       
            Console.Clear();
            Console.CursorVisible = false;

            Instructions.PrintInstructions(Instructions.standartInstructions); //Instructions
            GameFrameBasics.GameFrame();


            One();
            DisplayDialog.DisplayDialogInDialogBoard(LevelOneDialogs.levelOneDialogOne());


            HeroMovement levelOneHeroMovement = new HeroMovement();
            levelOneHeroMovement.Movement(6, 25, "right", forbiddenCoordsLevelOne, specialCoordsLevelOne,
                objectsCoord, messagesSpecialLevelOne, new List<string> { "skull"});

            GameFrameBasics.MessageBoard("You have advanced to the next level! Press <ENTER> to continue.", ConsoleColor.DarkCyan);

            GameFrameBasics.PressEnter();


        }

        // Forbidden coordinates specific for level One.
        public List<Dictionary<string, int>> forbiddenCoordsLevelOne = new List<Dictionary<string, int>>();

        // "Special" coordinates - a message pops-up when the hero steps over them.
        public static Dictionary<string, List<Dictionary<string, int>>> specialCoordsLevelOne = new Dictionary<string, List<Dictionary<string, int>>>();

        // Messages - special coordinates.
        public static Dictionary<string, string> messagesSpecialLevelOne = new Dictionary<string, string>();

        // Coordinates of objects.
        public static Dictionary<string, List<Dictionary<string, int>>> objectsCoord = new Dictionary<string, List<Dictionary<string, int>>>();

        // Printing the level's objects on the console.
        public void One()
        {

            Skull levelOneSkull = new Skull(35, 29, "skull");

            foreach (var coord in levelOneSkull.Coordinates)
            {
                forbiddenCoordsLevelOne.Add(coord);
            }

            specialCoordsLevelOne.Add(levelOneSkull.Key, levelOneSkull.ObjectSpecialCoordinates);

            messagesSpecialLevelOne.Add(levelOneSkull.Key, levelOneSkull.MessageOnSpecial);

            objectsCoord.Add(levelOneSkull.Key, levelOneSkull.Coordinates);

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



            // Designating the forbidden fields taken up by the skull
            //foreach (string coord in skullCoords)
            //{
            //    List<int> currCoord = new List<int>();
            //    currCoord = coord.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            //    Dictionary<string, int> skullSpace = new Dictionary<string, int>();
            //    skullSpace.Add("col", currCoord[0]);
            //    skullSpace.Add("row", currCoord[1]);
            //    forbiddenCoordsLevelOne.Add(skullSpace);
            //}

            //foreach (string coord in skullBorderCoords)
            //{
            //    List<int> currBorderCoord = new List<int>();
            //    currBorderCoord = coord.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            //    Dictionary<string, int> skullBorderSpace = new Dictionary<string, int>();
            //    skullBorderSpace.Add("col", currBorderCoord[0]);
            //    skullBorderSpace.Add("row", currBorderCoord[1]);

            //    // Add the skull's border fields to special coordinates.
            //    //SpecialCoordinates.SelectSpecialCoordinates("skull", specialCoordsLevelOne, currBorderCoord);
            //}
        }

        public bool LevelOneOver()
        {
            if (Inventory.currentInventory.Contains("skull"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Objects coords data
        // All fields taken up by the skull
        public List<string> skullCoords = new List<string> {

            "35,28",    "36,28",    "37,28",    "38,28",    "39,28",    "40,28",    "41,28",    "42,28",    "43,28",    "44,28",
            "35,29",    "36,29",    "37,29",    "38,29",    "39,29",    "40,29",    "41,29",    "42,29",    "43,29",    "44,29",
            "35,30",    "36,30",    "37,30",    "38,30",    "39,30",    "40,30",    "41,30",    "42,30",    "43,30",    "44,30",
            "35,31",    "36,31",    "37,31",    "38,31",    "39,31",    "40,31",    "41,31",    "42,31",    "43,31",    "44,31",
            "35,32",    "36,32",    "37,32",    "38,32",    "39,32",    "40,32",    "41,32",    "42,32",    "43,32",    "44,32",

        };

        // Fields around the skull, used to trigger 
        public List<string> skullBorderCoords = new List<string> {

            "35,28",    "36,28",    "37,28",    "38,28",    "39,28",    "40,28",    "41,28",    "42,28",    "43,28",    "44,28",
            "35,29",    /*"36,29",    "37,29",    "38,29",    "39,29",    "40,29",    "41,29",    "42,29",    "43,29",*/    "44,29",
            "35,30",    /*"36,30",    "37,30",    "38,30",    "39,30",    "40,30",    "41,30",    "42,30",    "43,30",*/   "44,30",
            "35,31",    /*"36,31",    "37,31",    "38,31",    "39,31",    "40,31",    "41,31",    "42,31",    "43,31",*/    "44,31",
            "35,32",    "36,32",    "37,32",    "38,32",    "39,32",    "40,32",    "41,32",    "42,32",    "43,32",    "44,32",

        };


    }
}