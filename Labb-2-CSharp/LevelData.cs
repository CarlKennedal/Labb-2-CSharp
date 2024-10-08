using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




public class LevelData
{

    public List<LevelElement> elements { get; set; } = new List<LevelElement>();
    public void Load(string fileName)
    {
        using (StreamReader reader = new StreamReader(fileName))
        {
            string characters;
            int indexOfY = 0;
            while ((characters = reader.ReadLine()) != null)
            {
            int indexOfX = 0;
                foreach (char c in characters)
                {
                    switch (c)
                    {
                        case '@':
                            var player = new Player();
                            player.XPos = indexOfX;
                            player.YPos = indexOfY;
                            elements.Add(player);
                            break;

                        case '#':
                            var wall = new Wall();
                            wall.XPos = indexOfX;
                            wall.YPos = indexOfY;
                            elements.Add(wall);
                            break;

                        case 'r':
                            var rat = new Rat();
                            rat.XPos = indexOfX;
                            rat.YPos = indexOfY;
                            elements.Add(rat);
                            break;

                        case 's':
                            var snake = new Snake();
                            snake.XPos = indexOfX;
                            snake.YPos = indexOfY;
                            elements.Add(snake);
                            break;
                    }
                    indexOfX++;
                }
                indexOfY++;
            }
        }
    }
}
