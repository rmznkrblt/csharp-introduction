using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 30;
            int y = 10;
            int z;
            int a = 30;

            //Operators
            Console.WriteLine("-----------------Operators---------------------");
            Console.WriteLine("x:"+x+" y:" + y);
            Console.WriteLine("x + y:"+(x+y)); //Addition
            Console.WriteLine("x - y:" + (x -y)); //Subtraction
            Console.WriteLine("x * y:" + x * y); //Multiplication
            Console.WriteLine("x / y:" + x / y); //Division
            Console.WriteLine("x % y:" + x % y); //Modulus
            Console.WriteLine("++x:" + ++x + " ++y:" + ++y + " x++:" + x++ +" y++:"+ y++); //Increment
            Console.WriteLine("--x:" + --x + " --y:" + --y + " x--:" + x-- +" y--:"+ y--); //Decrement

            //Assignment Operators
            Console.WriteLine("-----------------Assignment Operators---------------------");
            z = 60;
            Console.WriteLine("z:" + z + " y:" + y);
            
            z += y;  //x = x + y; 
            Console.WriteLine("z += y   =>z:" + z);
            
            z -= y;  //x = x - y;
            Console.WriteLine("z -= y   =>z:" + z);
            
            z *= y;  //x = x * y;
            Console.WriteLine("z *= y   =>z:" + z);

            z /= y;  //x = x / y;
            Console.WriteLine("z /= y   =>z:" + z);
            
            z %= y;  //x = x & y;
            Console.WriteLine("z %= y   =>z:" + z);

            z &= y;  //x = x & y;
            Console.WriteLine("z &= y   =>z:" + z);

            z |= y;  //x = x | y;
            Console.WriteLine("z |= y   =>z:" + z);

            z ^= y;  //x = x ^ y;
            Console.WriteLine("z ^= y   =>z:" + z);

            z >>= y; //x = x >> y;
            Console.WriteLine("z >>= y  =>z:" + z);

            z <<= y; // x = x << y;
            Console.WriteLine("z <<= y  =>z:" + z);


            //Comparison Operators
            Console.WriteLine("-----------------Comparison Operators---------------------");

            Console.WriteLine("x:"+ x + " y:" + y+ " a:" + a);
            if (x==a)
                Console.WriteLine("x Equal to a"); 
            if(x!=y)
                Console.WriteLine("x Not equal y");
            if (x > y)
                Console.WriteLine("x Greater than y");
            if (y < x)
                Console.WriteLine("y Less than x");
            if (x >= y)
                Console.WriteLine("x Greater than or equal to y");
            if (y <= x)
                Console.WriteLine("y Less than or equal to x");

            //Logical Operators
            Console.WriteLine("-----------------Logical Operators---------------------");
            Console.WriteLine("x:"+x);
            if (x < 60 && x > 20) //Logical and
                Console.WriteLine("x < 60 and x > 20");
            if (x < 60 || x > 40) //	Logical or
                Console.WriteLine("x < 60 or x > 40");
            if (!(x < 20 && x > 40)) //Logical not
                Console.WriteLine("!(x < 20 and x > 40)");
        }
    }
}
