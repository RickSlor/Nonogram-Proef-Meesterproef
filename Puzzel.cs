using System;
using Raylib_cs;
namespace Nonogram
{
    public class Puzzel
    {



        public Puzzel()
        {
            {
            Console.WriteLine("Hello from Puzzel!");

                //2D multidimensional array (10x10) "Generated grid"
                int[ , ] Ggrid = new int [10, 10]
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

                //2D multidimensional array (10x10) "User grid"
                int[ , ] Ugrid = new int [10, 10]
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
/*
Random random = new Random();
int[ , ] numbers = new int[5,5];
//populating 2D Array
for (int m = 0; m < 5 ; m++)
{
    for (int n = 0; n < 5 ; n++)
    {
        numbers[m,n] = random.Next(0, 25);
    }
}
*/
            }
        }
    }

}
