using System;
using System.Collections.Generic;
using System.Text;

namespace P129HomeWork2.Extentions
{
    static class ExtentionMethods
    {
        public static bool IsEven(this int num)
        {
            return num % 2 == 0;
        }

        public static int[] GetValueIndexes(this int[] arr, int num)
        {
            int[] newArr = new int[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    Array.Resize(ref newArr, newArr.Length + 1);
                    newArr[newArr.Length - 1] = i;
                }
            }

            return newArr;
        }

        public static bool IsOdd(this int num)
        {
            return num % 2 == 1;
        }

        public static bool IsContainsDigit(this string str)
        {
            foreach (char item in str)
            {
                if (char.IsDigit(item))
                {
                    return true;
                }
            }

            return false;
        }

        public static int[] GetValueIndexes(this string str, char letter)
        {
            int[] newArr = new int[0];

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == letter)
                {
                    Array.Resize(ref newArr, newArr.Length + 1);
                    newArr[newArr.Length - 1] = i;
                }
            }

            return newArr;
        }
    }
}
