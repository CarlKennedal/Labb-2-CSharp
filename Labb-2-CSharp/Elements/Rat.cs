using System;
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

    public override Position Position { get; set; }

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
                Move(y: -1);
                break;
            case Direction.RIGHT:
                Move(x: +1);
                break;
            case Direction.DOWN:
                Move(y: +1);
                break;
            case Direction.LEFT:
                Move(x: -1);
                break;
        }
    }
}

//Rat: HP = 10, Attack = 1d6 + 3, Defence = 1d6 + 1
