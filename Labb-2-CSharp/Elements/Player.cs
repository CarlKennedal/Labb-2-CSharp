using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player : LivingElement
{
    public override char Type { get; set; } = '@';
    public override int healthPoints { get; set; } = 100;
    public override string Name { get; set; } = "Player";
    public int attackDice { get; set; } 
    public int defenseDice { get; set; }
    public override int XPos { get; set; }
    public override int YPos { get; set; }
    public Position Position { get; set; }
    public override ConsoleColor Color { get; set; } = ConsoleColor.Blue;


    public int renderDistance = 5;
    public int move = 0;

    public override void Update()
    {
        
        ConsoleKeyInfo movementInput = Console.ReadKey();
        switch (movementInput.Key)
        {
            case ConsoleKey.UpArrow:
                move = YPos - 1;
                Console.SetCursorPosition(XPos, YPos);
                Console.Write(' ');
                Console.SetCursorPosition(XPos, YPos - 1);
                Console.Write(Type);
                YPos -= 1;
                break;

            case ConsoleKey.DownArrow:
                move = YPos + 1;
                Console.SetCursorPosition(XPos, YPos);
                Console.Write(' ');
                Console.SetCursorPosition(XPos, YPos + 1);
                Console.Write(Type);
                YPos += 1;
                break;

            case ConsoleKey.LeftArrow:
                move = XPos - 1;
                Console.SetCursorPosition(XPos, YPos);
                Console.Write(' ');
                Console.SetCursorPosition(XPos - 1, YPos);
                Console.Write(Type);
                XPos -= 1;
                break;

            case ConsoleKey.RightArrow:
                move = XPos + 1;
                Console.SetCursorPosition(XPos, YPos);
                Console.Write(' ');
                Console.SetCursorPosition(XPos + 1, YPos);
                Console.Write(Type);
                XPos += 1;
                break;
        }
    }
}

//Player: HP = 100, Attack = 2d6+2, Defence = 2d6+0