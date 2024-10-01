using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKullanımı
{
    public class Araba
    {
        public int kapiSayisi;
        public string arabaModeli;

        public string arabaRengi;



        public void motorCalistir()
        {
            Console.WriteLine("Motor Çalışıyor");
        }

        public void kapılarıKilitle()
        {
            Console.WriteLine("Kapılar Kilitleniyor...");
        }
    }
}
