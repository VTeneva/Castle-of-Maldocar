using System;
using System.Linq;

namespace _01.Game_Frame
{
    class GameCharacters
    {
        public static void Dragon(int x, int y, int frameNum = 0, bool isRight = false, int trimL = 0, int trimR = 0)
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White; //for debug
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
