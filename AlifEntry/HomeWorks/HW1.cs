namespace AlifEntry.HomeWorks
{
    static class HW1
    {
        enum Operations
        {
            Plus,
            Multiply
        }
        public static void Task1()
        {
            string? input = Console.ReadLine();
            int max = int.MinValue;

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Empty input");
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

        public static void Task2()
        {
            string? input = Console.ReadLine();
            double sum = 1;

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Empty input");
                return;
            }

            var values = input.Split(" ");

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

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Empty input");
                return;
            }

            var values = input.Split(" ");

            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] == "0" && values[i - 1] == "0")
                {
                    break;
                }
                if (int.TryParse(values[i - 1], out int result))
                {
                    sum += result;
                }
            }
            Console.WriteLine(sum);
        }

        public static void Task4()
        {
            string? input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Empty input");
                return;
            }

            var values = input.Split(" ");

            if (values.Length <= 1)
            {
                Console.WriteLine("Wrong input");
                return;
            }

            for (int i = 1; i < values.Length; i++)
            {
                if (values[i].Contains("-") && values[i - 1].Contains("-")
                    || !values[i].Contains("-") && !values[i - 1].Contains("-"))
                {
                    Console.WriteLine("YES");
                    return;
                }
            }
            Console.WriteLine("NO");
        }

        public static void Task5()
        {
            int len;

            if (int.TryParse(Console.ReadLine(), out int res))
            {
                len = res;
            }
            else
            {
                Console.WriteLine("Wrong input");
                return;
            }

            string? input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Empty input");
                return;
            }

            var numbers = input.Split(" ");

            Dictionary<int, int> apperiances = new();

            foreach (var number in numbers)
            {
                if (int.TryParse(number, out int result))
                {
                    if (!apperiances.Keys.Contains(result))
                    {
                        apperiances.Add(result, 1);
                        continue;
                    }

                    apperiances[result] += 1;
                }
            }

            foreach (var apperience in apperiances)
            {
                if (apperience.Value == 1)
                {
                    continue;
                }

                for (int i = 0; i < apperience.Value; i++)
                {
                    Console.Write(apperience.Key + " ");
                }
            }
        }

        public static void Task6()
        {
            string? input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Empty input");
                return;
            }

            var numbers = input.Split(" ");
            var min = int.MaxValue;

            foreach (var number in numbers)
            {
                if (int.TryParse(number, out int result) && result < min)
                {
                    min = result;
                }
            }

            var output = min == int.MaxValue ? "Wrong input" : $"Min is {min}";
            Console.WriteLine(output);
        }
        public static void Task7()
        {
            int count = 0;
            int sum = 0;

            while (true)
            {
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

        public static void Task8()
        {
            var inp = string.Concat(Console.ReadLine().Reverse());

            if (int.TryParse(inp, out int result))
            {
                displayData(result, Operations.Plus);
                displayData(result, Operations.Multiply);
                return;
            }
            Console.WriteLine("Wrong input");
        }

        public static void Task9()
        {
            var inp = Console.ReadLine();

            if (int.TryParse(inp, out _))
            {
                for (int i = inp.Length - 1; i >= 0; i--)
                {
                    Console.Write(inp[i]);
                }
                return;
            }
            Console.WriteLine("Wrong input");
        }

        public static void Task10()
        {
            int len;

            if (int.TryParse(Console.ReadLine(), out int res))
            {
                len = res;
            }
            else
            {
                Console.WriteLine("Wrong input");
                return;
            }

            string? input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Empty input");
                return;
            }

            var numbers = input.Split(" ");

            foreach (var number in numbers)
            {
                if (int.TryParse(number, out int result) && !IsPrimeNumber(result))
                {
                    Console.Write($"{result} ");
                }
            }
        }

        private static bool IsPrimeNumber(int n)
        {
            if (n <= 1)
            {
                return false;
            }

            if (n <= 3)
            {
                return true;
            }

            if (n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }

            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static void displayData(int result, Operations operation)
        {
            int sum = 0;
            int product = 1;

            switch (operation)
            {
                case Operations.Plus:
                    while (result > 0)
                    {
                        Console.Write(result % 10);
                        if (result > 10)
                        {
                            Console.Write("+");
                        }
                        sum += result % 10;
                        result = result / 10;
                    }
                    Console.WriteLine("=" + sum);
                    break;

                case Operations.Multiply:
                    while (result > 0)
                    {
                        Console.Write(result % 10);
                        if (result > 10)
                        {
                            Console.Write("*");
                        }
                        product *= result % 10;
                        result = result / 10;
                    }
                    Console.WriteLine("=" + product);
                    break;
            }
        }
    }
}
