using System.Linq;
using System.Reflection.Emit;
using System.Xml.Linq;
LevelData levelEtt = new LevelData();

levelEtt.Load("Level1.txt"); //Properties på textfilen ska vara always copy
Player player = levelEtt.elements.First(e => e is Player)as Player;

while (true)
{
    RenderDistance(player, levelEtt);
    foreach (LevelElement draw in levelEtt.elements)
    {
        if (!draw.IsVisible)
        {
            continue;
        }
        draw.Draw(levelEtt);
    }
    foreach (LivingElement mobs in levelEtt.elements.OfType<LivingElement>())
    {
        mobs.Update();
    }
}

static void RenderDistance(Player player, LevelData level)
{
    foreach (var otherElement in level.elements)
    {
        int distance = player.Position.DistanceTo(otherElement.Position);
        if (distance <= 5)
        {
            otherElement.IsVisible = true;
        }
        if (distance >= 5)
        {
            if (otherElement is Enemy)
            {
                var enemy = (Enemy)otherElement;
                enemy.IsVisible = false;
            }
        }
    }
}

public class CollisionHandler
{
    private LevelData level;

    public CollisionHandler(LevelData level)
    {
        this.level = level;
    }

    public LevelElement CollisionCheck(int x, int y)
    {
        foreach (var element in level.elements)
        {
            if(element.Position.X == x && element.Position.Y == y)
            {
                return element;
            }            
        }
        return null;
    }
}

/* *****************ATT GÖRA*****************
Kollision, attack och updatering av hp samt ta bort "döda" mobs, render distance*/


/*
Initiera spelet

Medan spelet är igång:
Input för processen
Uppdatera spelets status
Rendera spel

Rensning och avslutning
*/
