using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry
{
    public static class TaskSet2
    {
        public static void PrintFromNumberToOne(int number) 
        {
            while (number > 0) 
            {
                Console.Write(number);
                number--;
            }
        }

        public static int Sum(int a, int b, int c, int d) 
        {
            return a + b + c + d;
        }

        public static int Reverse(int n) 
        {
            StringBuilder result = new();

            while (n > 0) 
            {
                result.Append(n % 10);
                n = n / 10;
            }

            return int.Parse(result.ToString());
        }

        public static void PrintStars(int n) 
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        public static void PrintSquare(int size) 
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void PrintRectangle(int width, int height) 
        {
            for (int i = 0; i < height; i++)
            {
                PrintStars(width);
            }
        }

        public static void PrintTriangle(int size) 
        {
            int count = 1;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                count++;
            }
        }

        public static void PrintSpaces(int number) 
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        public static void PrintRightTriangle(int size)
        {
            var counter = size-1;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j < counter) 
                    {
                        Console.Write(" ");
                        continue;
                    }
                    Console.Write("*");
                }
                counter--;
                Console.WriteLine();
            }
        }

        public static void Tree(int height) 
        {
            int mid = height;
            var starIndex = (mid, mid);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < (2 * height); j++)
                {
                    if (j >= starIndex.Item1 && j <= starIndex.Item2) 
                    {
                        Console.Write("*");
                        continue;
                    }
                    Console.Write(" ");
                }
                starIndex.Item1 -= 1;
                starIndex.Item2 += 1;
                Console.WriteLine();
            }
        }
    }
}
