using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry.HomeWorks
{
    public static class HW3
    {
        //Task1
        public static int EvenCount(int n)
        {
            return n.ToString().Select(x => int.Parse(x.ToString())).Where(x => x % 2 == 0 && x != 0).Count();
        }

        public static int OddCount(int n)
        {
            return n.ToString().Select(x => int.Parse(x.ToString())).Where(x => x % 2 != 0 && x != 0).Count();
        }

        public static int DigitCount(int n)
        {
            return n.ToString().Trim().Length;
        }

        public static int SumDigit(int n)
        {
            return n.ToString().Select(x => int.Parse(x.ToString())).Sum();
        }

        //Task2
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Division(int a, int b)
        {
            return a / b;
        }

        //Task3
        public static int MinDigit(int n) 
        {
            return n.ToString().Select(x => int.Parse(x.ToString())).ToArray().Min();
        }

        public static int MaxDigit(int n)
        {
            return n.ToString().Select(x => int.Parse(x.ToString())).ToArray().Max();
        }

        //Task4
        public static int Pow(int x, int y) 
        {
            if (x == 0 || x == 1) 
            {
                return x;
            } 

            int res = 1;

            for (int i = 0; i < y; i++)
            {
                res *= x;
            }
            return res;
        }

        //Task5 
        public static void Swap(ref int a, ref int b) 
        {
            int temp = a;
            a = b;
            b = temp;
        }

        //Task6
        public static void Divisors(int number) 
        {
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0) 
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }

        //Task7
        public static void IncrementArrayElements(ref int[] arr, int val) 
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += val;
            }
        }

        //Task8
        public static int MinNumber(params int[] arr)
        {
            return arr.Min();
        }

        //Task9
        public static int Min(int val1, int val2)
        {
            return val1 < val2 ? val1 : val2;
        }

        //Task10
        public static int Max(int val1, int val2)
        {
            return val1 > val2 ? val1 : val2;
        }
    }
}
