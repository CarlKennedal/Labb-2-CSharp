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
    public override string Name { get; set; } = "Snake";
    public override int healthPoints { get; set; } = 25;
    public override int attackDice { get; set; }
    public override int defenseDice { get; set; }

    public override void Update()
    {
        
    }
}
//Snake: HP = 25, Attack = 3d4 + 2, Defence = 1d8 + 5 
