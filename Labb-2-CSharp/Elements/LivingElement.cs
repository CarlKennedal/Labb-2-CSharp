using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class LivingElement : LevelElement
{
    public abstract int healthPoints { get; set; }

    public abstract string Name { get; set; }

    public void Move(int x = 0, int y = 0)
    {
       /* IsCollidingWith();*/
        Console.SetCursorPosition(Position.X, Position.Y);
        Console.Write(' ');
        
        Position = new Position { X = Position.X + x, Y = Position.Y + y };
        Console.SetCursorPosition(Position.X, Position.Y);
    }

    public abstract void Update();
}
