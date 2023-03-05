using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class RequirementCreditManager : ICreditBaseManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi hesaplandı.");
        }
    }
}
