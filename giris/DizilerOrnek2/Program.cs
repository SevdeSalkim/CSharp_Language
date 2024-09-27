using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizilerOrnek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 10 tane int değer alan ve şunları yapan programı kodlayınız...
            // 1- Kaç adet tek, çift eleman olduğunu
            // 2- Cift değerlerin toplamını Tek değerlerin toplamını
            // 3- Son olarak kontrol yapsın Cift değerlerin toplamı tek değerlerden büyükse Çift değerlerin toplamı büyüktür yazdırsın.
            // eğer teklerin toplamı büyükse > tek değerlerin toplamı büyüktür yazdırsın ...

            int[] sayilar = new int[10];

            int adetTek = 0;
            int adetCift = 0;

            int ciftToplam = 0;
            int tekToplam = 0;

            for (int i = 0; i < sayilar.Length; i++) {

                Console.Write("sayılar dizisinin " + (i + 1) + ". elemanını giriniz: ");
                int kullaniciDeğer = int.Parse(Console.ReadLine());
                sayilar[i] = kullaniciDeğer; // dizi içerisini kullanıcı değerleri ile doldurduk
            }

            for (int j = 0; j < sayilar.Length; j++)
            {
                if (sayilar[j] % 2 == 0)
                {
                    adetCift++;
                    ciftToplam += sayilar[j];

                }

                else { 
                    adetTek++; 
                    tekToplam += sayilar[j];
                
                }
            }
            Console.WriteLine("********************************");

            Console.WriteLine("Çift sayıların toplammı: " + ciftToplam);
            Console.WriteLine("cift sayıların adedi: " + adetCift);

            Console.WriteLine("********************************");

            Console.WriteLine("tek sayıların toplamı: " + tekToplam);
            Console.WriteLine("tek sayıların adedi: " + adetTek);
            Console.ReadLine();


        }
    }
}
