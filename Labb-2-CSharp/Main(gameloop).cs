
LevelData levelEtt = new LevelData();




//Stor dator levelEtt.Load("C:\\Users\\carlk\\source\\repos\\Labb-2-CSharp\\Labb-2-CSharp\\Level1.txt");
levelEtt.Load("Level1.txt"); //Properties på textfilen ska vara always copy


foreach (LevelElement x in levelEtt.elements)
{
    x.Draw();
}
