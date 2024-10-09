﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Direction
{
    UP,
    DOWN,
    RIGHT,
    LEFT,
};

class Rat : Enemy
{

    public override char Type { get; set; } = 'r';
    public override int XPos { get; set; }
    public override int YPos { get; set; }
    public Position Position { get; set; }

    public override int attackDice { get; set; }
    public override int defenseDice { get; set; }
    public override string Name { get; set; } = "Rat";
    public override int healthPoints { get; set; } = 10;
    public override ConsoleColor Color { get; set; } = ConsoleColor.Red;

    public int move = 0;
    public override void Update()
    {
        Random randomDirection = new Random();
        Direction randomDir = (Direction)randomDirection.Next(0, 4);
        switch (randomDir)
        {
            case Direction.UP:
                move = YPos - 1;
                Console.SetCursorPosition(XPos, YPos);
                Console.Write(' ');
                Console.SetCursorPosition(XPos, YPos - 1);
                Console.Write(Type);
                YPos -= 1;
                break;
            case Direction.RIGHT:
                move = XPos + 1;
                Console.SetCursorPosition(XPos, YPos);
                Console.Write(' ');
                Console.SetCursorPosition(XPos + 1, YPos);
                Console.Write(Type);
                XPos += 1;
                break;
            case Direction.DOWN:
                move = YPos - 1;
                Console.SetCursorPosition(XPos, YPos);
                Console.Write(' ');
                Console.SetCursorPosition(XPos, YPos - 1);
                Console.Write(Type);
                YPos += 1;
                break;
            case Direction.LEFT:
                move = XPos - 1;
                Console.SetCursorPosition(XPos, YPos);
                Console.Write(' ');
                Console.SetCursorPosition(XPos, YPos - 1);
                Console.Write(Type);
                XPos -= 1;
                break;
        }
    }


}

//Rat: HP = 10, Attack = 1d6 + 3, Defence = 1d6 + 1
