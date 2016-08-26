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
            ValidateInput(startValue, endingValue);

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

        private static void ValidateInput(int startValue, int endingValue)
        {
            if (startValue < 1) throw new ApplicationException("Start value can not be less than 1");
            if (startValue >= endingValue) throw new ApplicationException("Start value must be less than ending value");
            if (endingValue > 1000000) throw new ApplicationException("Ending value can not be greater than 1000000");
            if (endingValue - startValue > 1000) throw new ApplicationException("Maximum number of outputs is 1000");
        }
    }
}
