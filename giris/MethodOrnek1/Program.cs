using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOrnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan aldığımız səyinin karesini alalım eğer karesi 25 'ten büyükse;
            // karesi 25 ten büyüktür
            // değilse 25 'ten küçüktür yazdırsın.


            Console.Write("Lütfen bir sayı giriniz.");

            int sayi = int.Parse(Console.ReadLine());

            int kareDeger = kareAl(sayi);

            if(kareDeger > 25)
            {
                Console.WriteLine("Girilen sayının karesi 25 ten büyüktür.");
            }
            else
            {
                Console.WriteLine("Girilen sayının karesi 25ten küçüktür");
            }
            Console.ReadLine(); 

        }

        static int kareAl(int i) {
            return i * i;
        }
    }
}
