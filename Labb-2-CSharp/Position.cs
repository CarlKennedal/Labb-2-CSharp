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

    public Position(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public int DistanceTo(Position other)
    {
        int posX = other.x - this.x;
        int posY = other.y - this.y;
        return (int)Math.Round(Math.Sqrt(posX * posX + posY * posY));
    }
    public int VerticalDistanceTo(Position position) => Math.Abs(position.x - this.x);
    public int HorisontalDistanceTo(Position position) => Math.Abs(position.y - this.y);
}