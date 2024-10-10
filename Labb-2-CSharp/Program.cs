LevelData levelEtt = new LevelData();


levelEtt.Load("Level1.txt"); //Properties på textfilen ska vara always copy
while (true)
{
    foreach (LevelElement draw in levelEtt.elements)
    {
        draw.Draw();
    }
    foreach (LivingElement mobs in levelEtt.elements.OfType<LivingElement>())
    {
        mobs.Update();
        mobs.Draw();
    }
}

void CollisionCheck(int x, int y)
{
    foreach (var element in levelEtt.elements)
    {
        var right = element.Position.X + 1;
        foreach (var elementComparison in levelEtt.elements)
        {
            var check = elementComparison.Position.X;
            if (element != elementComparison && right == check)
            {
                element.Position = new Position { X = element.Position.X, Y = element.Position.Y };
                //Attack
            }
        }
        var left = element.Position.X + 1;
        foreach (var elementComparison in levelEtt.elements)
        {
            var check = elementComparison.Position.X;
            if (element != elementComparison && right == check)
            {
                element.Position = new Position { X = element.Position.X, Y = element.Position.Y };
                //Attack
            }
        }
        var up = element.Position.Y - 1;
        foreach (var elementComparison in levelEtt.elements)
        {
            var check = elementComparison.Position.Y;
            if (element != elementComparison && right == check)
            {
                element.Position = new Position { X = element.Position.X, Y = element.Position.Y };
                //Attack
            }
        }
        var down = element.Position.Y + 1;
        foreach (var elementComparison in levelEtt.elements)
        {
            var check = elementComparison.Position.Y;
            if (element != elementComparison && right == check)
            {
                element.Position = new Position { X = element.Position.X, Y = element.Position.Y };
                //Attack
            }
        }
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