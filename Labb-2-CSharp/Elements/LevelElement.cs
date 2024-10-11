using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


public abstract class LevelElement
{
    public abstract Position Position { get; set; }
    public abstract char Type { get; set; }
    public abstract ConsoleColor Color { get; set; }
    public bool IsColliding {  get; set; }
    public LevelData LevelData { get; init; }

    public void Draw(Player player, LevelData level)
    {
/*        foreach (var otherElement in level.elements)
        {
            int distance = player.Position.DistanceTo(otherElement.Position);
            if (distance <= 5)
            {
                if (otherElement is Wall)
                {
                    (Wall)otherElement.
                }
            }
        }*/
        Console.ForegroundColor = Color;
        Console.SetCursorPosition(Position.X, Position.Y);
        Console.Write(Type);
    }
}

// Kolla x och y +-1 i listan av elements om det ingpår i något annat och isåfall blocka gången dit, ta det elementet i vägen och attackera om det är mob