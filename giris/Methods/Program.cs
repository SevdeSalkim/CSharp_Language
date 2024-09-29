using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // parametresiz ve geriye değer döndürmeyen metot 
            // AdYazdir(); 

            // parametre alan - geriye değer döndürmeyen metot  
            // toplama(12, 31);

            // parametre alan - geriye değer döndüren metot
            /*int donenDeger = toplamaYap(12, 5);

            if (donenDeger > 10)
            {
                Console.WriteLine("toplanan değer 10 dan büyüktür.");
            }
            else {
                Console.WriteLine("toplanan değer 10 dan küçüktür.");
            }
            Console.ReadLine();*/

            string name = nameReturn("sevde", "salkim");

            Console.WriteLine(name);
            Console.ReadLine();


        }
        // parametresiz ve geriye değer döndürmeyen metot  

        static void AdYazdir() {

            Console.Write("Lütfen Adınızı giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.ReadLine(); 

        }
        // parametre alan - geriye değer döndürmeyen metot  

        static void toplama(int sayi1, int sayi2)
        {
            Console.WriteLine("Gönderilen sayıların toplamı: " + (sayi1 + sayi2));
            Console.ReadLine();

        }

        // parametre alan - geriye değer döndüren metot

        static int toplamaYap(int sayi1, int sayi2)
        {
            int sonuc = sayi2 + sayi1;

            return sonuc;


        }

        static string nameReturn(string name, string surname)
        {
            return name + " " + surname;

        }
    }
}
