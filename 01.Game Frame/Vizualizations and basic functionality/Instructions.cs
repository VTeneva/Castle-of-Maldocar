using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Game_Frame
{
    public class Instructions
    {
        public static void PrintInstructions(string[] inst)
        {
            Console.SetCursorPosition(55, 6);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.Write(@"      INSTRUCTIONS       ");

            Console.SetCursorPosition(55, 7);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (int top = 0; top < inst.Length; top++)
            {
                for (int left = 0; left < inst[top].Length; left++)
                {
                    Console.SetCursorPosition(left + 55, top + 7);
                    Console.Write(inst[top][left]);
                }
            }

        }

        public static string[] standartInstructions = new string[] {
            @"     			           ",
            @"          U P		       ",
            @"           ,		       ",
            @"          /_\		       ",
            @"  L       | |        R   ",
            @"  E  ,i__     __i,   I   ",
            @"  F < |__     __| >  G   ",
            @"  T  'i         i'   H   ",
            @"          |_|        T   ",
            @"          \ /		       ",
            @"           '		       ",
            @"        D O W N	       ",
            @"  			           ",
            @"<Y> - CONFIRM ADDING AN  ",
            @"      ITEM IN INVENTORY  ",
            @"<N> - DECLINE	           ",
            @"<G> - USE ITEM IN        ",
            @"      INVENTORY          ",
        };

        public static string[] instructionsLast = new string[] {
            @"     			           ",
            @"  L                  R   ",
            @"  E  ,i__     __i,   I   ",
            @"  F < |__     __| >  G   ",
            @"  T  'i         i'   H   ",
            @"                     T   ",
            @"   			           ",
            @"   ,			           ",
            @"  /_\  USE UP ARROW TO   ",
            @"  | |  SHOOT	           ",
        };

    }
}
