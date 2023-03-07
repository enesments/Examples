using System;

namespace Interfaces2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // IPersonManager customerManager = new CustomerManager();
           // customerManager.Add();
           // customerManager.Update();
            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();
            //employeeManager.Update();
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add( new InternManager()); 
           

        }
    }
   interface IPersonManager
    {
        void Add();
        void Update();  
        

    }
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Musteri eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Musteri guncellendi.");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Personel guncellendi.");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer guncellendi.");
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            
            personManager.Add();
        }
      
    }
}
