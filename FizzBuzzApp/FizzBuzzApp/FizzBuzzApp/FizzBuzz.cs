using System;
using System.Collections.Generic;

namespace FizzBuzzApp
{
    public class FizzBuzz
    {
        public static List<string> ProcessFizzBuzz(List<string> inputs)
        {
            List<string> results = new List<string>();

            foreach (var input in inputs)
            {
                if (int.TryParse(input, out int number))
                {
                    if (number % 3 == 0 && number % 5 == 0)
                    {
                        results.Add("FizzBuzz");
                    }
                    else if (number % 3 == 0)
                    {
                        results.Add("Fizz");
                    }
                    else if (number % 5 == 0)
                    {
                        results.Add("Buzz");
                    }
                    else
                    {
                        results.Add($"Divided {number} by 3");
                        results.Add($"Divided {number} by 5");
                    }
                }
                else
                {
                    results.Add("Invalid item");
                }
            }

            return results;
        }

        public static void DisplayResults(List<string> results)
        {
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}