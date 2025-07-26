using AlifEntry.HomeWorks;
using System;
using System.Linq;
using System.Numerics;

namespace AlifEntry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HW3.EvenCount(12345));
            Console.WriteLine(HW3.OddCount(12345));
            Console.WriteLine(HW3.DigitCount(12345));
            Console.WriteLine(HW3.SumDigit(12345));
            Console.WriteLine(HW3.MinDigit(12345));
            Console.WriteLine(HW3.MaxDigit(12345));
            Console.WriteLine(HW3.Pow(2, 3));

            int x = 10;
            int y = 20;

            Console.WriteLine($"Before Swap: x = {x}, y = {y}");
            HW3.Swap(ref x, ref y);
            Console.WriteLine($"After Swap: x = {x}, y = {y}");

            HW3.Divisors(8);

            int[] arr = new int[] { 1, 2, 3 };
            HW3.IncrementArrayElements(ref arr, 5);
            
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Console.WriteLine(HW3.MinNumber(1,2,3,-1));

            Console.WriteLine(HW3.Min(1,2));
            Console.WriteLine(HW3.Max(1,2));
        }

        static void ReferenceTypeCopyingExample() 
        {
            var val = new List<int>() { 1, 2, 3, 4, 5 };

            Console.Write("We have: ");
            val.ForEach(x => Console.Write(x + " "));
            Console.Write("values");

            Console.WriteLine();

            var copied = val;
            copied.Clear();

            Console.WriteLine($"After copying values by refference and clearing new variable we have {val.Count} values");
        }

        static int RecursyExample(int n) 
        {
            Console.WriteLine(n);
            if (n <= 0) 
            {
                return 0;
            }
            return RecursyExample(n-1);
        }
    }
}
