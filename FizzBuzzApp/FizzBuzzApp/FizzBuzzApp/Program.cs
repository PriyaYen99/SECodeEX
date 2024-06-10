using System;
using System.Collections.Generic;

namespace FizzBuzzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputs = new List<string> { "1", "3", "5", "", "15", "A", "23" };
            List<string> results = FizzBuzz.ProcessFizzBuzz(inputs);
            FizzBuzz.DisplayResults(results);
        }
    }
}