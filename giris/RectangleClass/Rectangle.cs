using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleClass
{
    internal class Rectangle
    {
        //Alan ve çevre hesaplamak için GetArea() ve GetPerimeter() metodlarını yaz.
        //  Main metodunda birkaç dikdörtgen oluştur ve alanlarını/çevrelerini ekrana yazdır.

        private int Width;
        private int Height;

        public Rectangle(int _width, int _height)
        {
           this.Width = _width;
           this.Height = _height;  
        }

        public double GetArea()
        {
            double area =  Width * Height;
            return area;
        }

        public double GetPerimeter()
        {
            double perimeter = 2 * (Width + Height);
            return perimeter;
        }
    }
}
