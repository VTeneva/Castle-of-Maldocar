using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Game_Frame
{
    class DisplayDialog
    {
        public void DisplayDialogInDialogBoard()
        {
            foreach (var speaker in LevelOneDialogs.levelOneDialogOne())
            {
                for (int line = 0; line < LevelOneDialogs[speaker]; line++)
                {

                }
            }
        }
    }
}
