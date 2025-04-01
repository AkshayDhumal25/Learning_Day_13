//Find the missing number from the array
//using System;
//using System.Linq;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
//            int n = arr.Max();
//            int realSum = n * (n + 1) / 2;
//            int currentSum = 0;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                currentSum += arr[i];
//            }

//            Console.WriteLine(realSum - currentSum);

//        }
//    }
//}

// find second largest element from the array;
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int[] array = { 1, 2, 4, 0, 3 };
//            int secLarge = 0;
//            int large = 0;
//            for (int i = 0; i < array.Length; i++)
//            {
//                if (array[i] > large)
//                {
//                    secLarge = large;
//                    large = array[i];
//                }
//                if (array[i] < large && array[i] > secLarge)
//                {
//                    secLarge = array[i];
//                }
//            }
//            Console.WriteLine(secLarge);
//        }
//    }
//}


// 2. WAP to reverse an integer without converting it to a string, without using any built-in methods.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int n = 123;
//            int reversed = 0;
//            while (n > 0)
//            {
//                int reminder = n % 10;
//                reversed = reversed * 10 + reminder;
//                n = n / 10;
//            }
//            Console.WriteLine($"{reversed}");
//        }
//    }
//}


// 2. Swap Values without using any variable a=10, b=12.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int a = 10;
//            int b = 12;

//            a = a + b;
//            b = a - b;
//            a = a - b;
//            Console.WriteLine($"A: {a} and B: {b}");
//        }
//    }
//}


// 3. Logic for anagram program with its time complexity. (for large strings).
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            string str1 = "listen";
//            string str2 = "silemt";

//            if (isAnagram(str1, str2))
//            {
//                Console.WriteLine("Anagram");
//            }
//            else
//            {
//                Console.WriteLine("Not Anagram");
//            }
//        }
//        public static bool isAnagram(string str1, string str2)
//        {
//            if (str1.Length != str2.Length)
//            {
//                return false;
//            }
//            int[] array = new int[256];
//            for (int i = 0; i < str1.Length; i++)
//            {
//                array[str1[i]]++;
//                array[str2[i]]--;
//            }
//            foreach (int i in array)
//            {
//                if (i != 0)
//                {
//                    return false;
//                }
//            }
//            return true;

//        }
//    }
//}

// 4. Find the reverse of the string.
//using System;
//using System.Linq;
//using System.Collections.Generic;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            string str = "Akshay";
//            var reversed = str.Reverse().ToArray();
//            reversed.ToString();
//            Console.WriteLine(reversed);
//        }
//    }
//}

//Enum
using System;
namespace enums
{

    public enum shippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        public static void Main(string[] args)
        {
            var Method = shippingMethod.Express;
            Console.WriteLine((int)Method);
        }
    }
}