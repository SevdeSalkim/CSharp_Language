using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for(int değişken_adi = başlangıç değeri ; koşul;arttırmaAzaltma ){ }

            /* 1den 10 a kadar olan sayıları alt alta yazdıran programı yazınız.

            for (int i = 1; i <= 10; i++)
             {   
                Console.WriteLine(i); 
             }
            Console.ReadLine();*/

            /* İÇ İÇE FOR DÖNGÜSÜ

            for(int i = 1; i <=10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }
            Console.ReadLine(); 
            */

            /* WHİLE DÖNGÜSÜ 
             * 1000 den 0 a kadar olan sayaıların çift olanlarını ekrana yazdıraan program 

            int a = 100;

            while (a >= 0)
            {
                Console.WriteLine(a);
                a -= 2;
                
            }
            Console.ReadLine();
            */

           
        }
    }
}
