using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzValues = GenerateFizzBuzzValues(1, 100);
            foreach (var value in fizzBuzzValues)
            {
                Console.WriteLine(value);
            }
        }

        private static List<string> GenerateFizzBuzzValues(int startValue, int endingValue)
        {
            List<string> fizzBuzzValues = new List<string>();

            for (int i = startValue; i <= endingValue; i++)
            {
                if (i % 15 == 0)
                {
                    fizzBuzzValues.Add("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    fizzBuzzValues.Add("Buzz");
                }
                else if (i % 3 == 0)
                {
                    fizzBuzzValues.Add("Fizz");
                }
                else
                {
                    fizzBuzzValues.Add(i.ToString());
                }
            }

            return fizzBuzzValues;
        }
    }
}
