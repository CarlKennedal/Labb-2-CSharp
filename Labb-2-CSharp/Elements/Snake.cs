﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Snake : Enemy
{
    public override char Type { get; set; } = 's';


    public override Position Position { get; set; }
    public override string Name { get; set; } = "Snake";
    public override int healthPoints { get; set; } = 25;
    public override int attackDice { get; set; }
    public override int defenseDice { get; set; }
    public override ConsoleColor Color { get; set; } = ConsoleColor.Green;


    public int move;

    public override void Update()
    {
        MoveSnake(this, LevelData.leveldataPlayer);
    }
    public void MoveSnake(Snake snake, Player player)
    {
        int distance = snake.Position.DistanceTo(player.Position);
        if (distance < 3)
        {
            if (player.Position.Y <= snake.Position.Y - 2)
            {
                Move(y: +1);
            }
            else if (player.Position.X <= snake.Position.X - 2)
            {
                Move(x: +1);
            }
            else if (player.Position.Y <= snake.Position.Y + 2)
            {
                Move(y: -1);
            }
            else if (player.Position.X <= snake.Position.X + 2)
            {
                Move(x: -1);
            }
        }
    }
}

//Snake: HP = 25, Attack = 3d4 + 2, Defence = 1d8 + 5 
