using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Game_Frame
{
    class HeroMovement
    {
        public List<Dictionary<string, int>> forbiddenCoords = new List<Dictionary<string, int>>(); //From Level CLass


        public void PrintHero(Dictionary<string, int> currentHeroCoords)
        {
            GameFrameBasics.PrintSymbol(currentHeroCoords["col"], currentHeroCoords["row"], 'o', ConsoleColor.White, ConsoleColor.Black);
        }

        public void UpdateHeroCoords(Dictionary<string, int> currentHeroCoords, string direction)
        {
            Dictionary<string, int> newHeroCoords = new Dictionary<string, int>();
            bool allowed = true;

            switch (direction)
            {
                case "up":
                    newHeroCoords.Add("row", currentHeroCoords["row"] - 1);
                    newHeroCoords.Add("col", currentHeroCoords["col"]);
                    break;
                case "down":
                    newHeroCoords.Add("row", currentHeroCoords["row"] + 1);
                    newHeroCoords.Add("col", currentHeroCoords["col"]);
                    break;
                case "left":
                    newHeroCoords.Add("row", currentHeroCoords["row"]);
                    newHeroCoords.Add("col", currentHeroCoords["col"] - 1);
                    break;
                case "right":
                    newHeroCoords.Add("row", currentHeroCoords["row"]);
                    newHeroCoords.Add("col", currentHeroCoords["col"] + 1);
                    break;
            }

            foreach (var forbiddenCoord in forbiddenCoords)
            {
                if ((forbiddenCoord["row"] == newHeroCoords["row"]) && (forbiddenCoord["col"] == newHeroCoords["col"]))
                {
                    allowed = false;
                }
            }

            if (allowed)
            {
                currentHeroCoords["row"] = newHeroCoords["row"];
                currentHeroCoords["col"] = newHeroCoords["col"];
            }
        }

        public void PrintGameFrame()
        {
            // Frame of hero's movements
            for (int x = 5; x < 57; x++)
            {
                Dictionary<string, int> currentCoord1 = new Dictionary<string, int>();
                currentCoord1.Add("col", x);
                currentCoord1.Add("row", 8);
                forbiddenCoords.Add(currentCoord1);

                Dictionary<string, int> currentCoord2 = new Dictionary<string, int>();
                currentCoord2.Add("col", x);
                currentCoord2.Add("row", 44);
                forbiddenCoords.Add(currentCoord2);
            }

            for (int y = 8; y < 45; y++)
            {
                Dictionary<string, int> currentCoord1 = new Dictionary<string, int>();
                currentCoord1.Add("col", 5);
                currentCoord1.Add("row", y);
                forbiddenCoords.Add(currentCoord1);

                Dictionary<string, int> currentCoord2 = new Dictionary<string, int>();
                currentCoord2.Add("col", 56);
                currentCoord2.Add("row", y);
                forbiddenCoords.Add(currentCoord2);
            }
        }

    }
}
