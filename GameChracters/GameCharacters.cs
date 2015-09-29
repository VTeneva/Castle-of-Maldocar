using System;

public class GameCharacters
{

    public static void Main()
    {
        Dragon(1, 3);
        Dwarf(10,12);
    }

    public static void Dragon(int x, int y)
    {
        Console.ForegroundColor = ConsoleColor.Red;
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
    public static void Dwarf(int x, int y)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(x, y);
        var dwarf = new[]
        {
            @" /\ ",
            @" Oo ",
            @"'{}'",
        };
        foreach (var line in dwarf)
        {
            Console.WriteLine(line);
        }
    }
}
