using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

struct Position
{
    public int x;
    public int y;

    public double DistanceTo(Position other)
    {
        double posX = other.X - this.X;
        double posY = other.Y - this.Y;
        return Math.Sqrt(posX * posX + posY * posY);
    }

    public int VerticalDistanceTo(Position position) => Math.Abs(position.X - this.X);
    public int HorisontalDistanceTo(Position position) => Math.Abs(position.Y - this.Y);

}