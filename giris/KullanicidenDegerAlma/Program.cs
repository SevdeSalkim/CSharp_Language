using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanicidenDegerAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen adınızı giriniz: ");
            string isim = Console.ReadLine();

            Console.WriteLine("Lütfen soyisminizi giriiniz");
            string soyisim = Console.ReadLine();

            Console.WriteLine("kullanıcı adı: " + isim + " Kullanıcı Soyadı: " + soyisim);
            Console.ReadLine();
        }
    }
}
