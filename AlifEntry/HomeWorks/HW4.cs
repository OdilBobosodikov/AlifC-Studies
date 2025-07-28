using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry.HomeWorks
{
    class HW4
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
        public static int ZeroCount(int n)
        {
            return n.ToString().Select(x => int.Parse(x.ToString())).Where(x => x == 0).Count();
        }
        public static int MinDigit(int n)
        {
            return n.ToString().Select(x => int.Parse(x.ToString())).ToArray().Min();
        }
        public static int MaxDigit(int n)
        {
            return n.ToString().Select(x => int.Parse(x.ToString())).ToArray().Max();
        }

        public static void PrintStatus(int number)
        {
            Console.WriteLine($"Even : {EvenCount(number)}");
            Console.WriteLine($"Odd : {OddCount(number)}");
            Console.WriteLine($"Zeros : {ZeroCount(number)}");
            Console.WriteLine($"Digits : {DigitCount(number)}");
            Console.WriteLine($"Min : {MinDigit(number)}");
            Console.WriteLine($"Max : {MaxDigit(number)}");
            Console.WriteLine($"Sum of Digits: {SumDigit(number)}");
        }

        //TAsk2
        public static char CheckGrade(int grade)
        {
            if (grade >= 90 && grade <= 100)
            {
                return 'A';
            }
            else if (grade >= 80 && grade <= 89)
            {
                return 'B';
            }
            else if (grade >= 70 && grade <= 79)
            {
                return 'C';
            }
            else if (grade >= 60 && grade <= 69)
            {
                return 'D';
            }

            return 'F';
        }

        //Task3 
        public static void PrintNumberStatus()
        {
            var l = Console.ReadLine();

            if (string.IsNullOrEmpty(l) || !int.TryParse(l, out _)) 
            {
                Console.WriteLine("Wrong input");
                return;
            }

            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input)) 
            {
                Console.WriteLine("Empty input");
                return;
            }

            PrintData(
                input.Split(" ")
                .Where(x => int.TryParse(x.ToString(), out _))
                .Select(x => int.Parse(x))
                .ToArray()
                );
        }

        private static void PrintData(int[] numbers)
        {
            int negativeCount = numbers.Count(x => x < 0);
            int positiveCount = numbers.Count(x => x > 0);
            int zeroCount = numbers.Count(x => x == 0);
            int evenCount = numbers.Count(x => x % 2 == 0);
            int oddCount = numbers.Count(x => x % 2 != 0);
            int max = numbers.Max();
            int min = numbers.Min();
            var sumOfDigits = numbers
                .Select(n => Math.Abs(n).ToString())
                .SelectMany(s => s.ToCharArray())
                .Select(char.GetNumericValue).Sum();


            Console.WriteLine($"Negative = {negativeCount}");
            Console.WriteLine($"Positive = {positiveCount}");
            Console.WriteLine($"Zeros = {zeroCount}");
            Console.WriteLine($"Even = {evenCount}");
            Console.WriteLine($"Odd = {oddCount}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Sum of Digits = {sumOfDigits}");
        }

       
        //Task4
        public static void PrintEvenIndexes() 
        {
            var l = Console.ReadLine();

            if (string.IsNullOrEmpty(l) || !int.TryParse(l, out _))
            {
                Console.WriteLine("Wrong input");
                return;
            }

            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Empty input");
                return;
            }

            var number = input.Split(" ")
                .Where(x => int.TryParse(x.ToString(), out _))
                .Select(x => int.Parse(x))
                .ToArray();

            for (int i = 0; i < input.Length; i+=2) 
            {
                if (i < number.Length) 
                {
                    Console.Write($"{number[i]} ");
                }
            }
        }

        //Task5
        public static int PrintEvenIndexes(int[] arr) 
        {
            int counter = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1]) 
                {
                    counter++;
                }
            }
            return counter;
        }

        //Task6
        public static string RepetativeNumbers(int[] numbers)
        {
            Dictionary<int, int> apperiances = new();
            StringBuilder sb = new StringBuilder();

            foreach (var number in numbers)
            {
                if (!apperiances.Keys.Contains(number))
                {
                    apperiances.Add(number, 1);
                    continue;
                }

                apperiances[number] += 1;
            }

            foreach (var apperience in apperiances)
            {
                if (apperience.Value == 1)
                {
                    continue;
                }

                for (int i = 0; i < apperience.Value; i++)
                {
                    sb.Append(apperience.Key + " ");
                }
            }

            return sb.ToString();
        }

        //Task7
        public static void PrintMultiTable(int from, int to)
        {
            int num = 10;

            for (int i = from; i <= to; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine("--------------------------\n");
            }
        }

        //Task8
        public static void Calc() 
        {
            Console.Write("The first number is: ");
            var a = Console.ReadLine();

            Console.Write("The first number is: ");
            var operation = Console.ReadLine();

            Console.Write("The second number is: ");
            var b = Console.ReadLine();

            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(a)
                || !int.TryParse(a, out int resA) || !int.TryParse(b, out int resB))
            {
                Console.WriteLine("Wrong input");
                return;
            }

            switch (operation) 
            {
                case "+":
                    Console.WriteLine($"{resA} + {resB} = {Sum(resA, resB)}");
                    break;

                case "-":
                    Console.WriteLine($"{resA} - {resB} = {Subtract(resA, resB)}");
                    break;

                case "*":
                    Console.WriteLine($"{resA} * {resB} = {Multiplication(resA, resB)}");
                    break;

                case "/":
                    Console.WriteLine($"{resA} / {resB} = {Division(resA, resB)}");
                    break;

                default:
                    Console.WriteLine("Wrong operation");
                    break;
            }
        }

        private static int Sum(int a, int b)
        {
            return a + b;
        }

        private static int Subtract(int a, int b)
        {
            return a - b;
        }

        private static int Multiplication(int a, int b)
        {
            return a * b;
        }

        private static int Division(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль!");
                return 0;
            }
            return a / b;
        }

        //Task9
        public static int RecurcyPower(int value, int exponent)
        {
            if (exponent == 1)
            {
                return value;
            }

            return value * RecurcyPower(value, exponent - 1);
        }

        //Task10
        private static int Fibonnachi(int n, bool printData = false)
        {
            if (n <= 1)
            {
                return n;
            }

            return Fibonnachi(n - 1, true) + Fibonnachi(n - 2);
        }

        public static void PrintFibonnachiSequance(int n)
        {
            if (n == 0)
            {
                return;
            }
            Console.Write($"{Fibonnachi(n)} ");
            PrintFibonnachiSequance(n - 1);
        }
    }
}
