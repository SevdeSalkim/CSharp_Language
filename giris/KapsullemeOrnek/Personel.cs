using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeOrnek
{
    public class Personel
    {
        private string tcKimlikNo;

        public string TCKİMLİKNO {
            
            get {
                return tcKimlikNo.Substring(0, 4);

            } 
            
            set {
                bool control = false;
                if (value.Length == 11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool sayimi = char.IsNumber(value[i]);

                        if (sayimi) { 
                            // 
                        }
                        else
                        {
                            control = true;
                            break;
                        }
                    }
                    if (control) {
                        Console.WriteLine("lütfen tc kimlik numaranızı geçersiz karakter bulunmaktadır.");
                    }
                    else
                    {
                        tcKimlikNo = value;
                    }
                    

                }
                else {
                    Console.WriteLine("Girdiğiniz kimlik numarası 11 karakterli değildir.");                
                }
            } 
        }
    }
}
