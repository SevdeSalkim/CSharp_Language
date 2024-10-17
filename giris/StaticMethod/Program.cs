using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Personel.isimYazdir();
            // Personel.toplamYazdir(5, 8);

            Calisan C1 = new Calisan();

            C1.calisanID = 1;
            C1.isim = "Sevde";
            C1.soyisim = "Salkım";

            Calisan.maas = 25000;

            Console.WriteLine("Çalışanın ID: " + C1.calisanID);
            Console.WriteLine("Çalışan İsim: " + C1.isim + " " + C1.soyisim);
            Console.WriteLine("Çalışan Maaşı: " + Calisan.maas);
            Console.ReadLine();
        }
    }
}
