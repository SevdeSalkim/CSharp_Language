using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTahmin
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int randomSayi = random.Next(1, 101);
            int tahmin = 0;
            int tahminSayisi = 0;
            bool dogruTahmin = false;

            Console.WriteLine("1 ile 100 arası sayı tahmin oyunumuza hoşgeldiniz");

            while (!dogruTahmin)
            {
                Console.Write("Lütfen tahmininizi girin: ");
                tahmin = Int32.Parse(Console.ReadLine());
                tahminSayisi++;

                if (tahmin < randomSayi)
                {
                    Console.WriteLine("Lütfen daha büyük bir sayı tahmini yapınız");

                }
                else if (tahmin > randomSayi)
                {
                    Console.WriteLine("Daha Küçük bir sayı tahmini yapınız");
                }
                else if (tahmin == randomSayi)
                {
                    Console.WriteLine($"Tebrikler! {tahminSayisi} denemede doğru tahmini buldunuz.");
                    dogruTahmin = true;
                }

            }
        }
    }
}
