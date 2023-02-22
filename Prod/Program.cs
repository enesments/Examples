using System;

namespace Prod
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Urunler k1 = new Urunler();
            k1.Turu = "Tişört";
            k1.Mıktarı = 5;
            k1.SatıldıgıYer = "Amazon";
            k1.Rengi = "Beyaz";
            Urunler k2 = new Urunler();
            k2.Turu = "Kazak ";
            k2.Mıktarı = 7;
            k2.SatıldıgıYer = "Hepsiburada";
            k2.Rengi = "Yeşil"; 
            Urunler k3 = new Urunler();
            k3.Turu = "Pantolon";
            k3.Mıktarı = 2;
            k3.SatıldıgıYer = "Trendyol";
            k3.Rengi = "Siyah";

            Urunler[] urunlers = new Urunler[] {k1,k2,k3};
            foreach (var urun in urunlers )
            {
                Console.WriteLine("Urun Turu:" + urun.Turu + " Urun Mıktarı:" + urun.Mıktarı + " Satıldığı Yer:" + urun.SatıldıgıYer + " Urun Rengi:" + urun.Rengi);

            }
            Console.WriteLine(" Foreach bitti ");


            for (int i = 0; i < urunlers.Length ; i++)
            {
                Console.WriteLine("Urun Turu:" + urunlers[i].Turu + " Urun Mıktarı:" + urunlers[i].Mıktarı + " Satıldığı Yer:" + urunlers[i].SatıldıgıYer + " Urun Rengi:" + urunlers[i].Rengi);
            }
            Console.WriteLine(" For bitti ");

            int a = 0;
            while (a < urunlers.Length)
            {

                Console.WriteLine("Urun Turu:" + urunlers[a].Turu + " Urun Mıktarı:" + urunlers[a].Mıktarı + " Satıldığı Yer:" + urunlers[a].SatıldıgıYer + " Urun Rengi:" + urunlers[a].Rengi);
                a++;
            }
            Console.WriteLine(" While bitti ");


        }
    }
    class Urunler
    {
        public String Turu { get; set; }
        public String Rengi { get; set; }
        public string SatıldıgıYer { get; set; }
        public int Mıktarı { get; set; }
       
    }
}
