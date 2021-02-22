using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //interface ile de aynı soucu aldık 
            //interface onu impelemnte eden classın referansını tutabilir 
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();  
            IKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager);
            

            Console.ReadLine();
        }
    }
}
