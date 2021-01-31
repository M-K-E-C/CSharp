using System;

namespace DONGULER
{
    class Program
    {
        static void Main(string[] args)
        {
            // array-dizi
            string[] kurslar = new string[] { "yazılım geliştirici yetitirme kursu", "programlamaya giriş için temel kurs", "Java" };
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
        }
    
    }

}
