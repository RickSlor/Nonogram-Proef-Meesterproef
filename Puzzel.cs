using System;
using System.Numerics;
using Raylib_cs;
namespace Nonogram
{
    public class Puzzel
    {
        const int screenWidth = 1280;
        const int screenHeight = 720;
        
        Texture2D textureI;
        Texture2D textureO;

        Texture2D textureX;

        int[ , ] Ggrid;
        int[ , ] Ugrid;

        public Puzzel()
        {
            Raylib.InitWindow(screenWidth, screenHeight, "Nonogram");
            Raylib.SetTargetFPS(60);               // Set our game to run at 60 frames-per-second

            Raylib.SetWindowState(ConfigFlags.FLAG_WINDOW_RESIZABLE);

            textureI = Raylib.LoadTexture("Resources/BlackTile.png");
            textureO = Raylib.LoadTexture("Resources/WhiteTile.png");
            textureX = Raylib.LoadTexture("Resources/XTile.png");

            Console.WriteLine("Hello from Puzzel!");
            //Possible way to make it so would be !!!Enum!!!
            //2D multidimensional array (10x10) "Generated grid"
            Ggrid = new int [10, 10]
            {
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                {0, 0, 0, 0, 1, 0, 0, 0, 0, 1},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                {0, 0, 1, 0, 0, 0, 0, 0, 0, 1},
                {0, 0, 0, 0, 0, 1, 0, 0, 0, 1},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 1}
            };
            Console.WriteLine("Ggrid test");
            //2D multidimensional array (10x10) "User grid"
            Ugrid = new int [10, 10]
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            };
            Console.WriteLine("Ugrid test");
        }

        public void HandlePuzzel()
        {
            // Raylib.DrawTexture(textureI, screenWidth/2 - textureI.width/2, screenHeight/2 - textureI.height/2 - 40, Color.RAYWHITE);
            // Raylib.DrawTexture(textureI, screenWidth/2 - textureI.width/2, screenHeight/2 - textureI.height/2 - 150, Color.RAYWHITE);
            // Raylib.DrawTexture(textureO, screenWidth/2 - textureO.width/2, screenHeight/2 - textureO.height/2 - 80, Color.RAYWHITE);

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    int offset = 0;
                    int xpos = x * 15 + offset;
                    int ypos = y * 15 + offset;

                    if (Ggrid[y,x] == 0)
                    {
                        Raylib.DrawTexture(textureI, xpos, ypos, Color.RAYWHITE);
                    }

                     else if (Ggrid[y,x] == 2)
                    {
                        Raylib.DrawTexture(textureX, xpos, ypos, Color.RAYWHITE);
                    }

                    else
                    {
                        Raylib.DrawTexture(textureO, xpos, ypos, Color.RAYWHITE);
                    }
                }
            }


            if (Raylib.IsMouseButtonPressed(0))
            {
                // Console.WriteLine("mouse 0");
                Vector2 indexpos = Raylib.GetMousePosition() / 15;
                int x = (int)indexpos.X;
                int y = (int)indexpos.Y;
                Console.WriteLine(x + ", " + y);

                if (Ggrid[y,x] == 0)
                {
                    Ggrid[y,x] = 1;
                }

                    else if (Ggrid[y,x] == 1)
                    {
                    Ggrid[y,x] = 2;
                    }
            }

        }

        public void Close() {
            Raylib.UnloadTexture(textureI);
            Raylib.UnloadTexture(textureO);
            Raylib.UnloadTexture(textureX);
        }
    }
}
/*
public class arrayFiller
{
// random integer returned can include this value
private const int randMinimum = 0;
private const int randMaximum = 2;

private const int no_of_rows = 10;
private const int no_of_columns = 10;

// fancy way of getting more randomness than you will probably ever need
private Random random = new Random(Guid.NewGuid().GetHashCode());

private int[ , ] numbers = new int[ no_of_rows , no_of_columns ];

// populating 2D Array        
for (int row = 0; row < no_of_rows; row++)
{
    for (int column = 0; column < no_of_columns; column++)
    {
        numbers[row, column] = random.Next(randMinimum, randMaximum);
    }
}
*/