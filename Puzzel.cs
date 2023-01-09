using System;
using Raylib_cs;
namespace Nonogram
{
    public class Puzzel
    {



        public Puzzel()
        {
            Image o = Raylib.LoadImage("Resources/WhiteTile.png");
            Image I = Raylib.LoadImage("Resources/BlackTile.png");
            {
            Console.WriteLine("Hello from Puzzel!");

                //2D multidimensional array (2x3)
                int[ , ] x = new int [2, 3]{ {0, 0, 0}, {0, 0, 0,}};

            /*
             for (int y = 0; y < numOfCells; ++y)
             {
                g.DrawLine(p, 0, y * cellSize, numOfCells * cellSize, y * cellSize);
             }

            for (int x = 0; x < numOfCells; ++x)
             {
                g.DrawLine(p, x * cellSize, 0, x * cellSize, numOfCells * cellSize);
             }

                //Example of a multidimentional array (2x3)
                //To be used for loading the tile images
                int[ , ] x = new int [2, 3]{ {0, 0, 0}, {0, 0, 0,}};

            */
            }
        }
    }

}
