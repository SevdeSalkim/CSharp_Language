using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Ogrenci
    {
        private string isim = "Sevde";

        public void setisim(string _isim)
        {
            this.isim = _isim;
        }
        public string getisim() { 
            return isim;
        }


    }
}
