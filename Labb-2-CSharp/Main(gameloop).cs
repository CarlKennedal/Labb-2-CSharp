LevelData levelEtt = new LevelData();

levelEtt.Load("Level1.txt"); //Properties på textfilen ska vara always copy

foreach (LevelElement x in levelEtt.elements)
{
    x.Draw();
}
