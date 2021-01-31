using System;
using System.Collections.Generic;
using System.Text;

namespace METOTLAR
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi: " + urun.Adi);
        }


        public void Ekle2(string urunAdi, string acıklama,double fiyat) 
        {
            Console.WriteLine("Sepete eklendi. "+ urunAdi);
        }       
    }
}
