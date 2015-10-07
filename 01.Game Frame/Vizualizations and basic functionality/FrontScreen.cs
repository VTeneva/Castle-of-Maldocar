using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01.Game_Frame
{
    public class FrontScreen
    {
        // Front screen - 63 symbols
        public static void PrintFrontScreen()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            using (StreamReader reader = new StreamReader("../../Start_screen.txt"))
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
