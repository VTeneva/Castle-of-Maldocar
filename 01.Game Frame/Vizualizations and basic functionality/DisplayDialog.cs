using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _01.Game_Frame
{
    class DisplayDialog
    {
        public static void DisplayDialogInDialogBoard(Dictionary<string, List<string>> dialogLevel)
        {
            // Check the length of list in first key
            for (int line = 0; line < dialogLevel["Player"].Count; line++)
            {
                foreach (var speaker in dialogLevel)
                {
                    ConsoleColor color;

                    if (speaker.Key == "Player")
                    {
                        color = Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else { color = Console.ForegroundColor = ConsoleColor.DarkCyan; }

                    GameFrameBasics.MessageBoard(String.Format("{0}: {1}", speaker.Key, speaker.Value[line]), color);

                    Thread.Sleep(1000);

                    GameFrameBasics.ClearMessageBoard();
                }
            }
        }
    }
}
