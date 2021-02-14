using System;

namespace GeneriscIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Zafer");
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
