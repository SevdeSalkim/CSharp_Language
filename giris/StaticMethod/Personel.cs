using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    public class Personel
    {
        public static void isimYazdir() {
            Console.WriteLine("Sevde Salkım");

        }

        public static void toplamYazdir(int sayi1, int sayi2) {
            Console.WriteLine("iki sayının toplamı : " + (sayi1 + sayi2));
            
        }
    }
}
