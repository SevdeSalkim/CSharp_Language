using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBelirleyici
{
    internal class Musteri
    {
        public string isim;
        public string soyisim;
        public int maasDegeri;
        public string cinsiyet;
        private int yas;



        public void MusteriBilgileriGoster()
        {
            Console.WriteLine("İsmi: " + isim);
            Console.WriteLine("Soyismi: " + soyisim);
            Console.WriteLine("Maaş Bilgisi: " + maasDegeri);
            Console.WriteLine("Cinsiyet: " + cinsiyet);
            Console.WriteLine("Yaş: " + yas);
        }

        private void IsimSoyisimYazdır(string musteriIsim, string musteriSoyisim)
        {
            Console.WriteLine("Müşteri İsim ve Soyismi: " + musteriIsim + " " + musteriSoyisim);
        }
    }
}
