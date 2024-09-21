using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginUgulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcı adı ve şifresini doğru girerse Tebrikler başarılı bir şekilde giriş yaptınız
            // yanlış girerse hata verelim ve 3 hak tanıyalım kullanıcıya yanlış girdiği sürece döngü dönmeye devam etsin.

            int hak = 3;

            while(true)
            {

                Console.WriteLine("Kullanıcı adı giriniz: ");
                string kullaiciAdi = Console.ReadLine();

                Console.WriteLine("Şifrenizi giriniz: ");
                string sifre = Console.ReadLine();


                if ( kullaiciAdi == "Alex" && sifre == "1234")
                {
                    Console.WriteLine("Giriş Yapıldı.");
                    break;
                }
                else
                {
                    Console.WriteLine("Kullanıcı adınız veya şifreniz yanlış");

                    if(hak > 0)
                    {
                        hak -= 1;
                    }
                    if (hak == 0) 
                    {
                        Console.WriteLine("Hakkınız dolmuştur");
                        break;
                    
                    }
                }
            }

            Console.ReadLine();

        }
    }
}
