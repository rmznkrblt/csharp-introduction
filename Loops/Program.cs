using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=5,j;

            //while
            Console.WriteLine("--------------------while loop------------------");
            while (i>0)
            {
                if (i<3)
                    break;
                    Console.Write(i+" ");
                i--;
            }
            Console.WriteLine();

            i = 0;
            // do/while
            Console.WriteLine("--------------------do/while loop------------------");
            do
            {
                Console.Write(i + " ");
                i++;
            } while (i<5);
            Console.WriteLine();


            // for
            Console.WriteLine("--------------------for loop------------------");
            for (i = 0; i < 5; i++)
            {
                if (i==3)
                    continue;
                    Console.Write(i + " ");
            }
            Console.WriteLine();


            // foreach
            Console.WriteLine("--------------------foreach loop------------------");
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string car in cars)
            {
                Console.Write(car+" ");
            }
            Console.WriteLine();



            // nested loops
            Console.WriteLine("--------------------nested loops------------------");
            Console.WriteLine("--- for ---");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("--- while ---");
            i = 3;
            j = 3;
            while (i>0)
            {
                while (j>0)
                {
                    Console.Write("* ");
                    j--;
                }
                Console.WriteLine();
                j = 3;
                i--;
            }
        }
    }
}
