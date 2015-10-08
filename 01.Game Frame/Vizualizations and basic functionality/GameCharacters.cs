using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Game_Frame
{
    class GameCharacters
    {
        public class Dragon
        {
            Random rand;
            public const int length = 19;
            public const int height = 13;
            public const int mouthFromCenterX = 7;
            public const int mouthFromCenterY = 1;
            public const int halfLength = length >> 1;
            public const int halfHeight = height >> 1;
            public int currentPositonX { get; set; }
            public int currentPositonY { get; set; }
            public int nextPositonX { get; set; }
            public int nextPositonY { get; set; }
            public bool isRightHeaded { get; set; }
            public int minPositonX { get; set; }
            public int minPositonY { get; set; }
            public int maxPositonX { get; set; }
            public int maxPositonY { get; set; }
            public int frame { get; set; }
            public List<Fireball> fireballs { get; set; }

            public Dragon(int x, int y, bool isRightHeaded, int left, int top, int right, int bottom)
            {
                rand = new Random();
                minPositonX = left;
                minPositonY = top + (height >> 1);
                maxPositonX = right;
                maxPositonY = bottom - (height >> 1);
                currentPositonX = (minPositonX <= x && x <= maxPositonX) ? x : rand.Next(minPositonX, maxPositonX + 1);
                currentPositonY = (minPositonY <= y && y <= maxPositonY) ? y : rand.Next(minPositonY, maxPositonY + 1);
                nextPositonX = rand.Next(minPositonX, maxPositonX + 1);
                nextPositonY = rand.Next(minPositonY, maxPositonY + 1);
                frame = 0;
                fireballs = new List<Fireball>();
            }

            public void Move()
            {
                if (currentPositonX == nextPositonX && currentPositonY == nextPositonY)
                {
                    nextPositonX = rand.Next(minPositonX, maxPositonX + 1);
                    nextPositonY = rand.Next(minPositonY, maxPositonY + 1);
                }
                if (currentPositonX != nextPositonX)
                {
                    if (currentPositonX < nextPositonX)
                    {
                        if (isRightHeaded)
                        {
                            currentPositonX++;
                        }
                        else
                        {
                            isRightHeaded = true;
                        }
                    }
                    else
                    {
                        if (!isRightHeaded)
                        {
                            currentPositonX--;
                        }
                        else
                        {
                            isRightHeaded = false;
                        }
                    }
                }
                if (currentPositonY != nextPositonY)
                {
                    currentPositonY = currentPositonY < nextPositonY ? currentPositonY + 1 : currentPositonY - 1;
                }

                Console.SetCursorPosition(1, 1);
                Console.WriteLine(" ");
                if (currentPositonX < minPositonX + halfLength)
                {
                    PrintDragon(minPositonX, currentPositonY - halfHeight, frame, isRightHeaded, minPositonX + halfLength - currentPositonX, 0);
                }
                else if (currentPositonX > maxPositonX - halfLength)
                {
                    PrintDragon(currentPositonX - halfLength, currentPositonY - halfHeight, frame, isRightHeaded, 0, currentPositonX + halfLength - maxPositonX);
                }
                else
                {
                    PrintDragon(currentPositonX - halfLength, currentPositonY - halfHeight, frame, isRightHeaded);
                }
                //Console.SetCursorPosition(currentPositonX, currentPositonY); //for debug
                //Console.WriteLine("X"); //for debug

                frame = (frame == 10) ? 0 : (frame + 1);
            }

            public class Fireball
            {
                public int positionX;
                public int positionY;
                public bool isRightHeaded;
                public int firePower;

                public Fireball(int positionX, int positionY, bool isRightHeaded, int firePower)
                {
                    this.positionX = positionX;
                    this.positionY = positionY;
                    this.isRightHeaded = isRightHeaded;
                    this.firePower = firePower;
                }

                public bool Move()
                {
                    int posX = positionX;
                    int posY = positionY;
                    bool isMoveToRight = isRightHeaded;
                    int moveSpeed = firePower;
                    bool canMoveFurther = Move(ref posX, ref posY, ref isMoveToRight, moveSpeed);
                    positionX = posX;
                    positionY = posY;
                    isRightHeaded = isMoveToRight;
                    return canMoveFurther;
                }

                public static bool Move(ref int positionX, ref int positionY, ref bool isRightHeaded, int moveSpeed)
                {
                    if (positionY < GC.gameFieldBottom)
                    {
                        positionY++;
                        if (isRightHeaded)
                        {
                            if (positionX < GC.gameFieldRight - moveSpeed)
                            {
                                positionX += moveSpeed;
                            }
                            else
                            {
                                positionX = GC.gameFieldRight;
                                isRightHeaded = false;
                            }
                        }
                        else
                        {
                            if (GC.gameFieldLeft + moveSpeed < positionX)
                            {
                                positionX -= moveSpeed;
                            }
                            else
                            {
                                positionX = GC.gameFieldLeft;
                                isRightHeaded = true;
                            }
                        }
                        Print(positionX, positionY);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                public static void Print(int positionX, int positionY)
                {
                    Console.SetCursorPosition(positionX, positionY);
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("*");
                }
            }

            public void MoveFireballs()
            {
                for (int i = 0; i < fireballs.Count; i++)
                {
                    if (!fireballs[i].Move())
                    {
                        fireballs.RemoveAt(i);
                    }
                }
            }

            public void CreateFireball(int firePower) //must be call it after MoveFireballs();
            {
                int arisePointX = isRightHeaded ? currentPositonX + mouthFromCenterX : currentPositonX - mouthFromCenterX;
                int arisePointY = currentPositonY - mouthFromCenterY;

                if (minPositonX <= arisePointX && arisePointX <= maxPositonX && frame == 7)
                {
                    Fireball fireball = new Fireball(arisePointX, arisePointY, isRightHeaded, firePower);
                    fireballs.Add(fireball);
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(arisePointX, arisePointY);
                    Console.WriteLine("*");
                }
            }

            public static void PrintDragon(int x, int y, int frameNum = 0, bool isRight = false, int trimL = 0, int trimR = 0)
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                //Console.BackgroundColor = ConsoleColor.White; //for debug
                if (isRight)
                {
                    switch (frameNum)
                    {
                        case 0:
                            Print(x, y /**/, trimL, trimR, @"           ,       ");
                            Print(x, y + 01, trimL, trimR, @"    \\,    }'\     ");
                            Print(x, y + 02, trimL, trimR, @"     \ `\, |` \    ");
                            Print(x, y + 03, trimL, trimR, @"     / -- \| \\|   ");
                            Print(x, y + 04, trimL, trimR, @"    ```\   \ \ *\  ");
                            Print(x, y + 05, trimL, trimR, @"        |,-. ( {""  ");
                            Print(x, y + 06, trimL, trimR, @"        /_ `, \\   ");
                            Print(x, y + 07, trimL, trimR, @"          }   //,  ");
                            Print(x, y + 08, trimL, trimR, @"         /  '-|\|\ ");
                            Print(x, y + 09, trimL, trimR, @"   \-_-_` _/_|```` ");
                            Print(x, y + 10, trimL, trimR, @"        }|}|       ");
                            Print(x, y + 11, trimL, trimR, @"      \"" \ ""       ");
                            Print(x, y + 12, trimL, trimR, @"                   ");
                            break;
                        case 1:
                            Print(x, y /**/, trimL, trimR, @"   '.         ,    ");
                            Print(x, y + 01, trimL, trimR, @"    `'\       :\   ");
                            Print(x, y + 02, trimL, trimR, @"    _| `\     | |  ");
                            Print(x, y + 03, trimL, trimR, @"     \ -,\  -\\||  ");
                            Print(x, y + 04, trimL, trimR, @"      `\  |  \ *\  ");
                            Print(x, y + 05, trimL, trimR, @"       '|,-./( {""  ");
                            Print(x, y + 06, trimL, trimR, @"       /--.`, \\   ");
                            Print(x, y + 07, trimL, trimR, @"          }   //,  ");
                            Print(x, y + 08, trimL, trimR, @"         /  '-|\|\ ");
                            Print(x, y + 09, trimL, trimR, @"   \-_-_` _/_|```` ");
                            Print(x, y + 10, trimL, trimR, @"        }|}|       ");
                            Print(x, y + 11, trimL, trimR, @"        \""\""       ");
                            Print(x, y + 12, trimL, trimR, @"                   ");
                            break;
                        case 2:
                            Print(x, y /**/, trimL, trimR, @"                   ");
                            Print(x, y + 01, trimL, trimR, @"',,                ");
                            Print(x, y + 02, trimL, trimR, @"  \\,           \  ");
                            Print(x, y + 03, trimL, trimR, @"  -\ \,     \\|,`| ");
                            Print(x, y + 04, trimL, trimR, @"    \'\\,   \ *\ / ");
                            Print(x, y + 05, trimL, trimR, @"     '\  \  ( {""/  ");
                            Print(x, y + 06, trimL, trimR, @"      /--.\- \\`   ");
                            Print(x, y + 07, trimL, trimR, @"        ,}  ///    ");
                            Print(x, y + 08, trimL, trimR, @"      _/    \ \    ");
                            Print(x, y + 09, trimL, trimR, @"   -~--|\|\||\|\   ");
                            Print(x, y + 10, trimL, trimR, @"      }/}/  ````   ");
                            Print(x, y + 11, trimL, trimR, @"                   ");
                            Print(x, y + 12, trimL, trimR, @"                   ");
                            break;
                        case 3:
                            Print(x, y /**/, trimL, trimR, @"                   ");
                            Print(x, y + 01, trimL, trimR, @"                   ");
                            Print(x, y + 02, trimL, trimR, @"                   ");
                            Print(x, y + 03, trimL, trimR, @"              \\|  ");
                            Print(x, y + 04, trimL, trimR, @"              \ *\ ");
                            Print(x, y + 05, trimL, trimR, @"             ,(,{"" ");
                            Print(x, y + 06, trimL, trimR, @"  ,,__-----_-`\|-,_");
                            Print(x, y + 07, trimL, trimR, @" _.).--'-/`  ///\ /");
                            Print(x, y + 08, trimL, trimR, @"       /`_/_/\ \`` ");
                            Print(x, y + 09, trimL, trimR, @"    ,/`}/}|  |\|\  ");
                            Print(x, y + 10, trimL, trimR, @"    `  "" ""   ````  ");
                            Print(x, y + 11, trimL, trimR, @"                   ");
                            Print(x, y + 12, trimL, trimR, @"                   ");
                            break;
                        case 4:
                            Print(x, y /**/, trimL, trimR, @"                   ");
                            Print(x, y + 01, trimL, trimR, @"                   ");
                            Print(x, y + 02, trimL, trimR, @"                   ");
                            Print(x, y + 03, trimL, trimR, @"              \\|  ");
                            Print(x, y + 04, trimL, trimR, @"              \ *\ ");
                            Print(x, y + 05, trimL, trimR, @"             '(,{"" ");
                            Print(x, y + 06, trimL, trimR, @"        /-_-_`\|   ");
                            Print(x, y + 07, trimL, trimR, @"       /  \  ///\, ");
                            Print(x, y + 08, trimL, trimR, @"      //,/_/}\ \ \ ");
                            Print(x, y + 09, trimL, trimR, @"    /`,/{/   |\|\| ");
                            Print(x, y + 10, trimL, trimR, @"   /,/       ````| ");
                            Print(x, y + 11, trimL, trimR, @"  //            /` ");
                            Print(x, y + 12, trimL, trimR, @"                   ");
                            break;
                        case 5:
                            Print(x, y /**/, trimL, trimR, @"                   ");
                            Print(x, y + 01, trimL, trimR, @"                   ");
                            Print(x, y + 02, trimL, trimR, @"                   ");
                            Print(x, y + 03, trimL, trimR, @"              \\|  ");
                            Print(x, y + 04, trimL, trimR, @"              \ *\ ");
                            Print(x, y + 05, trimL, trimR, @"             '(,{"" ");
                            Print(x, y + 06, trimL, trimR, @"        /-_-_`\|   ");
                            Print(x, y + 07, trimL, trimR, @"       /  \  ///\, ");
                            Print(x, y + 08, trimL, trimR, @"      /.`/_/}\\  | ");
                            Print(x, y + 09, trimL, trimR, @"    ,``/{/   |\\`| ");
                            Print(x, y + 10, trimL, trimR, @"    | /      ```|| ");
                            Print(x, y + 11, trimL, trimR, @"    //          |` ");
                            Print(x, y + 12, trimL, trimR, @"   '           /`  ");
                            break;
                        case 6:
                            Print(x, y /**/, trimL, trimR, @"                   ");
                            Print(x, y + 01, trimL, trimR, @"                   ");
                            Print(x, y + 02, trimL, trimR, @"                   ");
                            Print(x, y + 03, trimL, trimR, @"              \\|  ");
                            Print(x, y + 04, trimL, trimR, @"              \ *\ ");
                            Print(x, y + 05, trimL, trimR, @"        _____/(,{"" ");
                            Print(x, y + 06, trimL, trimR, @"       /--// `\|,  ");
                            Print(x, y + 07, trimL, trimR, @"      /  / ,`/// \ ");
                            Print(x, y + 08, trimL, trimR, @"     / `//_/}\\\` |");
                            Print(x, y + 09, trimL, trimR, @"    / ,/{/   |\\\ |");
                            Print(x, y + 10, trimL, trimR, @"    //       ```|/ ");
                            Print(x, y + 11, trimL, trimR, @"   /            /  ");
                            Print(x, y + 12, trimL, trimR, @"                   "); break;
                        case 7:
                            Print(x, y /**/, trimL, trimR, @"                   ");
                            Print(x, y + 01, trimL, trimR, @"                   ");
                            Print(x, y + 02, trimL, trimR, @"                   ");
                            Print(x, y + 03, trimL, trimR, @"              \\|  ");
                            Print(x, y + 04, trimL, trimR, @"              \ *\ ");
                            Print(x, y + 05, trimL, trimR, @"         ____/(,{"" ");
                            Print(x, y + 06, trimL, trimR, @"       /`/-/``\|-\ ");
                            Print(x, y + 07, trimL, trimR, @"     /`///`  //(  |");
                            Print(x, y + 08, trimL, trimR, @"   /` //`^-_}\\\| |");
                            Print(x, y + 09, trimL, trimR, @"   ///)/,}}  |\\|/ ");
                            Print(x, y + 10, trimL, trimR, @"  / / '` ""   ```/  ");
                            Print(x, y + 11, trimL, trimR, @"                   ");
                            Print(x, y + 12, trimL, trimR, @"                   ");
                            break;
                        case 8:
                            Print(x, y /**/, trimL, trimR, @"                   ");
                            Print(x, y + 01, trimL, trimR, @"                   ");
                            Print(x, y + 02, trimL, trimR, @"                   ");
                            Print(x, y + 03, trimL, trimR, @"              \\|  ");
                            Print(x, y + 04, trimL, trimR, @"              \ *\ ");
                            Print(x, y + 05, trimL, trimR, @"      __---__/(,{"" ");
                            Print(x, y + 06, trimL, trimR, @"    /`.-/-\\}`\| '\");
                            Print(x, y + 07, trimL, trimR, @"  .//` ` ,/  //(\ |");
                            Print(x, y + 08, trimL, trimR, @" //`  _,/- _}\\\`/ ");
                            Print(x, y + 09, trimL, trimR, @"    //-//-/-` '""`  ");
                            Print(x, y + 10, trimL, trimR, @"   '`  "" ""`        ");
                            Print(x, y + 11, trimL, trimR, @"                   ");
                            Print(x, y + 12, trimL, trimR, @"                   ");
                            break;
                        case 9:
                            Print(x, y /**/, trimL, trimR, @"                   ");
                            Print(x, y + 01, trimL, trimR, @"                   ");
                            Print(x, y + 02, trimL, trimR, @"                   ");
                            Print(x, y + 03, trimL, trimR, @"              \\|  ");
                            Print(x, y + 04, trimL, trimR, @"_,,-,----,.   \ *\ ");
                            Print(x, y + 05, trimL, trimR, @"   /--.   \._/(,{"" ");
                            Print(x, y + 06, trimL, trimR, @"       }/\,\}`\|   ");
                            Print(x, y + 07, trimL, trimR, @"         ,/  //(   ");
                            Print(x, y + 08, trimL, trimR, @"        /`/ ,\\\,  ");
                            Print(x, y + 09, trimL, trimR, @"   ,,-^`,_),) '""`  ");
                            Print(x, y + 10, trimL, trimR, @"   '```/} /}       ");
                            Print(x, y + 11, trimL, trimR, @"       ""  ""        ");
                            Print(x, y + 12, trimL, trimR, @"                   ");
                            break;
                        case 10:
                            Print(x, y /**/, trimL, trimR, @"                   ");
                            Print(x, y + 01, trimL, trimR, @"                   ");
                            Print(x, y + 02, trimL, trimR, @" '-_-._      )\    ");
                            Print(x, y + 03, trimL, trimR, @"    )  ''\   \\|   ");
                            Print(x, y + 04, trimL, trimR, @"   /--,   \ /\ *\  ");
                            Print(x, y + 05, trimL, trimR, @"       \   v (,{""  ");
                            Print(x, y + 06, trimL, trimR, @"       }/\,\}`\\   ");
                            Print(x, y + 07, trimL, trimR, @"         ,/  //(   ");
                            Print(x, y + 08, trimL, trimR, @"        /`/ ,\\\\  ");
                            Print(x, y + 09, trimL, trimR, @"   ,,-_^ .),) '``` ");
                            Print(x, y + 10, trimL, trimR, @"   '`` `)}/}       ");
                            Print(x, y + 11, trimL, trimR, @"        "" ""        ");
                            Print(x, y + 12, trimL, trimR, @"                   ");
                            break;
                        default:
                            for (int i = 0; i < 12; i++)
                            {
                                Print(x, y + i, trimL, trimR, @"                   ");
                            }
                            break;
                    }
                }
                else
                {
                    switch (frameNum)
                    {
                        case 0:
                            Print(x, y /**/, trimL, trimR, @"       ,           ");
                            Print(x, y + 01, trimL, trimR, @"     /'{    ,//    ");
                            Print(x, y + 02, trimL, trimR, @"    / `| ,/` /     ");
                            Print(x, y + 03, trimL, trimR, @"   |// |/ -- \     ");
                            Print(x, y + 04, trimL, trimR, @"  /* / /   /```    ");
                            Print(x, y + 05, trimL, trimR, @"  ""} ) .-,|        ");
                            Print(x, y + 06, trimL, trimR, @"   // ,` _\        ");
                            Print(x, y + 07, trimL, trimR, @"  ,\\   {          ");
                            Print(x, y + 08, trimL, trimR, @" /|/|-'  \         ");
                            Print(x, y + 09, trimL, trimR, @" ````|_\_ `_-_-/   ");
                            Print(x, y + 10, trimL, trimR, @"       |{|{        ");
                            Print(x, y + 11, trimL, trimR, @"       "" / ""/      ");
                            Print(x, y + 12, trimL, trimR, @"                   ");
                            break;
                        case 1:
                            Print(x, y /**/, trimL, trimR, @"    ,         .'   ");
                            Print(x, y + 01, trimL, trimR, @"   /:       /'`    ");
                            Print(x, y + 02, trimL, trimR, @"  | |     /` |_    ");
                            Print(x, y + 03, trimL, trimR, @"  ||//-  /,- /     ");
                            Print(x, y + 04, trimL, trimR, @"  /* /  |  /`      ");
                            Print(x, y + 05, trimL, trimR, @"  ""} )\.-,|'       ");
                            Print(x, y + 06, trimL, trimR, @"   // ,`.--\       ");
                            Print(x, y + 07, trimL, trimR, @"  ,\\   {          ");
                            Print(x, y + 08, trimL, trimR, @" /|/|-'  \         ");
                            Print(x, y + 09, trimL, trimR, @" ````|_\_ `_-_-/   ");
                            Print(x, y + 10, trimL, trimR, @"       |{|{        ");
                            Print(x, y + 11, trimL, trimR, @"       ""/""/        ");
                            Print(x, y + 12, trimL, trimR, @"                   ");
                            break;
                        case 2:
                            Print(x, y /**/, trimL, trimR, @"                   ");
                            Print(x, y + 01, trimL, trimR, @"                ,,'");
                            Print(x, y + 02, trimL, trimR, @"  /           ,//  ");
                            Print(x, y + 03, trimL, trimR, @" |`,|//     ,/ /-  ");
                            Print(x, y + 04, trimL, trimR, @" \ /* /   ,//'/    ");
                            Print(x, y + 05, trimL, trimR, @"  \""} )  /  /'     ");
                            Print(x, y + 06, trimL, trimR, @"   `// -/.--\      ");
                            Print(x, y + 07, trimL, trimR, @"    \\\  {,        ");
                            Print(x, y + 08, trimL, trimR, @"    / /    \_      ");
                            Print(x, y + 09, trimL, trimR, @"   /|/||/|/|--~-   ");
                            Print(x, y + 10, trimL, trimR, @"   ````  \{\{      ");
                            Print(x, y + 11, trimL, trimR, @"                   ");
                            Print(x, y + 12, trimL, trimR, @"                   ");
                            break;
                        case 3:
                            Print(x, y /**/, trimL, trimR, @"                   ");
                            Print(x, y + 01, trimL, trimR, @"                   ");
                            Print(x, y + 02, trimL, trimR, @"                   ");
                            Print(x, y + 03, trimL, trimR, @"  |//              ");
                            Print(x, y + 04, trimL, trimR, @" /* /              ");
                            Print(x, y + 05, trimL, trimR, @" ""},),             ");
                            Print(x, y + 06, trimL, trimR, @"_,-|/`-_-----__,,  ");
                            Print(x, y + 07, trimL, trimR, @"\ /\\\  `\-'--.(._ ");
                            Print(x, y + 08, trimL, trimR, @" ``/ /\_\_`\       ");
                            Print(x, y + 09, trimL, trimR, @"  /|/|  |{\{`\,    ");
                            Print(x, y + 10, trimL, trimR, @"  ````   "" ""  `    ");
                            Print(x, y + 11, trimL, trimR, @"                   ");
                            Print(x, y + 12, trimL, trimR, @"                   ");
                            break;
                        case 4:
                            Print(x, y /**/, trimL, trimR, @"                   ");
                            Print(x, y + 01, trimL, trimR, @"                   ");
                            Print(x, y + 02, trimL, trimR, @"                   ");
                            Print(x, y + 03, trimL, trimR, @"  |//              ");
                            Print(x, y + 04, trimL, trimR, @" /* /              ");
                            Print(x, y + 05, trimL, trimR, @" ""},)'             ");
                            Print(x, y + 06, trimL, trimR, @"   |/`_-_-\        ");
                            Print(x, y + 07, trimL, trimR, @" ,/\\\  /  \       ");
                            Print(x, y + 08, trimL, trimR, @" / / /{\_\,\\      ");
                            Print(x, y + 09, trimL, trimR, @" |/|/|   \}\,`\    ");
                            Print(x, y + 10, trimL, trimR, @" |````       \,\   ");
                            Print(x, y + 11, trimL, trimR, @" `\            \\  ");
                            Print(x, y + 12, trimL, trimR, @"                   ");
                            break;
                        case 5:
                            Print(x, y /**/, trimL, trimR, @"                   ");
                            Print(x, y + 01, trimL, trimR, @"                   ");
                            Print(x, y + 02, trimL, trimR, @"                   ");
                            Print(x, y + 03, trimL, trimR, @"  |//              ");
                            Print(x, y + 04, trimL, trimR, @" /* /              ");
                            Print(x, y + 05, trimL, trimR, @" ""},)'             ");
                            Print(x, y + 06, trimL, trimR, @"   |/`_-_-\        ");
                            Print(x, y + 07, trimL, trimR, @" ,/\\\  /  \       ");
                            Print(x, y + 08, trimL, trimR, @" |  //{\_\`.\      ");
                            Print(x, y + 09, trimL, trimR, @" |`//|   \}\``,    ");
                            Print(x, y + 10, trimL, trimR, @" ||```      \ |    ");
                            Print(x, y + 11, trimL, trimR, @" `|          \\    ");
                            Print(x, y + 12, trimL, trimR, @"  `\           '   ");
                            break;
                        case 6:
                            Print(x, y /**/, trimL, trimR, @"                   ");
                            Print(x, y + 01, trimL, trimR, @"                   ");
                            Print(x, y + 02, trimL, trimR, @"                   ");
                            Print(x, y + 03, trimL, trimR, @"  |//              ");
                            Print(x, y + 04, trimL, trimR, @" /* /              ");
                            Print(x, y + 05, trimL, trimR, @" ""},)\_____        ");
                            Print(x, y + 06, trimL, trimR, @"  ,|/` \\--\       ");
                            Print(x, y + 07, trimL, trimR, @" / \\\`, \  \      ");
                            Print(x, y + 08, trimL, trimR, @"| `///{\_\\` \     ");
                            Print(x, y + 09, trimL, trimR, @"| ///|   \}\, \    ");
                            Print(x, y + 10, trimL, trimR, @" \|```       \\    ");
                            Print(x, y + 11, trimL, trimR, @"  \            \   ");
                            Print(x, y + 12, trimL, trimR, @"                   ");
                            break;
                        case 7:
                            Print(x, y /**/, trimL, trimR, @"                   ");
                            Print(x, y + 01, trimL, trimR, @"                   ");
                            Print(x, y + 02, trimL, trimR, @"                   ");
                            Print(x, y + 03, trimL, trimR, @"  |//              ");
                            Print(x, y + 04, trimL, trimR, @" /* /              ");
                            Print(x, y + 05, trimL, trimR, @" ""},)\____         ");
                            Print(x, y + 06, trimL, trimR, @" /-|/``\-\`\       ");
                            Print(x, y + 07, trimL, trimR, @"|  )\\  `\\\`\     ");
                            Print(x, y + 08, trimL, trimR, @"| |///{_-^`\\ `\   ");
                            Print(x, y + 09, trimL, trimR, @" \|//|  {{,\(\\\   ");
                            Print(x, y + 10, trimL, trimR, @"  \```   "" `' \ \  ");
                            Print(x, y + 11, trimL, trimR, @"                   ");
                            Print(x, y + 12, trimL, trimR, @"                   ");
                            break;
                        case 8:
                            Print(x, y /**/, trimL, trimR, @"                   ");
                            Print(x, y + 01, trimL, trimR, @"                   ");
                            Print(x, y + 02, trimL, trimR, @"                   ");
                            Print(x, y + 03, trimL, trimR, @"  |//              ");
                            Print(x, y + 04, trimL, trimR, @" /* /              ");
                            Print(x, y + 05, trimL, trimR, @" ""},)\__---__      ");
                            Print(x, y + 06, trimL, trimR, @"/' |/`{//-\-.`\    ");
                            Print(x, y + 07, trimL, trimR, @"| /)\\  \, ` `\\.  ");
                            Print(x, y + 08, trimL, trimR, @" \`///{_ -\,_  `\\ ");
                            Print(x, y + 09, trimL, trimR, @"  `""' `-\-\\-\\    ");
                            Print(x, y + 10, trimL, trimR, @"        `"" ""  `'   ");
                            Print(x, y + 11, trimL, trimR, @"                   ");
                            Print(x, y + 12, trimL, trimR, @"                   ");
                            break;
                        case 9:
                            Print(x, y /**/, trimL, trimR, @"                   ");
                            Print(x, y + 01, trimL, trimR, @"                   ");
                            Print(x, y + 02, trimL, trimR, @"                   ");
                            Print(x, y + 03, trimL, trimR, @"  |//              ");
                            Print(x, y + 04, trimL, trimR, @" /* /   .,----,-,,_");
                            Print(x, y + 05, trimL, trimR, @" ""},)\_./   .--\   ");
                            Print(x, y + 06, trimL, trimR, @"   |/`{/,/\{       ");
                            Print(x, y + 07, trimL, trimR, @"   )\\  \,         ");
                            Print(x, y + 08, trimL, trimR, @"  ,///, \`\        ");
                            Print(x, y + 09, trimL, trimR, @"  `""' (,(_,`^-,,   ");
                            Print(x, y + 10, trimL, trimR, @"       {\ {\```'   ");
                            Print(x, y + 11, trimL, trimR, @"        ""  ""       ");
                            Print(x, y + 12, trimL, trimR, @"                   ");
                            break;
                        case 10:
                            Print(x, y /**/, trimL, trimR, @"                   ");
                            Print(x, y + 01, trimL, trimR, @"                   ");
                            Print(x, y + 02, trimL, trimR, @"    /(      _.-_-' ");
                            Print(x, y + 03, trimL, trimR, @"   |//   /''  (    ");
                            Print(x, y + 04, trimL, trimR, @"  /* /\ /   ,--\   ");
                            Print(x, y + 05, trimL, trimR, @"  ""},) v   /       ");
                            Print(x, y + 06, trimL, trimR, @"   //`{/,/\{       ");
                            Print(x, y + 07, trimL, trimR, @"   )\\  \,         ");
                            Print(x, y + 08, trimL, trimR, @"  ////, \`\        ");
                            Print(x, y + 09, trimL, trimR, @" ```' (,(. ^_-,,   ");
                            Print(x, y + 10, trimL, trimR, @"       {\{(` ``'   ");
                            Print(x, y + 11, trimL, trimR, @"        "" ""        ");
                            Print(x, y + 12, trimL, trimR, @"                   ");
                            break;
                        default:
                            for (int i = 0; i < 12; i++)
                            {
                                Print(x, y + i, trimL, trimR, @"                   ");
                            }
                            break;
                    }
                }
            }
        }

        public class Hero
        {
            Random rand;
            public const int length = 6;
            public const int height = 8;
            public bool isRightHeaded;
            public int positionX;
            public int positionY;
            public int minPositionX;
            public int minPositionY;
            public int maxPositionX;
            public int maxPositionY;
            public int frame;
            public List<Bullet> bullets;

            public Hero(int x, int y, bool isRightHeaded, int left, int top, int right, int bottom)
            {
                rand = new Random();
                minPositionX = left;
                minPositionY = top + (height >> 1);
                maxPositionX = right;
                maxPositionY = bottom - (height >> 1);
                positionX = (minPositionX <= x && x <= maxPositionX - length) ? x : rand.Next(minPositionX, maxPositionX - length + 1);
                positionY = (minPositionY - height <= y && y <= maxPositionY) ? y : rand.Next(minPositionY, maxPositionY + 1);
                frame = 1;
                bullets = new List<Bullet>();
            }

            public void Move(bool isRunningRight)
            {
                if (isRunningRight)
                {
                    if (isRightHeaded)
                    {
                        if (positionX <= maxPositionX - length)
                        {
                            positionX++;
                        }
                    }
                    else
                    {
                        isRightHeaded = true;
                        if (positionX <= maxPositionX - length)
                        {
                            positionX++;
                        }
                    }
                }
                else
                {
                    if (isRightHeaded)
                    {
                        isRightHeaded = false;
                    }
                    else
                    {
                        if (minPositionX < positionX)
                        {
                            positionX--;
                        }
                    }
                }

                PrintHero(positionX, positionY, frame, isRightHeaded);
                //Console.SetCursorPosition(positionX, positionY); //for debug
                //Console.WriteLine("x"); //for debug

                frame = (frame == 3) ? 1 : (frame + 1);
            }

            public void DoNothing()
            {
                frame = 1;
                PrintHero(positionX, positionY, frame, isRightHeaded);
            }

            public void Shooting()
            {
                PrintHero(positionX, positionY, 0, isRightHeaded);
                Bullet bullet = new Bullet(isRightHeaded ? positionX + 4 : positionX + 1, positionY - 1);
                bullets.Add(bullet);
            }

            public class Bullet
            {
                public int positionX;
                public int positionY;
                public int firePower;

                public Bullet(int positionX, int positionY, int firePower = 1)
                {
                    this.positionX = positionX;
                    this.positionY = positionY;
                    this.firePower = firePower;
                }

                public bool Move(int moveSpeed = 1)
                {
                    Print(positionX, positionY);
                    if (positionY - moveSpeed >= GC.gameFieldTop)
                    {
                        positionY -= moveSpeed;
                        return true;
                    }
                    return false;
                }

                public static void Print(int positionX, int positionY)
                {
                    Console.SetCursorPosition(positionX, positionY);
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("+");
                }
            }

            public void MoveBullets()
            {
                for (int i = 0; i < bullets.Count; i++)
                {
                    if (!bullets[i].Move())
                    {
                        bullets.RemoveAt(i);
                    }
                }
            }

            public static void PrintHero(int x, int y, int frameNum = 0, bool isRight = false, int trimL = 0, int trimR = 0)
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Gray;
                //Console.BackgroundColor = ConsoleColor.White; //for debug
                if (isRight)
                {
                    switch (frameNum)
                    {
                        case 0:
                            Print(x, y /**/, trimL, trimR, @"    I_");
                            Print(x, y + 01, trimL, trimR, @"  n/F""");
                            Print(x, y + 02, trimL, trimR, @" ( )L ");
                            Print(x, y + 03, trimL, trimR, @" {\-' ");
                            Print(x, y + 04, trimL, trimR, @" ||   ");
                            Print(x, y + 05, trimL, trimR, @"  \\  ");
                            Print(x, y + 06, trimL, trimR, @" ///  ");
                            Print(x, y + 07, trimL, trimR, @" \L_  ");
                            break;
                        case 1:
                            Print(x, y /**/, trimL, trimR, @"      ");
                            Print(x, y + 01, trimL, trimR, @"  n_  ");
                            Print(x, y + 02, trimL, trimR, @" ( )./");
                            Print(x, y + 03, trimL, trimR, @" {\\/]");
                            Print(x, y + 04, trimL, trimR, @" ||   ");
                            Print(x, y + 05, trimL, trimR, @"  \\  ");
                            Print(x, y + 06, trimL, trimR, @" ///  ");
                            Print(x, y + 07, trimL, trimR, @" \L_  ");
                            break;
                        case 2:
                            Print(x, y /**/, trimL, trimR, @"      ");
                            Print(x, y + 01, trimL, trimR, @"  n_  ");
                            Print(x, y + 02, trimL, trimR, @" ( )./");
                            Print(x, y + 03, trimL, trimR, @" {\\/]");
                            Print(x, y + 04, trimL, trimR, @" ||   ");
                            Print(x, y + 05, trimL, trimR, @" //\  ");
                            Print(x, y + 06, trimL, trimR, @"////  ");
                            Print(x, y + 07, trimL, trimR, @"\'`'  ");
                            break;
                        case 3:
                            Print(x, y /**/, trimL, trimR, @"      ");
                            Print(x, y + 01, trimL, trimR, @"  n_  ");
                            Print(x, y + 02, trimL, trimR, @" ( )./");
                            Print(x, y + 03, trimL, trimR, @" {\\/]");
                            Print(x, y + 04, trimL, trimR, @" ||   ");
                            Print(x, y + 05, trimL, trimR, @"._\\  ");
                            Print(x, y + 06, trimL, trimR, @"v- \\ ");
                            Print(x, y + 07, trimL, trimR, @"    U_");
                            break;

                        default:
                            for (int i = 0; i < height; i++)
                            {
                                Print(x, y + i, trimL, trimR, @"      ");
                            }
                            break;
                    }
                }
                else
                {
                    switch (frameNum)
                    {
                        case 0:
                            Print(x, y /**/, trimL, trimR, @"_I    ");
                            Print(x, y + 01, trimL, trimR, @"""I\n  ");
                            Print(x, y + 02, trimL, trimR, @"mj( ) ");
                            Print(x, y + 03, trimL, trimR, @" '-/} ");
                            Print(x, y + 04, trimL, trimR, @"   || ");
                            Print(x, y + 05, trimL, trimR, @"  //  ");
                            Print(x, y + 06, trimL, trimR, @"  \\\ ");
                            Print(x, y + 07, trimL, trimR, @"  _j/ ");
                            break;
                        case 1:
                            Print(x, y /**/, trimL, trimR, @"      ");
                            Print(x, y + 01, trimL, trimR, @"  _n  ");
                            Print(x, y + 02, trimL, trimR, @"\.( ) ");
                            Print(x, y + 03, trimL, trimR, @"{\()) ");
                            Print(x, y + 04, trimL, trimR, @"  {/| ");
                            Print(x, y + 05, trimL, trimR, @"  //  ");
                            Print(x, y + 06, trimL, trimR, @"  \\\ ");
                            Print(x, y + 07, trimL, trimR, @"  _j/ ");
                            break;
                        case 2:
                            Print(x, y /**/, trimL, trimR, @"      ");
                            Print(x, y + 01, trimL, trimR, @"  _n  ");
                            Print(x, y + 02, trimL, trimR, @"\.( ) ");
                            Print(x, y + 03, trimL, trimR, @"{\()) ");
                            Print(x, y + 04, trimL, trimR, @"  {/| ");
                            Print(x, y + 05, trimL, trimR, @"  /\\ ");
                            Print(x, y + 06, trimL, trimR, @"  \\\\");
                            Print(x, y + 07, trimL, trimR, @"  '`'-");
                            break;
                        case 3:
                            Print(x, y /**/, trimL, trimR, @"      ");
                            Print(x, y + 01, trimL, trimR, @"  _n  ");
                            Print(x, y + 02, trimL, trimR, @"\.( ) ");
                            Print(x, y + 03, trimL, trimR, @"{\()) ");
                            Print(x, y + 04, trimL, trimR, @"  {/| ");
                            Print(x, y + 05, trimL, trimR, @"  //_.");
                            Print(x, y + 06, trimL, trimR, @" // -v");
                            Print(x, y + 07, trimL, trimR, @"_U    ");
                            break;
                        default:
                            for (int i = 0; i < height; i++)
                            {
                                Print(x, y + i, trimL, trimR, @"                   ");
                            }
                            break;
                    }
                }
            }
        }

        public static void OldKing(int x, int y)
        {
            Console.ResetColor();
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(@" MMM ");

            Console.SetCursorPosition(x, y + 1);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(@" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(@"o,O");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(@" ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(x, y + 2);
            Console.Write(@"'");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"{(}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(@"'");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine(@" o o ");
        }

        private static void Print(int x, int y, int trimL, int trimR, string ascii)
        {
            if (trimL != 0)
            {
                ascii = ascii.Substring(trimL);
            }
            if (trimR != 0)
            {
                ascii = ascii.Substring(0, ascii.Length - trimR);
            }
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ascii);
        }
    }
}
