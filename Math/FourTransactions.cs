using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    internal class FourTransactions
    {
        public void Addition(int number1, int number2)
        {
            int add = number1 + number2;
            Console.WriteLine(add);

        }
        public void Multiply(int number1, int number2)
        {
            int mul = number1 * number2;
            Console.WriteLine(mul);
        }
        public void Subtraction(int number1, int number2)
        {
            int sub = number1 - number2;  
            Console.WriteLine(sub);
        }
        public void Division(int number1, int number2)
        {
            int div = number1 / number2;
            Console.WriteLine(div); 
        }
    }
}
