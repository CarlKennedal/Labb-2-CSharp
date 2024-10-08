Player player = new Player();

LevelData levelEtt = new LevelData();

levelEtt.Load("C:\\Users\\carlk\\source\\repos\\Labb-2-CSharp\\Labb-2-CSharp\\Level1.txt");


foreach(LevelElement x in levelEtt.elements)
{
    x.Draw();
}
