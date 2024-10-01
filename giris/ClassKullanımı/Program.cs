using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba();

            araba1.arabaRengi = "kırmızı";
            araba1.arabaModeli = "toyota";
            araba1.kapiSayisi = 4;

            araba1.kapılarıKilitle();

            Console.WriteLine("Arabanın Rengi: " + araba1.arabaRengi);
            Console.WriteLine("Arabanın Modeli: " + araba1.arabaModeli);

            Console.ReadLine();
        }
    }
}
