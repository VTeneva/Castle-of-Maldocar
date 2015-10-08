﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Game_Frame
{

    public class Inventory
    {
        public static List<string> currentInventory = new List<string>();

        public static void DrawItem(string itemToBeDrawn, int x, int y)
        {
            if (GameObject.InventoryDB().ContainsKey(itemToBeDrawn))
            {
                Console.SetCursorPosition(x, y - 1); // -1 To avoid printing the second line on top of the first line in the second loop iteration
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < GameObject.InventoryDB()[itemToBeDrawn].Count; i++)
                {
                    Console.Write(GameObject.InventoryDB()[itemToBeDrawn][i]);
                    Console.WriteLine();
                    Console.SetCursorPosition(x, y + i);
                }
            }
        }

        public static void EraseItem(List<Dictionary<string, int>> itemsCoords)
        {
            for (int coord = 0; coord < itemsCoords.Count; coord++)
            {
                foreach (var rowCol in itemsCoords[coord])
                {
                    Console.SetCursorPosition(itemsCoords[coord]["col"], itemsCoords[coord]["row"]);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(" ");
                }
            }         
        }

        public static string AddToInventory(string objName)
        {
            // The inventory is an array <string> with the game adding stuff to the inventory at certain times.
            string[] inventory = new string[8];
            int drawAtX = 0;
            int drawAtY = 0;

            int[,] inventoryStartPosition = 
            {
                /* x */ {54, 60, 67, 74 },
                /* y */ {43, 48, 0, 0}
                                
            };

            bool inventoryFull = true;
            string messageToPrintOut = "Can't take item. Inventory full.";

            for (int i = 0; i < 8; i++)
            {
                if (inventory[i] == null)
                {
                    inventoryFull = false;
                    inventory[i] = objName;
                    switch (i)
                    {
                        case 0:
                            drawAtX = inventoryStartPosition[0, 0];
                            drawAtY = inventoryStartPosition[1, 0];
                            break;
                        case 1:
                            drawAtX = inventoryStartPosition[0, 1];
                            drawAtY = inventoryStartPosition[1, 0];
                            break;
                        case 2:
                            drawAtX = inventoryStartPosition[0, 2];
                            drawAtY = inventoryStartPosition[1, 0];
                            break;
                        case 3:
                            drawAtX = inventoryStartPosition[0, 3];
                            drawAtY = inventoryStartPosition[1, 0];
                            break;
                        case 4:
                            drawAtX = inventoryStartPosition[0, 0];
                            drawAtY = inventoryStartPosition[0, 1];
                            break;
                        case 5:
                            drawAtX = inventoryStartPosition[0, 1];
                            drawAtY = inventoryStartPosition[0, 1];
                            break;
                        case 6:
                            drawAtX = inventoryStartPosition[0, 2];
                            drawAtY = inventoryStartPosition[0, 1];
                            break;
                        case 7:
                            drawAtX = inventoryStartPosition[0, 3];
                            drawAtY = inventoryStartPosition[0, 1];
                            break;
                    }
                    break;
                }

            }

            if (inventoryFull == true)
            {
                GameFrameBasics.MessageBoard(messageToPrintOut, ConsoleColor.Red); 
                return "not added";
            }
            else
            {
                messageToPrintOut = objName + " has been added to the inventory.";
                GameFrameBasics.MessageBoard(messageToPrintOut, ConsoleColor.White);
                DrawItem(objName, drawAtX, drawAtY);
               // EraseItem(objName, )
                return "added";
            }
        }

    }

}
