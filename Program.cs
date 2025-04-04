﻿//Find the missing number from the array
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
//using System;
//namespace enums
//{

//    public enum shippingMethod
//    {
//        RegularAirMail = 1,
//        RegisteredAirMail = 2,
//        Express = 3
//    }
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            var Method = shippingMethod.Express;
//            Console.WriteLine((int)Method);
//        }
//    }
//}

//Encapsulation
//using System;
//using System.Linq;
//namespace encapsulation
//{
//    class rectangleArea
//    {
//        private double length;
//        private double width;

//        public double Length
//        {
//            get { return length; }
//            set
//            {
//                length = value;
//            }
//        }
//        public double Width
//        {
//            get { return width; }
//            set
//            {
//                width = value;
//            }
//        }
//        public double getArea()
//        {
//            return length * width;
//        }

//        public void print()
//        {
//            Console.WriteLine($"Length : {length} and Width : {width} ");
//            Console.WriteLine("Area : " + getArea());
//        }
//    }
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            rectangleArea r = new rectangleArea();
//            r.Length = 9.0;
//            r.Width = 9.0;
//            r.print();
//        }
//    }
//}

//Lambda Function
//using System;
//namespace lambdaFunction
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Func<int, int> square = x => x * x;
//            Console.WriteLine(square(5));
//        }
//    }
//}

//Solution of the Diamond Problem
//using System;
//namespace diamondProblem
//{
//    interface IA
//    {
//        public void print()
//        {
//            Console.WriteLine("Interface IA");
//        }
//    }
//    interface IB : IA { }
//    interface IC : IA { }
//    class D : IB, IC
//    {
//        public void print()
//        {
//            Console.WriteLine("Class D");
//        }
//    }
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            D d = new D();
//            d.print();
//        }
//    }
//}


// 5. WAP to find missing elements from the array?
//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int[] array = { 1, 3, 4, 6, 7, 8, 9, 10 };
//            int max = array.Max();
//            int min = array.Min();
//            var list = new List<int>(array);
//            for (int i = min; i <= max; i++)
//            {
//                if (!list.Contains(i))
//                {
//                    Console.WriteLine(i + " ");
//                }
//            }
//        }
//    }
//}


// 6. WAP to find the given string is Palindrome or not.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            string str = "abba";
//            if (isPalindrome(str))
//            {
//                Console.WriteLine("Palindrome");
//            }
//            else
//            {
//                Console.WriteLine("Not Palindrome");
//            }
//        }

//        public static bool isPalindrome(string str)
//        {
//            int left = 0;
//            int right = str.Length - 1;
//            while (left < right)
//            {
//                if (str[left] != str[right])
//                {
//                    return false;
//                }
//                left++;
//                right--;
//            }
//            return true;
//        }
//    }
//}

// 7. WAP to print Fibonacci series with recursion.
//using System;
//namespace logicals
//{
//    class Progra
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Fibonacci Series with Recursion");
//            Console.WriteLine("Enter the number to get the fibonacci series: ");
//            int n = Convert.ToInt32(Console.ReadLine());
//            for (int i = 0; i < n; i++)
//            {
//                Console.WriteLine(fibo(i));
//            }
//        }
//        public static int fibo(int n)
//        {
//            if (n <= 1)
//            {
//                return n;
//            }

//            return fibo(n - 1) + fibo(n - 2);
//        }
//    }
//}


// 14. [80, 60, 10, 50, 30, 100, 0, 50]
// Find pairs whose sum = 100;
// Logic for above problem?
// What will be the complexity for it?
// Any better solution for the above problem?
//using System;
//using System.Collections.Generic;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int[] array = { 80, 60, 10, 50, 30, 100, 0, 50 };
//            int targetSum = 100;
//            var list = new List<int>(array);
//            for (int i = 0; i < array.Length; i++)
//            {
//                int complement = targetSum - array[i];
//                if (list.Contains(complement))
//                {
//                    Console.WriteLine($"{complement} : {array[i]}");
//                }

//            }
//        }
//    }
//}


//Encapsulation
//using System;
//namespace encapsulation
//{
//    class rectangleArea
//    {
//        private double length;
//        private double width;

//        public double Length
//        {
//            get { return length; }
//            set { length = value; }
//        }
//        public double Width
//        {
//            get { return width; }
//            set { width = value; }
//        }
//        public double getArea()
//        {
//            return length * width;
//        }

//        public void print()
//        {
//            Console.WriteLine($"Length : {length} and Width : {width}");
//            Console.WriteLine("Area : " + getArea());
//        }
//    }
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            rectangleArea r = new rectangleArea();
//            r.Length = 9.0;
//            r.Width = 9.0;
//            r.print();
//        }
//    }
//}


//Abstraction
//using System;
//namespace abstraction
//{
//    abstract class Person
//    {
//        public abstract void name();
//    }
//    class details : Person
//    {
//        public override void name()
//        {
//            Console.WriteLine("Hello");
//        }
//    }
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            details d = new details();
//            d.name();
//        }
//    }
//}

//Generics
using System;
namespace generics
{
    class Person
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st Element : ");
            var a = Console.ReadLine();
            Console.WriteLine("Enter the 2nd Element : ");
            var b = Console.ReadLine();
            swap(ref a, ref b);
            Console.WriteLine($"A: {a} and B: {b}");
        }

        public static void swap<T>(ref T a, ref T b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
    }
}