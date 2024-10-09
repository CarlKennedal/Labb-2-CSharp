using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Wall : LevelElement
{
    public override int XPos { get; set; }
    public override int YPos { get; set; }
    public override char Type { get; set; } = '#';

}
