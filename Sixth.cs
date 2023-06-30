using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Distance
    {
        public int dist1;
        public int dist2;
        public int dist3;

        public Distance(int d1,int d2)
        {
            dist1 = d1;
            dist2 = d2;
        }

        public void add()
        {
            dist3 = dist1 + dist2;
        }

        public void display()
        {
            Console.WriteLine("Addition = " + dist3);
        }
    }
    internal class Sixth
    {
        public static void main()
        {
            Distance dist = new Distance();

            dist.add();
            dist.display();
        }
    }
}
