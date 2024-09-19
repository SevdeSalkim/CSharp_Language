using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* öğrencinin notu 50 den büyükse başarılı değilse başarısız yazdıran program 

            int not = 75;

            if (not >= 50)
            {
                Console.WriteLine("Öğrencinin notu başarılıdır.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" Öğrencinin notu başarılı değildir.");
                Console.ReadLine();
            }
            */
            // kullanıcıdan 3 tane not alıcak notların ortalaması alınacak 


            Console.WriteLine("Lütfen 1. notu giriniz: ");
            int not1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 2. notu giriniz: ");
            int not2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 3. notu giriniz: ");
            int not3 = Convert.ToInt32(Console.ReadLine());


            int ortalama = (not1 + not2 + not3) / 3;

            if (ortalama > 80)
            {
                Console.WriteLine("Notu: A+");
                Console.ReadLine();
            }
            else if (ortalama > 60 && ortalama < 80)
            {
                Console.WriteLine("notu: A");
                Console.ReadLine();
            }
            else if (ortalama > 40 && ortalama < 60)
            {
                Console.WriteLine("Notu: B+");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Notu: F");
                Console.ReadLine();
            }














































        }
    }
}
