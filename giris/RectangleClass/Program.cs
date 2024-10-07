using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Rectangle rect1 = new Rectangle(5, 12);
            Rectangle rect2 = new Rectangle(7,14);

            

            Console.WriteLine($"Rectangle1 Area: " + rect1.GetArea() + " " + "Rectangle1 Perimeter: " + rect1.GetPerimeter());
            Console.WriteLine($"Rectangle2 Area: " + rect2.GetArea()+ " " + "Rectangle2 Perimeter: " + rect2.GetPerimeter());

            Console.ReadLine();

        }
    }
}
