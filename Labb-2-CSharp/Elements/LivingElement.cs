using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class LivingElement : LevelElement
{
    public abstract int healthPoints {  get; set; }

    public abstract string Name { get; set; }


    public abstract void Update();
}
