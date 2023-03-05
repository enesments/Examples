using System;
using System.ComponentModel.DataAnnotations;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName= "Enes",LastName="Mentese" ,City="İstabul"};

            Customer customer3 = new Customer();
            customer3.Id = 3;
            Customer customer2 = new Customer (2, "Ekrem", "Mentese", "Ankara" );
        }
       
    }
    class Customer
    {
        //default constructor
        public Customer()
        {
           
        }
        public Customer(int id,string firstname,string lastname,string city)
        {

            FirstName = firstname;
            LastName = lastname;
            City = city;
            Id = id;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
