using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Game_Frame
{
    class DisplayDialog
    {
        public void DisplayDialogInDialogBoard(Dictionary<string, List<string>> dialogLevel)
        {
            // Check the length of list in first key
            for (int line = 0; line < dialogLevel["Player"].Count; line++)
            {
                foreach (var speaker in dialogLevel)
                {
                    Console.WriteLine(speaker.Value[line]);
                }
            }
        }

        public void WriteInDialogBoard(string inputLine)
        {

        }
    }
}
