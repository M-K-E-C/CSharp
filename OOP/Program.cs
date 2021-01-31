using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyackrediManager = new IhtiyacKrediManager();

            

            TasıtKrediManager tasıtKrediManager = new TasıtKrediManager();
            

            IKrediManager konutKrediManager = new KonutKrediManager();


            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyackrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyackrediManager,tasıtKrediManager};

            basvuruManager.KrediOnbilgilendirmesiYap(krediler);
        }
    }
}
