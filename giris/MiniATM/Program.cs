using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıya soracağız nasıl bir işlem yapmak istediğini
            // 1- Bakiye Görüntüleme
            // 2- Para Cekme
            //3 Para Yatırma
            // q ya basarsa çıkış yaptıracağız.

            int bakiye = 1000;

            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz; 1: Bakiye Görüntüleme, 2: Para Cekme, 3:Para Yatırma, q: çıkış ");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine("Toplam bakiyeniz:" + bakiye);
                Console.ReadLine();
            }
            else if (secim == "2")
            {
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz: ");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                
                if (cekilecek_tutar <= bakiye)
                {

                    Console.WriteLine("Kalan tutar: " + (bakiye - cekilecek_tutar));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Bakiyenizden fazla para çekemezsiniz. Toplam bakiyeniz: " + bakiye);
                    Console.ReadLine();
                }
            }
            else if (secim == "3")
            {
                Console.WriteLine("Yatırmak istediğiniz tutarı giriniz: ");
                int yatırılan_tutar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Toplam tutar: " + (bakiye + yatırılan_tutar));
                Console.ReadLine();
            }

            else if (secim == "q")
            {
                Console.WriteLine("Çıkış yapılıyor.");
                Console.WriteLine("İşleminiz gerçekleşti. İyi Günler Dileriz.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Lütfen Geçerli Bir İşlem Seçiniz.");
            }



        }
    }
}
