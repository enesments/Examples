using System;

namespace Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            FourTransactions fourTransactions = new FourTransactions();
            fourTransactions.Addition(8, 9);
            fourTransactions.Multiply(10, 11);
            fourTransactions.Division(10, 5);
            fourTransactions.Subtraction(8, 9);
        }
    }
}
