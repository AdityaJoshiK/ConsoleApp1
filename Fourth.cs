using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public int Enrollment_No { get; set; }
        public string Student_Name { get; set; }
        public int Semester { get; set; }
        public double CPI { get; set; }
        public double SPI { get; set; }

        public void GetStudentDetails()
        {
            Console.WriteLine("Enter Student Details:");
            Console.Write("Enrollment Number: ");
            Enrollment_No = int.Parse(Console.ReadLine());

            Console.Write("Student Name: ");
            Student_Name = Console.ReadLine();

            Console.Write("Semester: ");
            Semester = int.Parse(Console.ReadLine());

            Console.Write("CPI: ");
            CPI = double.Parse(Console.ReadLine());

            Console.Write("SPI: ");
            SPI = double.Parse(Console.ReadLine());
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine("Enrollment Number: " + Enrollment_No);
            Console.WriteLine("Student Name: " + Student_Name);
            Console.WriteLine("Semester: " + Semester);
            Console.WriteLine("CPI: " + CPI);
            Console.WriteLine("SPI: " + SPI);
        }
    }

    internal class Fourth
    {
        public static void main()
        {
            Student student = new Student();

            // Get student details
            student.GetStudentDetails();

            // Display student details
            student.DisplayStudentDetails();
        }
    }
}
