using System;

namespace METOTLAR
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Muz";
            urun1.Fiyat = 6.95;
            urun1.Aciklama = "yerli muz";

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 1.25;
            urun2.Aciklama = "Adana karpuzu";

            Urun urun3 = new Urun();
            urun3.Id = 3;
            urun3.Adi = "Elma";
            urun3.Fiyat = 4.95;
            urun3.Aciklama = "Amasya Elması";

            Urun[] urunListesi = new Urun[] { urun1, urun2, urun3 };

            foreach (Urun urun in urunListesi)
            {
                Console.WriteLine(urun.Id);
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------------------");
            }
            
            Console.WriteLine("----------METOTLAR------------");
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle2("Armut", "deveci", 12);
        }
    }
}


// Do not repeat yourself-DRY-clean code-best practice