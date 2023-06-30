using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Staff
    {
        public string name;
        public string post;
    }
    internal class First
    {
        public static void main(string[] args)
        {
            Staff[] s = new Staff[4];

            for(int i = 0; i < s.Length; i++)
            {
                Staff staff = new Staff();

                Console.Write("Enter Name:");
                staff.name = Console.ReadLine();

                Console.Write("Enter Post:");
                staff.post = Console.ReadLine();

                s[i] = staff;
            }

            for(int i = 0;i < s.Length;i++)
            {
                if (s[i].post == "HOD" )
                {
                    Console.WriteLine(s[i].name);
                }
            }
        }
    }
}
