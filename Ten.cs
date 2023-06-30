using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface Gross
    {
        double TA { get; set; }
        double DA { get; set; }

        void Gross_sal();
    }

    class Employee
    {
        protected string Name;

        public Employee(string name)
        {
            Name = name;
        }

        public void Basic_sal()
        {
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Basic Salary Calculation");
            // Perform basic salary calculation
        }
    }

    class Salary : Employee, Gross
    {
        private double HRA;
        public double TA { get; set; }
        public double DA { get; set; }

        public Salary(string name, double hra)
            : base(name)
        {
            HRA = hra;
        }

        public void Disp_sal()
        {
            Basic_sal();
            Console.WriteLine("HRA: " + HRA);
            Console.WriteLine("TA: " + TA);
            Console.WriteLine("DA: " + DA);
        }

        public void Gross_sal()
        {
            double grossSalary = HRA + TA + DA;
            Console.WriteLine("Gross Salary: " + grossSalary);
        }
    }
    internal class Ten
    {
        public static void Main(string[] args)
        {
            string name;
            double hra, ta, da;

            Console.Write("Enter the employee name: ");
            name = Console.ReadLine();

            Console.Write("Enter the HRA: ");
            hra = double.Parse(Console.ReadLine());

            Console.Write("Enter the TA: ");
            ta = double.Parse(Console.ReadLine());

            Console.Write("Enter the DA: ");
            da = double.Parse(Console.ReadLine());

            Salary emp = new Salary(name, hra);
            emp.TA = ta;
            emp.DA = da;

            emp.Disp_sal();
            emp.Gross_sal();
        }
    }
}
