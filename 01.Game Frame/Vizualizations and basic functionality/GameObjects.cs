using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Game_Frame
{
    public class GameObject
    {

        //public void DrawGhost(int x, int y)
        //{
        //    Console.ResetColor();
        //    Console.ForegroundColor = ConsoleColor.Gray;
        //    Console.BackgroundColor = ConsoleColor.Black;
        //    Console.SetCursorPosition(x, y);
        //    Console.WriteLine(@"    .-.  ");
        //    Console.SetCursorPosition(x, y + 1);
        //    Console.WriteLine(@"   ( "") ");
        //    Console.SetCursorPosition(x, y + 2);
        //    Console.WriteLine(@"   .' '. ");
        //    Console.SetCursorPosition(x, y + 3);
        //    Console.WriteLine(@"  (     )");
        //    Console.SetCursorPosition(x, y + 4);
        //    Console.WriteLine(@"   ;   /`");
        //    Console.SetCursorPosition(x, y + 5);
        //    Console.WriteLine(@"(__'  /  ");
        //    Console.SetCursorPosition(x, y + 6);
        //    Console.WriteLine(@"`.__.'   ");
        //}

        // The Database with all possible inventory objects
        public static Dictionary<string, List<string>> InventoryDB()
        {
            Dictionary<string, List<string>> InventoryDB = new Dictionary<string, List<string>>();

            // Test object - a sword
            InventoryDB.Add(
                "sword",
                new List<string> {
                    @"o-|====-",
            });


            InventoryDB.Add(
                "skull",
                new List<string> {
                @"  .-'''-.",
                @" / _   _ \",
                @" ](_' `_)[",
                @" `-. N ,-' ",
                @"   `---'"
            });

            InventoryDB.Add(
               "ghost",
               new List<string> {
                @"    .-.  ",
                @"   ( "") ",
                @"   .' '. ",
                @"  (     )",
                @"   ;   /`",
                @"(__'  /  ",
                @"`.__.'   "
            });

            return InventoryDB;
        }
    
    }
}