using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pattern
    {
        public static void pattern1()
        {
            int n = 4;

            for(int i = 1; i <= n; i++)
            {
                for(int j=1;j<=n-i;j++)
                {
                    Console.Write(" ");
                }

                for(int j=1;j<=(2*i)-1;j++)
                {
                    Console.Write("1");
                }
                Console.WriteLine();
            }
        }
        public static void main()
        {
            int n = 4;

            int a = 1;

            for (int i = 1; i <= n; i++)
            {
                for(int j=1; j <= n-i; j++)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<=i;j++)
                {
                    Console.Write(a+" ");
                    a++;
                }
                Console.WriteLine();
            }
        }
    }
}
