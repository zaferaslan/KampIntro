using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{   //İş yapan classım
    class PrdocutManager //Ürünle ilgili operasyonlar var eğer service ve manager görürsen böyle bil
    {   
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName +" eklendi");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi");
        }

        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1+sayi2);
        }
    }
}
