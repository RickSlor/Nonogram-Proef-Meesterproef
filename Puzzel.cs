using System;
using Raylib_cs;
namespace Nonogram
{
    public class Puzzel
    {



        public Puzzel()
        {
            /*
            Image o = Raylib.LoadImage("Resources/WhiteTile.png");
            Image I = Raylib.LoadImage("Resources/BlackTile.png");
            */
            {
            Console.WriteLine("Hello from Puzzel!");

                //2D multidimensional array (2x3)
                int[ , ] x = new int [10, 10]
                {
                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                    {0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0},
                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
                };
            }
        }
    }

}
