using System;
using FizzBuzz;

namespace FizBuzzConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzer = new FizzBuzzEngine(Console.Out, Rules.FizzRule, Rules.BuzzRule);
            fizzBuzzer.Run(15);            
            Console.ReadLine();
        }
    }
}
