using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Furniture
    {
        protected string material;
        protected double price;

        public Furniture(string mat, double pri)
        {
            material = mat;
            price = pri;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Material: " + material);
            Console.WriteLine("Price: " + price);
        }
    }

    class Table : Furniture
    {
        private double height;
        private double surfaceArea;

        public Table(string mat, double pri, double ht, double area)
            : base(mat, pri)
        {
            height = ht;
            surfaceArea = area;
        }

        public void DisplayTableDetails()
        {
            DisplayDetails();
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Surface Area: " + surfaceArea);
        }
    }
    internal class Eight
    {
        public static void main()
        {
            string material;
            double price, height, surfaceArea;

            Console.Write("Enter the material of the table: ");
            material = Console.ReadLine();

            Console.Write("Enter the price of the table: ");
            price = double.Parse(Console.ReadLine());

            Console.Write("Enter the height of the table: ");
            height = double.Parse(Console.ReadLine());

            Console.Write("Enter the surface area of the table: ");
            surfaceArea = double.Parse(Console.ReadLine());

            Table table = new Table(material, price, height, surfaceArea);
            table.DisplayTableDetails();
        }
    }
}
