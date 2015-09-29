using System;

class GameCharacters
{

    static void Main()
    {
        Dragon(1, 3);
    }

    static void Dragon(int x, int y)
    {
        Console.SetCursorPosition(x, y);
        var dragon = new[]
        {
            @"        ,       ",
            @"      _/;	      ",
            @"  a^-/@ }~(     ",
            @"~~'\-w / ((   <.",  
            @"      \ \(/__  )",
            @"       \( _(_)' ",
            @"        _> _>	  ",
        };
        foreach (var line in dragon)
        {
            Console.WriteLine(line);
        }

    }

}
