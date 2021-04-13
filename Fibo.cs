namespace FibonacciRecursivo
{
    public class Fibo
    {
        private int somatorio;
        public int Fibonacci(int n)
        {
            if (n > 1)
            {
                somatorio = Fibonacci(n - 1) + Fibonacci(n - 2);
                return somatorio;
            }
            else return n;
        }
    }
}
