using System;
using System.Linq;

namespace ValueAndReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result = Add2(5,9);
            //Console.WriteLine(result);
            //Console.ReadLine();
            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(number1, number2);
            //var result3 = Add4(out number1, number2);
            //Console.WriteLine(number1);
            //Console.WriteLine(result2);
            //Console.WriteLine("Out Type = "+ result3);
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Add5(1,2,3,4));
        
            Console.ReadLine();

        }
        static void Add()
        {
            Console.WriteLine("Added!");
        }
        static int Add2(int number1, int number2)
        {
            var result = number1+ number2;   
            return result;
        }
        static int Add3(int number1,int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        static int Add4(out int   number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2,int number3) //Overloalding
        {
            return number1 * number2 * number3;
        }
        static int Add5(params int[] numbers) // Params Structure
        {
            return numbers.Sum();
        }
    } 
}