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
                //Possible way to make it so would be !!!Enum!!!
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
                Console.WriteLine("Ggrid test");
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
                Console.WriteLine("Ugrid test");
            }
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