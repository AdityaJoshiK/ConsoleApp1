using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Rectangle
    {
        private double length;
        private double width;
        private double area;

        public Rectangle(double len, double wid)
        {
            length = len;
            width = wid;
            area = length * width;
        }

        public void DisplayArea()
        {
            Console.WriteLine("The area of the rectangle is: " + area);
        }
    }
    internal class Seventh
    {
        public static void main()
        {
            double len, wid;

            Console.Write("Enter the length of the rectangle: ");
            len = double.Parse(Console.ReadLine());

            Console.Write("Enter the width of the rectangle: ");
            wid = double.Parse(Console.ReadLine());

            Rectangle rect = new Rectangle(len, wid);
            rect.DisplayArea();
        }

    }
}
