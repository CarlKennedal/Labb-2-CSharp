using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Snake : Enemy
{
    public override char Type { get; set; } = 's';
    public override int XPos { get; set; }
    public override int YPos { get; set; }

    public Position Position { get; set; }
    public override string Name { get; set; } = "Snake";
    public override int healthPoints { get; set; } = 25;
    public override int attackDice { get; set; }
    public override int defenseDice { get; set; }
    public override ConsoleColor Color { get; set; } = ConsoleColor.Green;


    public int move;
    public override void Update()
    {
        
    }
    public void MoveSnake(Snake snake, Player player)
    {
        int distance = snake.Position.DistanceTo(player.Position);
        if (distance < 3)
        {
            if(snake.Position.VerticalDistanceTo(player.Position) < 3)
            {
                move = YPos + 1;
                Console.SetCursorPosition(XPos, YPos);
                Console.Write(' ');
                Console.SetCursorPosition(XPos, YPos + 1);
                Console.Write(Type);
                YPos += 1;
                // Flytta på y.
            }
            else if(snake.Position.HorisontalDistanceTo(player.Position) < 3)
            {
                move = XPos + 1;
                Console.SetCursorPosition(XPos, YPos);
                Console.Write(' ');
                Console.SetCursorPosition(XPos + 1, YPos);
                Console.Write(Type);
                XPos += 1;
                // Flytta på x.
            }
        }
    }
}
//Snake: HP = 25, Attack = 3d4 + 2, Defence = 1d8 + 5 
