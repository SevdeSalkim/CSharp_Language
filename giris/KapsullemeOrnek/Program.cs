using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel personel1 = new Personel();

            personel1.TCKİMLİKNO = "12345678945";

            Console.WriteLine( "girdiğiniz tc kimlik numaranız: " + personel1.TCKİMLİKNO);
            Console.ReadLine();
        }
    }
}
