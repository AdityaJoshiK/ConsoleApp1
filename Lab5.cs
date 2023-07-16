using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Lab5
    {
        /*Program 1: Method overloading for addition of two integers and two floats
         
            static int Add(int a, int b)
            {
                return a + b;
            }

            static float Add(float a, float b)
            {
                return a + b;
            }

            //Call Methods
             static void Main()
            {
                int sum1 = Add(5, 10);
                float sum2 = Add(3.5f, 2.5f);
                Console.WriteLine("Sum of integers: " + sum1);
                Console.WriteLine("Sum of floats: " + sum2);
            }
        */



        /* Program 2: Method overloading to calculate area of square and rectangle
         
            static int CalculateArea(int side)
            {
                return side * side;
            }

            static int CalculateArea(int length, int width)
            {
                return length * width;
            }

            //Call Methods
            static void Main()
            {
                int squareArea = CalculateArea(5);
                int rectangleArea = CalculateArea(4, 6);
                Console.WriteLine("Area of square: " + squareArea);
                Console.WriteLine("Area of rectangle: " + rectangleArea);
            }
        */


        /* Program 3: Method overloading to calculate area of square, rectangle, and circle
         
        
            static int CalculateArea(int sideLength)
            {
                return sideLength * sideLength;
            }

            static int CalculateArea(int length, int width)
            {
                return length * width;
            }

            static double CalculateArea(double radius)
            {
                return Math.PI * radius * radius;
            }
        
            //Call Methods
            static void Main()
            {
                int squareArea2 = CalculateArea(5);
                int rectangleArea2 = CalculateArea(4, 6);
                double circleArea = CalculateArea(3.5);
                Console.WriteLine("Area of square: " + squareArea2);
                Console.WriteLine("Area of rectangle: " + rectangleArea2);
                Console.WriteLine("Area of circle: " + circleArea);
            }
        */



        /* Program 4: RBI, HDFC, SBI, ICICI classes with calculateInterest() method
         
            class RBI
            {
                public virtual void CalculateInterest()
                {
                    Console.WriteLine("RBI interest calculation");
                }
            }

            class HDFC : RBI
            {
                public override void CalculateInterest()
                {
                    Console.WriteLine("HDFC interest calculation");
                }
            }

            class SBI : RBI
            {
                public override void CalculateInterest()
                {
                    Console.WriteLine("SBI interest calculation");
                }
            }

            class ICICI : RBI
            {
                public override void CalculateInterest()
                {
                    Console.WriteLine("ICICI interest calculation");
                }
            }
            
            //Call Methods
            static void Main()
            {
                RBI rbi = new RBI();
                HDFC hdfc = new HDFC();
                SBI sbi = new SBI();
                ICICI icici = new ICICI();
                rbi.CalculateInterest();
                hdfc.CalculateInterest();
                sbi.CalculateInterest();
                icici.CalculateInterest();
            }
         */




        /* Program 5: Hospital, Apollo, Wockhardt, Gokul_Superspeciality classes with HospitalDetails() method
            class Hospital
            {
                public virtual void HospitalDetails()
                {
                    Console.WriteLine("Hospital details");
                }
            }

            class Apollo : Hospital
            {
                public override void HospitalDetails()
                {
                    Console.WriteLine("Apollo hospital details");
                }
            }

            class Wockhardt : Hospital
            {
                public override void HospitalDetails()
                {
                    Console.WriteLine("Wockhardt hospital details");
                }
            }

            class Gokul_Superspeciality : Hospital
            {
                public override void HospitalDetails()
                {
                    Console.WriteLine("Gokul Superspeciality hospital details");
                }
            }
        
            //Call Methods
            static void Main()
            {
                Hospital hospital = new Hospital();
                Apollo apollo = new Apollo();
                Wockhardt wockhardt = new Wockhardt();
                Gokul_Superspeciality gokul = new Gokul_Superspeciality();
                hospital.HospitalDetails();
                apollo.HospitalDetails();
                wockhardt.HospitalDetails();
                gokul.HospitalDetails();
            }
        */




        /* Program 6: Return factorial from a method using delegate
         
            delegate int CalculateFactorial(int number);

            static int Factorial(int number)
            {
                if (number == 0)
                    return 1;
                else
                    return number * Factorial(number - 1);
            }
         
             //Call Methods
            static void Main()
            {
                CalculateFactorial factorialDelegate = new CalculateFactorial(Factorial);
                int factorial = factorialDelegate(5);
                Console.WriteLine("Factorial: " + factorial);
            }
        */





        /*Program 7: Delegate for TrafficSignal
         
            delegate void TrafficDel();

            class TrafficSignal
            {
                public static void Yellow()
                {
                    Console.WriteLine("Yellow Light Signal To Get Ready");
                }

                public static void Green()
                {
                    Console.WriteLine("Green Light Signal To Go");
                }

                public static void Red()
                {
                    Console.WriteLine("Red Light Signal To Stop");
                }
            }
        
            //Call Methods
            static void Main()
            {
                TrafficDel trafficDelegate = null;
                trafficDelegate += TrafficSignal.Yellow;
                trafficDelegate += TrafficSignal.Green;
                trafficDelegate += TrafficSignal.Red;
                trafficDelegate();  
            }
        */



        /*Program 8: Generic delegate calculator
         
            delegate T Calculator<T>(T a, T b);

            static int AddNumbers(int a, int b)
            {
                return a + b;
            }

            static float AddNumbers(float a, float b)
            {
                return a + b;
            }
        
            //Call Methods
            static void Main()
            {
                Calculator<int> intCalculator = new Calculator<int>(AddNumbers);
                int sum3 = intCalculator(5, 10);
                Console.WriteLine("Sum of integers: " + sum3);

                Calculator<float> floatCalculator = new Calculator<float>(AddNumbers);
                float sum4 = floatCalculator(3.5f, 2.5f);
                Console.WriteLine("Sum of floats: " + sum4);
            }
         */
    }
}
