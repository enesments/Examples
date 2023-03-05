using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RealCustomer customer1 = new RealCustomer();
            customer1.CustomerNumber = "12345";
            customer1.Name = "Enes";
            customer1.Surname = "Menteşe";
            customer1.IdNumber = "456";
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "543210";
            customer2.CompanyName = "EkoCompany";
            customer2.TaxNumber = "78945";

            Customer customer3 = new RealCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);




        }
    }
}
