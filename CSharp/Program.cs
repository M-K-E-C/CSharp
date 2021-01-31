using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmısMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarBugun>dolarDun)
            {
                Console.WriteLine("artış butonu");
            }
            else if (dolarBugun<dolarDun)
            {
                Console.WriteLine("azalış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }
            if (sistemeGirisYapmısMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(ogrenciSayisi);
            Console.WriteLine(faizOranı);
        }
    }
}
