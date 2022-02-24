using P129HomeWork3.Enums;
using P129HomeWork3.Models;
using System;

namespace P129HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mehsulun Adini Daxil Et:");
            string name = Console.ReadLine();

            Console.WriteLine("Mehsulun Qiymetini Daxil");
            string strPrice = Console.ReadLine();
            double price = double.Parse(strPrice);

            Console.WriteLine("Mehsulun Novunu Sec:");
            foreach (var item in Enum.GetValues(typeof(ProductType)))
            {
                Console.WriteLine($"{(int)item} {item}");
            }
            int productTypeNum = int.Parse(Console.ReadLine());

            ProductType productType = (ProductType)productTypeNum;

            Product product = new Product(name, price, productType);
        }
    }
}
