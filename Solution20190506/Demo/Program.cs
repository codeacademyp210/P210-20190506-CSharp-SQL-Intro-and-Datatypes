using System;

namespace Demo
{
    class Program
    {
        int row = 10, column = 10;


        static void Main(string[] args)
        {
            Program p = new Program();

            for (int i = 0; i < p.row; i++)
            {
                if (i == 0 || i == (p.row - 1))
                {
                    for (int j = 0; j < p.column; j++)
                    {
                        Console.Write("#");
                    }
                }
                else
                {
                    string a = "";
                    a += "#";
                    for (int j = 1; j < p.row - 1; j++)
                    {
                        if (i == j || (i + j) == 9)
                        {
                            a += "#";
                        }
                        else
                        {
                            a += " ";
                        }
                    }
                    a += "#";
                    Console.Write(a);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
