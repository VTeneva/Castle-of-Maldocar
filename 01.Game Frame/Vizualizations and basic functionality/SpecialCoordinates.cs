using System.Collections.Generic;


namespace _01.Game_Frame
{
    public class SpecialCoordinates
    {
        public static List<Dictionary<string, int>> SelectSpecialCoordinates(string key, List<Dictionary<string, int>> itemCoord)
        {
            List<Dictionary<string, int>> specialCoords = new List<Dictionary<string, int>>() ;

            for (int i = 0; i < itemCoord.Count; i++)
            {
                for (int col = -1; col < 2; col++)
                {
                    for (int row = -1; row < 2; row++)
                    {
                        Dictionary<string, int> special = new Dictionary<string, int>();
                        special.Add("col", itemCoord[i]["col"] + col);
                        special.Add("row", itemCoord[i]["row"] + row);
                        specialCoords.Add(special);

                    }
                }
            }

            return specialCoords;
        }
    }
}
