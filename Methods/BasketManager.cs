using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
     class BasketManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete Eklendi." + product.Adi);
        }
        
    }
}
