using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01.Game_Frame
{
    public class VictoryScreen
    {
        public static void PrintVictoryScreen()
        {
            Console.SetCursorPosition(0, 0);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;

            using (StreamReader reader = new StreamReader("../../Victory_screen.txt"))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                }
            }

        }
    }
}