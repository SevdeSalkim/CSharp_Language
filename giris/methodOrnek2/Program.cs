using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOrnek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz: ");

            int girilenSayi = int.Parse(Console.ReadLine());

            tekmiCiftmi(girilenSayi);

            Console.ReadLine();

        }

        static void tekmiCiftmi(int sayi)
        {
            if (sayi %2 == 0)
            {
                Console.WriteLine("Girilen sayı çifttir");
            }
            else{
                Console.WriteLine("Girilen sayı tektir.");
                
            }
        }
    }
}
