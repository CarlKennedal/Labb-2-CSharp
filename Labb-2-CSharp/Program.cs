using System.Xml.Linq;

LevelData levelEtt = new LevelData();

levelEtt.Load("Level1.txt"); //Properties på textfilen ska vara always copy

/*levelEtt.Load("Level1.txt"); //Properties på textfilen ska vara always copy*/
while (true)
{
    foreach (LevelElement draw in levelEtt.elements)
    {
        draw.Draw();
    }
    foreach (LivingElement mobs in levelEtt.elements.OfType<LivingElement>())
    {
        mobs.Update();
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
public class Render
{
    private LevelData level;
    public Render(LevelData level)
    {
        this.level = level;
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
