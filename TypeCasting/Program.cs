using System;

namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Automatic casting:
            int myInt = 9;
            double myDouble = myInt;

            Console.WriteLine(myInt);      
            Console.WriteLine(myDouble);

            // Manual casting:
            double myDouble2 = 9.78;
            int myInt2 = (int)myDouble;   

            Console.WriteLine(myDouble2);
            Console.WriteLine(myInt2);   
        }
    }
}
