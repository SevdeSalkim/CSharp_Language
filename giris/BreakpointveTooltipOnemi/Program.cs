using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakpointveTooltipOnemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // breakpoint kodlarımızın çalışma prensinbine bakmak için satırları tek tek çalıştırarak hangi işlemin yapıldığını gösterir.
            // kod satırının bulunduğu yere en sol kısma satır sayısının soluna sol cklick yaparak oradan kodun adım adım ilerlemisen bakılır.

            int a = 5;
            int b = 8;

            int sonuc = a + b;
            Console.WriteLine(sonuc);
            Console.ReadLine();

            // Tooltip ise kullanmak istediğimiz metodun üstüne geldiğimizde bize açılan önizleme penceresidir. metot hakkında bilgiler verir.
        }
    }
}
