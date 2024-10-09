using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class LevelElement
{
    public abstract int XPos { get; set; }
    public abstract int YPos { get; set; }
    public abstract char Type { get; set; }
    public abstract ConsoleColor Color { get; set; }

    public void Collision()
    {

    }
    public void Draw()
    {
        Console.ForegroundColor = Color;
        Console.SetCursorPosition(XPos, YPos);
        Console.Write(Type);
    }
}