using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Candidate
    {
        public int Candidate_ID;
        public string Candidate_Name;
        public int Candidate_Age;
        public double Candidate_Weight;
        public double Candidate_Height;

        public void GetDetails()
        {
            Console.WriteLine("Enter Candidate Details:");
            Console.Write("ID: ");
            Candidate_ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Name: ");
            Candidate_Name = Console.ReadLine();

            Console.Write("Age: ");
            Candidate_Age = int.Parse(Console.ReadLine());

            Console.Write("Weight: ");
            Candidate_Weight = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            Candidate_Height = double.Parse(Console.ReadLine());
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\nCandidate Details:");
            Console.WriteLine("ID: " + Candidate_ID);
            Console.WriteLine("Name: " + Candidate_Name);
            Console.WriteLine("Age: " + Candidate_Age);
            Console.WriteLine("Weight: " + Candidate_Weight);
            Console.WriteLine("Height: " + Candidate_Height);
        }
    }


    internal class Second
    {
        public static void main()
        {
            Candidate candidate = new Candidate();

            // Get candidate details
            candidate.GetDetails();

            // Display candidate details
            candidate.DisplayDetails();
        }
    }
}
