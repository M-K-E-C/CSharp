using System;

namespace Genericsİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Musa");
            isimler.Add("Elif");
            foreach ( MyList a in isimler)
            {

            }

            Console.WriteLine("Hello World!");
        }
    }
}
