using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziOrnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcanın girdiği sayı dizinin içinde var mı? kontrol eden varsa kaç tane olduğunu söyleyen yoksa da yoktur diye uyaran 
            //programı kodlayınız.
            int[] sayilar = { 10, 10, 20, 30, 20, 30, 40, 50, 40, 50, 70, 55, 65, 78, 55, 65, 5, 20, 35, 65, 5, 20, 35, 65, 80 };
            int adet = 0;

            Console.WriteLine("Lütfen bir değer giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < sayilar.Length; i++) {

                if (number == sayilar[i]) {
                    adet++;
                }
            }
            if(adet == 0)
            {
                    Console.WriteLine("Seçmiş olduğunuz sayı dizinin içerisinde mevcut değildir...");
            }

            else
            {
                Console.WriteLine("Seçmiş olduğunuz sayı dizinin içerisinde mevcuttur");
                Console.WriteLine("Adet: " + adet);
            }
                Console.ReadLine();

        }
    }
}
