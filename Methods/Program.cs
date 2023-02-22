  using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Kulaklık";
            product1.Fiyati = 1500;
            product1.Aciklama = "Kablosuz";
            Product product2 = new Product();
            product2.Adi = "Monitor";
            product2.Fiyati = 2500;
            product2.Aciklama = "LCD";
            Product product3 = new Product();
            product3.Adi = "Adaptör";
            product3.Fiyati = 1550;
            product3.Aciklama = "1 metre";

            Product[] products = new Product[] { product1, product2, product3 };

            foreach (var uruns in products)
            {
                Console.WriteLine(uruns.Adi);
                Console.WriteLine(uruns.Fiyati);
                Console.WriteLine(uruns.Aciklama);
                Console.WriteLine("-------------");

            }
            Console.WriteLine("----------METHODS---------");
            //Encapsulatıon
            BasketManager basketManager = new BasketManager();
            basketManager.Ekle(product1);
            basketManager.Ekle(product2);
            basketManager.Ekle(product3);


        }
    }
}""
