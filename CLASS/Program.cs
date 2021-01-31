using System;

namespace CLASS
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Musa";
            int yas = 30;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Eğitmen = "Musa Kazım COŞKUN";
            kurs1.İzlenmeOrani = 83;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Eğitmen = "ELİF";
            kurs2.İzlenmeOrani = 86;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Pyton";
            kurs3.Eğitmen = "Aybike";
            kurs3.İzlenmeOrani = 45;

            //Console.WriteLine(kurs1.KursAdi + " " +kurs1.Eğitmen);

            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3};

            foreach (Kurs i in kurslar)
            {
                Console.WriteLine(i.KursAdi);
            }
            
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }

        public string Eğitmen{ get; set; }

        public int İzlenmeOrani { get; set; }
    }

    
    

    
}
