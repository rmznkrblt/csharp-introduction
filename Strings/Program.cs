using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Product newProduct = new Product();
            Product newProduct2 = new Product();
            Product newProduct3 = new Product();

            newProduct.productId = 1;
            newProduct.productName = "LG Televizyon";
            newProduct.productAmount = 3;
            newProduct.productPrice = 3400;
            newProduct.productDescription = "4K";

            newProduct2.productId = 2;
            newProduct2.productName = "Samsung Televizyon";
            newProduct2.productAmount = 5;
            newProduct2.productPrice = 7200;
            newProduct2.productDescription = "HD";

            newProduct3.productId = 3;
            newProduct3.productName = "Vestel Televizyon";
            newProduct3.productAmount = 1;
            newProduct3.productPrice = 4000;
            newProduct3.productDescription = "blu ray";

            Product[] product = new Product[] { newProduct, newProduct2, newProduct3 };
            int length = product.Length;
            int i = 0;

            Console.WriteLine("-------------------while-----------------");

            while (i<length)
            {
                Console.WriteLine((i+1)+". Ürün :");
                Console.WriteLine("Product name: " + product[i].productName);
                Console.WriteLine("Product amount: " + product[i].productAmount);
                Console.WriteLine("Product price: " + product[i].productPrice);
                Console.WriteLine("Product description: " + product[i].productDescription);
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("-------------------for-----------------");
            for (i=0; i<product.Length;i++)
            {
                Console.WriteLine((i + 1) + ". Ürün :");
                Console.WriteLine("Product name: " + product[i].productName);
                Console.WriteLine("Product amount: " + product[i].productAmount);
                Console.WriteLine("Product price: " + product[i].productPrice);
                Console.WriteLine("Product description: " + product[i].productDescription);
            }
            Console.WriteLine();
            Console.WriteLine("-------------------foreach-----------------");
            i = 1;
            foreach (var pr in product)
            {
                Console.WriteLine(i + ". Ürün :");
                Console.WriteLine("Product name: " + pr.productName);
                Console.WriteLine("Product amount: " + pr.productAmount);
                Console.WriteLine("Product price: " + pr.productPrice);
                Console.WriteLine(" Product description: " + pr.productDescription);
                i++;
            }
        }
    }
}
