using System;

namespace FibonacciRecursivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibo CalculoFibonacci = new Fibo();
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < numero; i++)
            {
                var soma = CalculoFibonacci.Fibonacci(i);
                System.Console.WriteLine($"{i} => {soma}");
            }
            Console.ReadLine();
        }
    }
}
//O(n)