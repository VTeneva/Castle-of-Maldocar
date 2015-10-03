using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Game_Frame
{
    public class SpecialCoordinates
    {
        public static void SelectSpecialCoordinates(string key, Dictionary<string, List<string>> specialCoordsLevel, List<int> itemCoord)
        {
            try
            {
                specialCoordsLevel.Add(key, new List<string>());
            }
            catch (Exception)
            {
                goto SelectCoord;
            }

            SelectCoord:
            for (int col = -1; col < 2; col++)
            {
                for (int row = -1; row < 2; row++)
                {
                    specialCoordsLevel[key].Add((itemCoord[0] + col) + "," + (itemCoord[1] + row));
                }
            }
        }
    }
}
