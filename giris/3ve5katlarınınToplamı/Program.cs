using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ve5katlarınınToplamı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, i, sum = 0;

            for (i = 1; i < 100; i++) {
                a = i % 3;
                b = i % 5;

                if (a == 0 || b == 0)
                {
                    Console.Write("{0} \t ", i);
                    sum = sum + i;
                }
            }
            
            Console.WriteLine(" \n 100'ün Altındaki 3 veya 5'in Katlarının Toplamı : {0}", sum);
            Console.Read();
        }
    }
}
