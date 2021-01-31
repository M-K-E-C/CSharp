using System;

namespace DONGULER
{
    class Program
    {
        static void Main(string[] args)
        {
            // array-dizi
            // diz tanımlarken önce dizinin veri tipi(string,int..)[] sonra ismi sonra "=" sonra "new string,int.." [] {}
            string[] kurslar = new string[] { "yazılım geliştirici yetitirme kursu", "programlamaya giriş için temel kurs", "Java"};
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }
            int[] sayilar = new int[] { 1, 3, 5, 7, 9, 11, 13 };
            foreach (int i in sayilar)
            {
                Console.WriteLine(i);
            }
        }
    }
}
