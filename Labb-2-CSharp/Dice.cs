using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

public class Dice
{
    public int numberOfDice;
    public int sidesPerDice;
    public int modifier;

    public Dice(int numberOfDice, int sidesPerDice, int modifier)
    {
        this.numberOfDice = numberOfDice;
        this.sidesPerDice = sidesPerDice;
        this.modifier = modifier;
    }
    public int Throw()
    {
        Random random = new Random();
        int total = 0;

        for (int i = 0; i < numberOfDice; i++)
        {
            total += random.Next(1, sidesPerDice + 1);
        }
        total += modifier;
        return total;
    }
    public string ToString()
    {
        return $"{numberOfDice}d{sidesPerDice} + {modifier}";
    }
}