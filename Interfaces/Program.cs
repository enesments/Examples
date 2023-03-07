using System;
using System.Runtime.Intrinsics.Arm;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PersonManager personManager = new PersonManager();
            //personManager.Add(new Customer { Id = 1, FirstName = "Enes", LastName = "Mentese", Adress = "İstanbul" });

            //Student student = new Student() { Id = 1, FirstName = "Ekrem", LastName= "Mentese", Department = "Software"};
            //personManager.Add(student);

            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new SqlServerCustomerDal());
            //customerManager.Add(new OracleServerCustomerDal());

            ICustomerDal[] customerDals = new ICustomerDal[2] { 
                new SqlServerCustomerDal(), 
                new OracleServerCustomerDal() 
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadLine();
        }
    }
    interface IPerson
    { 
         int Id { get; set; }
        string FirstName { get; set; }
        
        string LastName { get; set; }

    }
    class Customer : IPerson
    {
        public int Id { get ; set; }
        public string FirstName { get; set ; }
        public string LastName { get ; set; }
        public string Adress { get; set; }
    }
    class Student : IPerson 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
    }
