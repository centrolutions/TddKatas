using System;
using TddKatas.FizzBuzz;

namespace TddKatas
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzer = new FizzBuzzer();
            Console.WriteLine(string.Join("\r\n", fizzBuzzer.ExecuteForRange(1, 100)));
        }
    }
}
