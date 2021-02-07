using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun(); //Bir class tanımlamak için bu hareket  Class'ın örneği
            urun1.Adi = "Elma";
            urun1.Fiyatı = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyatı = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type-safe--> tip güvenliği
            foreach (Urun urun in urunler) //in urunler->ürünler dizindeki her bir elemanı gezsin
            {                              //urun->o anki dönen x de olur Urun-> Veri tipi var yazsan da olur
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyatı);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------");


            }
            Console.WriteLine("******Metotlar*******");

            //Encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 5, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);



            Console.ReadLine();
        }
    }
}
