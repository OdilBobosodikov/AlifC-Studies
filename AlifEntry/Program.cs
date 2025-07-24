using System;

namespace AlifEntry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task7();
            //Task8();
            Task9();
        }

        static void Task1()
        {
            string? input = Console.ReadLine();
            int max = int.MinValue;

            if (input == null)
            {
                return;
            }

            foreach (var num in input.Split(" "))
            {
                if (num == "0")
                {
                    break;
                }

                if (int.TryParse(num, out int result) && result > max)
                {
                    max = result;
                }
            }

            var output = max == int.MinValue ? "Wrong input" : $"Max is {max}";
            Console.WriteLine(output);
        }

        static void Task2() 
        {
            string? input = Console.ReadLine();
            double sum = 1;

            
            var values = input?.Split(" ");

            if (values.Length != 2 || !int.TryParse(values[0], out _) || !int.TryParse(values[1], out _))
            {
                Console.WriteLine("Wrong input");
                return;
            }

            var val = (int.Parse(values[0]), int.Parse(values[1]));

            for (int i = 1; i <= val.Item2; i++)
            {
                sum += Math.Pow(val.Item1, i);
            }

            Console.WriteLine(sum);
        }

        public static void Task3() 
        {
            string? input = Console.ReadLine();
            double sum = 0;

            var values = input?.Split(" ");

            for (int i = 1; i < values?.Length; i++)
            {
                if (values[i] == "0" && values[i - 1] == "0") 
                {
                    break;
                }
                if (int.TryParse(values[i-1], out int result))
                {
                    sum += result;
                }
            }
            Console.WriteLine(sum);
        }

        public static void Task7() 
        {
            int count = 0;
            int sum = 0;

            while (true) {
                Console.WriteLine("Give a number:");
                Console.Write("> ");
                var inp = Console.ReadLine();

                if (inp == "0")
                {
                    break;
                }

                if (int.TryParse(inp, out int result))
                {
                    sum += result;
                    count++;
                }
            }

            Console.WriteLine($"Sum of numbers: {sum}");
            Console.WriteLine($"Count of numbers: {count}");
        }

        static void Task8() 
        {
            var inp = Console.ReadLine();
            int sum = 0;
            int product = 1;

            if (int.TryParse(inp, out int result))
            {
               while (result > 0) 
               {
                  sum += result % 10;
                  product *= result % 10;
                  result = result / 10;
               }
               Console.WriteLine($"Sum is {sum}");
               Console.WriteLine($"Product is {product}");
            }
        }

        static void Task9()
        {
            var inp = Console.ReadLine();

            if (int.TryParse(inp, out _))
            {
                for (int i = inp.Length -1; i >= 0; i--)
                {
                    Console.Write(inp[i]);
                }
            }
        }
    }
}
