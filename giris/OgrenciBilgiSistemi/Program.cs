using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            Ogrenci ogrenci1 = new Ogrenci(1,"Sevde","Salkim",25,45,80,"KBÜ");

            Console.WriteLine("Uygulamamıza Hoşgeldiniz. Yapmak İstediğiniz işlemi seçiniz.");
            

            while (kontrol) {
                islemleriGöster();
                string secim = Console.ReadLine();
                
                switch (secim)
                {
                    case "1":
                        ogrenci1.ogrenciBilgileri();
                        break;

                    case "2":
                        double ogrenciOrtalama =  ogrenci1.ogrenciOrtalaması();
                        Console.WriteLine(ogrenciOrtalama);
                        break;
                    case "3":
                        ogrenci1.okulGetir();
                        break;

                    case "4":
                        kontrol = false;
                        break;
                    
                    default:
                        Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                        break;

                }


            }

        }

        static void islemleriGöster()
        {
            Console.WriteLine("1.ÖğrenciBilgileri göster.");
            Console.WriteLine("2.Öğrenci ortalamasını göster.");
            Console.WriteLine("3.öğrenci okulunu göster.");
            Console.WriteLine("4.Çıkış yap");

        }
    }
}
