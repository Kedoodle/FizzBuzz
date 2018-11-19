using System;

namespace FizzBuzz {
    internal class Program {
        public static void Main(string[] args) {
            Console.Write("Input a positive integer to FizzBuzz: ");
            var input = Console.ReadLine();
            int n;
            while (!int.TryParse(input, out n) || n < 1) {
                Console.Write("Invalid input. Input a positive integer to FizzBuzz: ");
                input = Console.ReadLine();
            }
            var gen = new Generator();
            Console.WriteLine("Behold, FizzBuzz for {0}!", n);
            Console.WriteLine(gen.GenerateOutput(n));
        }
    }
}