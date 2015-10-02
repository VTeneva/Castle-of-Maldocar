using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01.Game_Frame.Levels
{
    public class Treasure
    {
        int x;
        int y;
        string type;
        int rcolor;
        public static string[] typeObjects = new string[] { "^", "@", "*", "&", "+", "%", "$", "#", ".", ";", "-", "question", "key", "facts" };
        public Treasure (int x, int y, string type)
        {
            Random rand = new Random();
            this.x = x;
            this.y = y;
            type = typeObjects[rand.Next(0, 11)];
            rcolor = rand.Next(1, 15);
        }
        public int getX() { return this.x; }
        public int getY() { return this.y; }
        public string getType() { return this.type; }
        public void setY() { this.y++; }
        public void getColor()
        {
            if (rcolor != (int)ConsoleColor.DarkRed)
            {
                Console.ForegroundColor = (ConsoleColor)rcolor;
            }
        }
    }
    public class LevelThree
    {
        public static string[] typeObjects = new string[] { "^", "@", "*", "&", "+", "%", "$", "#", ".", ";", "-","question","key","facts" };
        public static int score = 0;
        public static byte count = 3;
        public static  List<Treasure> trs = new List<Treasure>();
        public static char heart='\x2665';//symbol for lives
        public static Random rand = new Random();//you need this for generating new treasures
    static public void setHearts()//setting left lives
    {
        Console.SetCursorPosition(Console.WindowLeft + 58, 5);
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        for (int i = 0; i < count; i++)
        {
            Console.Write(heart);
        }
        
    }
    public static void generateNewTreasure()
    {

            int x = rand.Next(0, Console.WindowWidth - 1);
            int r=rand.Next(0,11);
            Treasure tres = new Treasure(x, 0,typeObjects[r]);
            trs.Add(tres);
      
   }
    public static void drawTreasure()
    {
        foreach (Treasure t in trs)
        {

            t.getColor();//set colour of each group of rocks

            Console.SetCursorPosition(t.getX(), t.getY());
            Console.WriteLine(t);
                          
            if (t.getY() < Console.WindowHeight - 1) t.setY();
        }

    }
   public static void fallTreasure()//generate and draw rocks
    {
        generateNewTreasure();
        drawTreasure();
    }

        public void PrintHero(Dictionary<string, int> currentHeroCoords)
        {
            GameFrameBasics.PrintSymbol(currentHeroCoords["col"], currentHeroCoords["row"], 'A', ConsoleColor.Blue, ConsoleColor.DarkRed);
        }
        public static void MessageBoard(int x, int y, string message, ConsoleColor color)
        {
            GameFrameBasics.PrintString(x, y, message, color, ConsoleColor.DarkRed);
        }
        public static void DescribeTasks()
        {
            MessageBoard(55, 6, "You have to collect: ", ConsoleColor.Yellow);
            MessageBoard(55, 7, "10 coins: ", ConsoleColor.Yellow);
            MessageBoard(55, 8, "10 weapons: ", ConsoleColor.Yellow);
            MessageBoard(55, 9, "a key: ", ConsoleColor.Yellow);

        }
        public void ThirdLevel()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            GameFrameBasics.GameFrame();
            setHearts();
            Console.SetCursorPosition(Console.WindowHeight - 1, 40);
            for (int x = 2; x < 52; x++)
            {
                GameFrameBasics.PrintSymbol(x, 6, '@', ConsoleColor.Red, ConsoleColor.DarkBlue);
                GameFrameBasics.PrintSymbol(x, 46, '@', ConsoleColor.Red, ConsoleColor.DarkBlue);
            }

            for (int y = 7; y < 46; y++)
            {
                GameFrameBasics.PrintSymbol(2, y, '@', ConsoleColor.Red, ConsoleColor.DarkBlue);
                GameFrameBasics.PrintSymbol(51, y, '@', ConsoleColor.Red, ConsoleColor.DarkBlue);
                
            }
          
            Dictionary<string, int> currentHeroCoords = new Dictionary<string, int>();  //from Hero class
            ConsoleKeyInfo keyInfo;
            currentHeroCoords.Add("col", Console.WindowHeight-1);  //from Hero/Level class
            currentHeroCoords.Add("row", 45);  //from Hero/Level class
           
            HeroMovement level3 = new HeroMovement();
            level3.PrintGameFrame();
            PrintHero(currentHeroCoords);

            //while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Enter)
            //{
                
            //    GameFrameBasics.PrintSymbol(currentHeroCoords["col"], currentHeroCoords["row"], ' ', ConsoleColor.DarkRed, ConsoleColor.DarkRed);
            //    switch (keyInfo.Key)
            //    {
            //        case ConsoleKey.UpArrow:
            //            level3.UpdateHeroCoords(currentHeroCoords, "up");
            //            break;

            //        case ConsoleKey.RightArrow:
            //            level3.UpdateHeroCoords(currentHeroCoords, "right");
            //            break;

            //        case ConsoleKey.DownArrow:
            //            level3.UpdateHeroCoords(currentHeroCoords, "down");
            //            break;

            //        case ConsoleKey.LeftArrow:
            //            level3.UpdateHeroCoords(currentHeroCoords, "left");
            //            break;
            //    }
            //    PrintHero(currentHeroCoords);
            //}
                    
           
            
            
        }


       
        
       

        }

    }
      


