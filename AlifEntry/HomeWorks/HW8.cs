namespace AlifEntry.HomeWorks
{
    record class Person(int age, string name);

    internal class HW8
    {
        public static int SumOfElements(List<int> vals) 
        {
            return vals.Sum();
        }

        public static List<string> SortDescByleangth(List<string> words) 
        {
            return words.OrderByDescending(line => line.Length).ToList();
        }

        public static List<Person> SortPeople(List<Person> people)
        {
            return people.OrderByDescending(x => x.age).ToList();
        }

        public static void DelteteOdd(ref List<int> numbers) 
        {
            numbers.RemoveAll(n => n % 2 != 0 && n != 0);
        }

        public static void ConvertToUpper(ref List<string> lines) 
        {
            lines = lines.Select(line => line.ToUpper()).ToList();
        }

        public static int MaxOf(List<int> val) => val.Max();
        public static int MinOf(List<int> val) => val.Min();

        public static List<string> ContainsUniqueChars(List<string> val) 
        {
            return val.Where(x => x.Distinct().Count() == x.Length).ToList();
        }

        public static double AverageAge(List<Person> people)
        {
            return people.Average(x => x.age);
        }

        public static List<int> UniqueInts(List<int> vals) => vals.Distinct().ToList();

        public static List<string> PalindromeStrings(List<string> vals) 
        {
            return vals.Where(x => x.Equals(x.Reverse())).ToList();
        }

        public static List<Person> GetSpecificValue(List<Person> people, Person template) 
        {
            return people.Where(x => x.age == template.age && x.name == template.name).ToList();
        }

        public static string CombineList(List<string> vals) => string.Join(";", vals);

        public static int SumOfOddIndeces(List<int> vals) 
        {
            return vals
            .Where((_, index) => index % 2 != 0)
            .Sum();
        }

        public static string LongestString(List<string> vals) 
        {
            return vals
            .OrderByDescending(line => line.Length)
            .First();
        }

        public static List<Person> SortByName(List<Person> people) => people.OrderBy(x => x.name).ToList();

        public static List<(int, int)> PairsSumThatMake(int target, List<int> values)
        {
            List<(int, int)> result = new();

            for (int i = 0; i < values.Count; i++)
            {
                for (int j = i + 1; j < values.Count; j++)
                {
                    if (values[i] + values[j] == target)
                    {
                        result.Add((i, j));
                    }
                }
            }

            return result;
        }

        public static List<Person> AgeIsAboveAverage(List<Person> people) 
        {
            var average = people.Average(x => x.age);
            return people.Where(x => x.age > average).ToList();
        }

        public static void RemoveElementThatHas(string target, ref List<string> vals) 
        {
            vals.RemoveAll(x => x.ToLower().Contains(target.ToLower()));
        }

        public static List<int> ConvertToAbsoluteValues(List<int> vals) 
        {
            return vals.Select(Math.Abs).ToList();
        }

        public static List<List<Person>> GroupByAge(List<Person> people) 
        {
           return people
            .GroupBy(x => x.age)
            .Select(group => group.ToList())
            .ToList();
        }
    }
}
