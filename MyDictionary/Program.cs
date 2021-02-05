using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDict<int, string> sozluk = new MyDict<int, string>();
            sozluk.Add(1, "bir");
            sozluk.Add(2, "iki");
            sozluk.Add(3, "üç");

            




            Console.WriteLine("Hello World!");
        }
    }
}
