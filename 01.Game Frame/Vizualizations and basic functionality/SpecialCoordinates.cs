using System.Collections.Generic;


namespace _01.Game_Frame
{
    public class SpecialCoordinates
    {
        public static List<Dictionary<string, int>> SelectSpecialCoordinates(string key, List<Dictionary<string, int>> itemCoord)
        {
            List<Dictionary<string, int>> specialCoords = new List<Dictionary<string, int>>() ;

            foreach (var coord in itemCoord)
            {
                for (int col = -1; col < 2; col++)
                {
                    for (int row = -1; row < 2; row++)
                    {
                        Dictionary<string, int> special = new Dictionary<string, int>();
                        special.Add("col", coord["col"] + col);
                        special.Add("row", coord["row"] + col);

                        specialCoords.Add(special);
                    }
                }
            }

            return specialCoords;
        }
    }
}
