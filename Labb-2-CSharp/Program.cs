LevelData levelEtt = new LevelData();

levelEtt.Load("Level1.txt"); //Properties på textfilen ska vara always copy
while (true)
{
    foreach(LevelElement draw in levelEtt.elements)
    {
        draw.Draw();
    }
    foreach (LivingElement mobs in levelEtt.elements.OfType<LivingElement>())
    {  
        mobs.Update();
        mobs.Draw();
    }
}



/*
Initiera spelet

Medan spelet är igång:
Input för processen
Uppdatera spelets status
Rendera spel

Rensning och avslutning
*/