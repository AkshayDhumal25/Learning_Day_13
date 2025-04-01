//Find the missing number from the array
using System;
using System.Linq;
namespace logicals
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int n = arr.Max();
            int realSum = n * (n + 1) / 2;
            int currentSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                currentSum += arr[i];
            }

            Console.WriteLine(realSum - currentSum);

        }
    }
}