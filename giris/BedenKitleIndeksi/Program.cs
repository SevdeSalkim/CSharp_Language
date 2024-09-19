using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedenKitleIndeksi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Beden Kitle İndeksi Kilo / boy*boy
            // Beden kitle indeksi 18 'e eşit veya düşükse ZAYIF
            // 18 ile 25 arasındaysa NORMAL
            // 25 ten büyükse OBEZ yazdıran program parçasını kodlayınız.

            Console.WriteLine("Lütfen boyunuzu giriniz: ");
            double boy = Double.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen kilonuzu giriniz: ");
            int kilo = Convert.ToInt32(Console.ReadLine());

            double kitle_indeksi = kilo / (boy * boy);


            if (kitle_indeksi <= 18)
            {
                Console.WriteLine("Bedden kitle indeksiniz: ZAYIF");
                Console.ReadLine();
            }
            else if (kitle_indeksi > 18 && kitle_indeksi < 25)
            {
                Console.WriteLine("Bedden kitle indeksiniz: NORMAL");
                Console.ReadLine();
            } 

            else{
                Console.WriteLine("Bedden kitle indeksiniz: OBEZ");
                Console.ReadLine();
            }


        }
    }
}
