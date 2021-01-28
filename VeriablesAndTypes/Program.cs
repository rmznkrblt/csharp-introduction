using System;

namespace VeriablesAndTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number4 = 5;
            double doubleNumber = 5.99D;
            char letter = 'D';
            bool myBool = true;
            string text = "Hello";
            Console.WriteLine(number4);
            Console.WriteLine(doubleNumber);
            Console.WriteLine(letter);
            Console.WriteLine(myBool);
            Console.WriteLine(text);
            int number = 2;

            int number2;
            number2 = 3; //Bu şekilde de değer ataması yapılabilir.

            const int number3 = 3; //Sabit bir değişken tanımlaması.

            Console.WriteLine(number); // Console.WriteLine(); bizim ekrana değer yazdırma komutumuz.() içerisine yazılan değerleri ekrana yazdırır.
            Console.WriteLine(number2);
            Console.WriteLine(number3);
        }
    }
}
