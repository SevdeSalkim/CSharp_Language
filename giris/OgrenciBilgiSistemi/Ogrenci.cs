using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    public class Ogrenci
    {
        private int ogrenciNo;
        private string ogrenciİsim;
        private string ogrenciSoyisim;
        private int vize1;
        private int vize2;
        private int final;
        private string okulIsim;

        public Ogrenci(int _ogrenciNo, string _ogrenciİsim, string _ogrenciSoyisim, int _vize1, int _vize2, int _final, string _okulIsim)
        {
            this.ogrenciNo = _ogrenciNo;
            this.ogrenciİsim = _ogrenciİsim;
            this.ogrenciSoyisim = _ogrenciSoyisim;
            this.vize1 = _vize1;
            this.vize2 = _vize2;
            this.final = _final;
            this.okulIsim = _okulIsim;
        }

        public void ogrenciBilgileri()
        {
            Console.WriteLine("Öğrenci numarası: " + ogrenciNo);
            Console.WriteLine("Öğrenci AD ve SOYAD: " + ogrenciİsim + " " + ogrenciSoyisim);
            Console.WriteLine("Vİze 1 notu: " + vize1);
            Console.WriteLine("Vize2 notu: " + vize2);
            Console.WriteLine("Final notu: " + final);
            
        }

        public double ogrenciOrtalaması()
        {
            double ortalama = ((vize1 * 0.2) + (vize2 * 0.2) + final * 0.6);
            return ortalama;
        }

        public void okulGetir()
        {
            Console.WriteLine("Okul Bilgisi: " + okulIsim);

        }
    }
}
