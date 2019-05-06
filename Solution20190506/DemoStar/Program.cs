using System;

namespace DemoStar
{
    class Program
    {
        static int row = 10, col = 9;

        static void Main(string[] args)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if ((i + j) == col)
                    {
                        Console.Write("*");
                    } else
                    {
                        Console.Write(" ");
                    }

                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
