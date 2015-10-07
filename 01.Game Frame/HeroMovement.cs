using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Game_Frame
{
    class HeroMovement
    {
        public List<Dictionary<string, int>> forbiddenCoords = new List<Dictionary<string, int>>();

        public void PrintHero(Dictionary<string, int> currentHeroCoords, string currentHeroPosition)
        {
            char pos = ' ';
            switch (currentHeroPosition)
            {
                case "up":
                    pos = 'W';
                    break;
                case "down":
                    pos = 'M';
                    break;
                case "left":
                    pos = '3';
                    break;
                case "right":
                    pos = 'E';
                    break;
            }
            GameFrameBasics.PrintSymbol(currentHeroCoords["col"], currentHeroCoords["row"], pos, ConsoleColor.White, ConsoleColor.Black);
        }

        // REFER TO THIS METHOD TO MAKE YOUR PLAYER MOVE
        public void Movement(int startingRow, int startingCol, 
            string currentHeroPosition, 
            List<Dictionary<string, int>> forbiddenCoordsLevel, 
            Dictionary<string, Dictionary<string, int>>  specialCoordsLevel,
            Dictionary<string, Dictionary<string, int>> itemsCoords,
            Dictionary<string, string> messagesSpecial)
        {
            Dictionary<string, int> currentHeroCoords = new Dictionary<string, int>();  
            currentHeroCoords.Add("col", startingRow);  
            currentHeroCoords.Add("row", startingCol);

            PrintGameFrame();
            PrintHero(currentHeroCoords, currentHeroPosition);

            ConsoleKeyInfo keyInfo;

            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Enter)
            {
                GameFrameBasics.PrintSymbol(currentHeroCoords["col"], currentHeroCoords["row"], ' ', ConsoleColor.Black, ConsoleColor.Black);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        currentHeroPosition = "up";
                        UpdateHeroCoords(currentHeroCoords, forbiddenCoordsLevel, "up");
                        break;

                    case ConsoleKey.RightArrow:
                        currentHeroPosition = "right";
                        UpdateHeroCoords(currentHeroCoords, forbiddenCoordsLevel, "right");
                        break;

                    case ConsoleKey.DownArrow:
                        currentHeroPosition = "down";
                        UpdateHeroCoords(currentHeroCoords, forbiddenCoordsLevel, "down");
                        break;

                    case ConsoleKey.LeftArrow:
                        currentHeroPosition = "left";
                        UpdateHeroCoords(currentHeroCoords, forbiddenCoordsLevel, "left");
                        break;
                }

                PrintHero(currentHeroCoords, currentHeroPosition);

                string currCoord = currentHeroCoords["col"] + "," + currentHeroCoords["row"];

                //if (specialCoordsLevel.FirstOrDefault(x => x.Value.Contains(currCoord)).Key != null)
                //{
                //    GameFrameBasics.MessageBoard(messagesSpecial[specialCoordsLevel.FirstOrDefault(x => x.Value.Contains(currCoord)).Key], ConsoleColor.Cyan);

                //    if (Console.ReadKey(true).Key == ConsoleKey.Y)
                //    {
                //        string adjacentObject = null;

                //        GameFrameBasics.ClearMessageBoard();
                //        // Check which is the object that we would take into the inventory.
                //        adjacentObject = specialCoordsLevel.FirstOrDefault(x => x.Value.Contains(currCoord)).Key;
                //        int adjacentObjectStartingX = 0;
                //        int adjacentObjectStartingY = 0;
                //        int adjacentObjectWidth = 0;

                //        // Erase the object from the frame (with EraseItem()).
                //        // Ideally it should be called like this: 
                //        // Inventory.EraseItem(adjacentObject, adjacentObjectStartingX, adjacentObjectStartingY, adjacentObjectWidth);

                //        Inventory.EraseItem(adjacentObject, Inventory.skullStartX, Inventory.skullStartY, Inventory.skullWidth);

                //        // Call AddToInventory() with "objName" = the object we are next to.
                //        Inventory.AddToInventory(adjacentObject);
                //    }
                //    else if (Console.ReadKey(true).Key == ConsoleKey.N)
                //    {
                //        GameFrameBasics.ClearMessageBoard();
                //    }
                    
                //}

                PrintHero(currentHeroCoords, currentHeroPosition);

            }
        }

        public void UpdateHeroCoords(Dictionary<string, int> currentHeroCoords, List<Dictionary<string, int>> forbiddenCoordsLevelBeforeLast, string direction)
        {
            Dictionary<string, int> newHeroCoords = new Dictionary<string, int>();
            bool allowed = true;

            switch (direction)
            {
                case "up":
                    newHeroCoords.Add("row", currentHeroCoords["row"] - 1);
                    newHeroCoords.Add("col", currentHeroCoords["col"]);
                    break;
                case "down":
                    newHeroCoords.Add("row", currentHeroCoords["row"] + 1);
                    newHeroCoords.Add("col", currentHeroCoords["col"]);
                    break;
                case "left":
                    newHeroCoords.Add("row", currentHeroCoords["row"]);
                    newHeroCoords.Add("col", currentHeroCoords["col"] - 1);
                    break;
                case "right":
                    newHeroCoords.Add("row", currentHeroCoords["row"]);
                    newHeroCoords.Add("col", currentHeroCoords["col"] + 1);
                    break;
            }

            foreach (var forbiddenCoord in forbiddenCoords)
            {
                if ((forbiddenCoord["row"] == newHeroCoords["row"]) && (forbiddenCoord["col"] == newHeroCoords["col"]))                                     
                {
                    allowed = false;
                }
            }

            foreach (var forbiddenCoordLevelBeforeLast in forbiddenCoordsLevelBeforeLast)
            {
                if ((forbiddenCoordLevelBeforeLast["row"] == newHeroCoords["row"]) && (forbiddenCoordLevelBeforeLast["col"] == newHeroCoords["col"]))
                {
                    allowed = false;
                }
            }

            if (allowed)
            {
                currentHeroCoords["row"] = newHeroCoords["row"];
                currentHeroCoords["col"] = newHeroCoords["col"];
            }
        }

        public void PrintGameFrame()
        {
            // Frame of hero's movements
            for (int x = 5; x < 49; x++)
            {
                Dictionary<string, int> currentCoord1 = new Dictionary<string, int>();
                currentCoord1.Add("col", x);
                currentCoord1.Add("row", 8);
                forbiddenCoords.Add(currentCoord1);

                Dictionary<string, int> currentCoord2 = new Dictionary<string, int>();
                currentCoord2.Add("col", x);
                currentCoord2.Add("row", 44);
                forbiddenCoords.Add(currentCoord2);
            }

            for (int y = 8; y < 45; y++)
            {
                Dictionary<string, int> currentCoord1 = new Dictionary<string, int>();
                currentCoord1.Add("col", 5);
                currentCoord1.Add("row", y);
                forbiddenCoords.Add(currentCoord1);

                Dictionary<string, int> currentCoord2 = new Dictionary<string, int>();
                currentCoord2.Add("col", 48);
                currentCoord2.Add("row", y);
                forbiddenCoords.Add(currentCoord2);
            }
        }

    }
}
