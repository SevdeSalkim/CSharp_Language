using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBelirleyici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //public -- private

            Musteri musteri1 = new Musteri();

            musteri1.isim = "Sevde";
            musteri1.soyisim = "Salkim";
            musteri1.maasDegeri = 20000;
            musteri1.cinsiyet = "Kadın";

        }
    }
}
