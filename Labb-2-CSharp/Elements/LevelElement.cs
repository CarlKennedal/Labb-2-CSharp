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

    // Element contact metod. Hanterar när mobs och spelare går in i väggar eller varandra.
    public void Draw()
    {
        switch (Type) 
        {
            case '@':
                Console.ForegroundColor = ConsoleColor.Blue;
                break;
            case '#':
                Console.ForegroundColor = ConsoleColor.White;
                break;
            case 'r':
                Console.ForegroundColor = ConsoleColor.Red;
                break;
            case 's':
                Console.ForegroundColor = ConsoleColor.Green;
                break;
        }
        Console.SetCursorPosition(XPos, YPos);
        Console.Write(Type);
        Console.ForegroundColor= ConsoleColor.White;
    }
}