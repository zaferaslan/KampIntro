using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zafer Aslan
            //Musteri musteri1 = new Musteri();//instance
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Zafer";
            musteri1.Soyadi = "Aslan";
            musteri1.TcNo = "4321456789";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 1;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";


            //Gerçek Müşteri - Tüzel Müşteri
            //Solid

            Musteri musteri3 = new GercekMusteri(); 
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

     
        }
    }
}
