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
    public bool IsCollidingWith(LevelElement other)
    {
        return this.Position.X == other.Position.X && this.Position.Y == other.Position.Y;
    }


    public void Draw()
    {
        Console.ForegroundColor = Color;
        Console.SetCursorPosition(Position.X, Position.Y);
        Console.Write(Type);
    }
}