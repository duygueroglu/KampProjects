using System;

namespace HomeworkProducts
{
    class Product
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public float productPrice { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.productId = 1;
            product1.productName = "Phone";
            product1.productPrice = 3400;

            Product product2 = new Product();
            product2.productId = 2;
            product2.productName = "Televizyon";
            product2.productPrice = 5000;

            Product[] productList = new Product[] { product1, product2 };

            Console.WriteLine("---With for loop---");
            for(int i = 0; i < productList.Length; i++)
            {
                Console.WriteLine(productList[i].productId + " " +
                    productList[i].productName + " " +
                    productList[i].productPrice);
            }

            Console.WriteLine();
            Console.WriteLine("---With foreach loop---");
            foreach(var product in productList)
            {
                Console.WriteLine(product.productId + " " +
                    product.productName + " " +
                    product.productPrice);
            }

            Console.WriteLine();
            Console.WriteLine("---With while loop---");
            int counter = 0;
            while (counter < productList.Length)
            {
                Console.WriteLine(productList[counter].productId + " " +
                   productList[counter].productName + " " +
                   productList[counter].productPrice);
                counter++;
            }
        }
    }
}
