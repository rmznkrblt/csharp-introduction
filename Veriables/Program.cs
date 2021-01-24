using System;

namespace Veriables
{
    class Program
    {
        static void Main(string[] args)
        {
            // type variableName = value;
            // int bir veri tipidir. Bu ve bunu gibi veri tiplerini DataTypes(Veri tip) projesinde anlatıyor olacağım.
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
