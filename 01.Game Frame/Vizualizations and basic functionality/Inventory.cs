using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Game_Frame
{
   
    public class Inventory
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


        public void DrawItem(string itemToBeDrawn, int x, int y)
        {
            if (InventoryDB.key == itemToBeDrawn)
            {
                Console.SetCursorPosition(x, y);
                for (int i = 0; i < InventoryDB.itemToBeDrawn; i++)
                {
                    Console.WriteLine(InventoryDB.itemToBeDrawn);
                }
            }
        }

        public string AddToInventory(string objName)
        {
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
                GameFrameBasics.MessageBoard(messageToPrintOut, ConsoleColor.Red); //Error with MessageBoard(); not being visible from Inventory.cs
                return "not added";
            }
            else
            {
                messageToPrintOut = objName + " has been added to the inventory.";
                GameFrameBasics.MessageBoard(messageToPrintOut, ConsoleColor.White);
                return "added";
                DrawItem(objName, drawAtX, drawAtY);
            }
        }

    }


}
