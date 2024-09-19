using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Eşitliğin her iki tarafı da aynı tipte olmak zorunda.
            /* string tipinden int e dönüşüm yapmak için .parse methodu kullanılır.     Yada convert methodudun ToInt32 sınıfını kullanırız.


            string sayi1 = "1";
            string sayi2 = "2";

            //int a = int.Parse(sayi1);
            //int b = int.Parse(sayi2);
            
            int a = Convert.ToInt32(sayi1);
            int b = Convert.ToInt32(sayi2);
            
            Console.WriteLine(a + b);
            Console.ReadLine(); */


            /* İnt tipinden string tipine dönüşüm. ToString() methodu ile yapılır.

            int sayi1 = 5; int sayi2 = 125;

            string a = sayi1.ToString();
            string b = sayi2.ToString();

            Console.WriteLine(a + b);
            Console.ReadLine(); */ 
             // !!! Kullanıcıdan alınan tüm değerler STRİNG OLARAK GELİRRR!!!
        }
    }
}
