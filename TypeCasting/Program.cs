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

            int i = 75;
            float f = 53.005f;
            double d = 2345.7652;
            bool b = true;

            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(b.ToString());
        }
    }
}
