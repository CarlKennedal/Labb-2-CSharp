using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


public abstract class LevelElement
{
    public abstract Position Position { get; set; }
    public abstract char Type { get; set; }
    public abstract ConsoleColor Color { get; set; }
    public bool IsColliding {  get; set; }


    public void Draw()
    {
        Console.ForegroundColor = Color;
        Console.SetCursorPosition(Position.X, Position.Y);
        Console.Write(Type);
    }
}

// Kolla x och y +-1 i listan av elements om det ingpår i något annat och isåfall blocka gången dit, ta det elementet i vägen och attackera om det är mob