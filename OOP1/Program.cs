using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 10;
            product1.ProductName = "Sandalye";
            product1.UnitsInStock = 30;
            product1.UnitPrice = 660;

            Product product2 = new Product { Id =20, CategoryId=10,UnitsInStock=50,ProductName="Kagıt",UnitPrice =40};

            //PascalCase   //CamelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
