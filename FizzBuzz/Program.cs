using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        private const int MinimumValue = 1;
        private const int MaximumValue = 1000000;
        private const int MaximumNumberOfOutputs = 1000;

        static void Main(string[] args)
        {
            var fizzBuzzValues = GenerateFizzBuzzValues(0, 30);
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
            if (startValue < MinimumValue) throw new ApplicationException(string.Format("Start value can not be less than {0}", MinimumValue));
            if (startValue >= endingValue) throw new ApplicationException("Start value must be less than ending value");
            if (endingValue > MaximumValue) throw new ApplicationException(string.Format("Ending value can not be greater than {0}", MaximumValue));
            if (endingValue - startValue > MaximumNumberOfOutputs) throw new ApplicationException(string.Format("Maximum number of outputs is {0}", MaximumNumberOfOutputs));
        }
    }
}
