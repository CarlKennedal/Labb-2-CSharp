using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public class Player : LivingElement
{
    public override char Type { get; set; } = '@';
    public override int healthPoints { get; set; } = 100;
    public override string Name { get; set; } = "Player";
    public override Dice attackDice { get; set; } = new Dice(2,6,2);
    public override Dice defenseDice { get; set; } = new Dice (2,6,0);

    public override Position Position { get; set; }
    public override ConsoleColor Color { get; set; } = ConsoleColor.Blue;

    public int renderDistance = 5;
    public int move = 0;


    public override void Update()
    {
        ConsoleKeyInfo movementInput = Console.ReadKey();
        switch (movementInput.Key)
        {
            case ConsoleKey.UpArrow:
                Move(y: -1);
                break;
            case ConsoleKey.DownArrow:
                Move(y: +1);
                break;

            case ConsoleKey.LeftArrow:
                Move(x: -1);
                break;

            case ConsoleKey.RightArrow:
                Move(x: +1);
                break;
        }
    }
}

//Player: HP = 100, Attack = 2d6+2, Defence = 2d6+0