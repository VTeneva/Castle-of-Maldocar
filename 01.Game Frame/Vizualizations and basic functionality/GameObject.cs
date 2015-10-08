using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Game_Frame
{
    public class GameObject
    {
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
                @"  .-'''-. ",
                @" / _   _ \",
                @" ](_' `_)[",
                @" `-. N ,-'",
                @"   `---'  "
            });

            // Test object - a sword
            InventoryDB.Add(
                "sword",
                new List<string> {
                    @"o-|====-",
            });
            return InventoryDB;
        }
    
    }
}