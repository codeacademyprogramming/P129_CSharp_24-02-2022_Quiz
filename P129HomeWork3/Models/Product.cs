using System;
using System.Collections.Generic;
using System.Text;
using P129HomeWork3.Enums;

namespace P129HomeWork3.Models
{
    class Product
    {
        public static int Count = 1000;
        public readonly string Code;
        public ProductType ProductType { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountPrice { get; set; }
        public static int TotalCount = 0;

        public Product(string name, double price, ProductType productType)
        {
            Name = name;
            Price = price;
            ProductType = productType;
            Count++;
            TotalCount++;
            Code = productType.ToString()[0] + "" + Count;
            DiscountPrice = productType == ProductType.Bakery ? Price - (Price * 0.1) : 0;

            //switch (productType)
            //{
            //    case ProductType.Bakery:
            //        Code = $"B{Count}";
            //        DiscountPrice = Price - (Price * 0.1);
            //        break;
            //    case ProductType.Drink:
            //        Code = $"D{Count}";
            //        break;
            //    case ProductType.Meat:
            //        Code = $"M{Count}";
            //        break;
            //    case ProductType.Fish:
            //        Code = $"F{Count}";
            //        break;
            //    default:
            //        break;
            //}

        }
    }
}
