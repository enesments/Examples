using System;

namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////int,decimal,float,enum,boolean value types

            //int sayi1 = 10;
            //int sayi2 = 20;
            //sayi1 = sayi2;
            //sayi2 = 100;
            //Console.WriteLine("Sayi 1 :" + sayi1);

            //// arrays,class,interface... reference types
            //int[] sayilar1 = new int[] {1,2,3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };
            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;
            //Console.WriteLine("Sayilar1[0] : "+ sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Ekrem";
            person2 = person1;
            person1.FirstName = "Enes";
            Console.WriteLine(person2.FirstName);

            Customer customer1 = new Customer();
            customer1.FirstName = "Emre";
            customer1.CreditCardNumbber = "1234567895"; 

            Employee employee1 = new Employee();
            employee1.FirstName = "Kadir";

            Person person3 = customer1;
            customer1.FirstName = "Ayşe";


            //Console.WriteLine(((Customer)person3).CreditCardNumbber);

            PersonManager personManager = new PersonManager();
            personManager.Add(customer1);



        }

    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person
    {
        public string CreditCardNumbber { get; set; }
    }
    class Employee:Person   
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
