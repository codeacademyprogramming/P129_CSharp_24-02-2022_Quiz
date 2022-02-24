using System;
using P129HomeWork2.Extentions;

namespace P129HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 8;
            Console.WriteLine(a.IsEven());
            Console.WriteLine(a.IsOdd());

            int[] arr = { 5, 7, 15, 7, 12, 7 };
            int b = 7;

            foreach (int item in arr.GetValueIndexes(b))
            {
                Console.WriteLine(item);
            }

            string test = "Sal423am123";
            Console.WriteLine(test.IsContainsDigit());

            foreach (int item in test.GetValueIndexes('a'))
            {
                Console.WriteLine(item);
            }
        }
    }
}
