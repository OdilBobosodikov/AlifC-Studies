using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry
{
    public class TaskSet2
    {

        public static bool isSignEqual(int a, int b) 
        {
            return a * b >= 0;
        }

        public static int MidDigit(int num) 
        {
            var arr = num.ToString().Select(x => int.Parse(x.ToString())).ToArray();
            return arr[arr.Length % 2 == 0 ? (arr.Length - 1) / 2 : arr.Length / 2];
        }

        public static bool IsPalindromeRecurcy(string str) 
        {
            if (str.Length <= 1) 
            {
                return true;
            }
            if (str[0] != str[str.Length-1])
            {
                return false;
            }

            return IsPalindromeRecurcy(str.Substring(1, str.Length-2));
        }

        public static int RecurcySum(int val) 
        {
            if (val <= 0) 
            {
                return val;
            }

            var lastDigit = val % 10;
            return lastDigit + RecurcySum(lastDigit / 10);
        }

        public static string RecursyInverse(string str) 
        {
            if (string.IsNullOrEmpty(str)) 
            {
                return "";
            }
            return str[str.Length - 1] + RecursyInverse(str.Substring(0, str.Length - 1));
        }

        public static int RecurcyPower(int value, int exponent) 
        {
            if (exponent == 1) 
            {
                return value;
            }

            return value * RecurcyPower(value, exponent - 1);
        }

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
