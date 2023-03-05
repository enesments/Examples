using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class CarCreditManager : ICreditBaseManager
    {
        public void Calculate()
        {
            Console.WriteLine("Araba kredisi hesaplandı.");
        }
    }
}
