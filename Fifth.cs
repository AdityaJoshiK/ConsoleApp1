using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Salary
    {
        private double Basic;
        private double TA;
        private double DA;
        private double HRA;

        public Salary(double basic, double ta, double da = 0.2, double hra = 0.15)
        {
            Basic = basic;
            TA = ta;
            DA = da * Basic;
            HRA = hra * Basic;
        }

        public double CalculateSalary()
        {
            return Basic + TA + DA + HRA;
        }
    }

    internal class Fifth
    {
        public static void main()
        {
            Console.WriteLine("Enter Basic Salary: ");
            double basicSalary = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Travel Allowance (TA): ");
            double ta = double.Parse(Console.ReadLine());

            Salary salary = new Salary(basicSalary, ta);

            double totalSalary = salary.CalculateSalary();
            Console.WriteLine("Total Salary: " + totalSalary);
        }
    }
}
