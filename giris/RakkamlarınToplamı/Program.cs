using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RakkamlarınToplamı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen en az iki basamaklı bir Sayı Giriniz: "); // kullanıcıdan giriş alındı

            int rakam = int.Parse(Console.ReadLine()); // girilen sayıya tip dönüşümü yapıldı.

            int toplam  = 0, r; // r: Her döngüde sayının son basamağını tutacak. 


            while (rakam != 0) // toplam 0 olmadığı sürece döngü çalışır.
            {
                r = rakam % 10; // % 10 işlemi, bir sayının son basamağını verir.
                rakam = rakam / 10; // Sayıyı 10’a bölerek bir basamağını atar
                toplam = toplam  + r; 

            }

            Console.WriteLine("Sayının Rakamlarının Toplamı : " + toplam);
            Console.ReadLine();



        }
    }
}
