using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System;

    class Exception1
    {
        static void Main()
        {
            /* Program 1: Create a divide by zero exception and handle it
            
                int dividend = 10;
                int divisor = 0;

                try
                {
                    int result = dividend / divisor;
                    Console.WriteLine("Result: " + result);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

            */





            /* Program 2: Read 5 numbers from user and demonstrate IndexOutOfRangeException
            
                    int[] numbers = new int[5];

                    try
                    {
                        Console.WriteLine("Enter 5 numbers:");

                        for (int i = 0; i < 6; i++) // causing the IndexOutOfRangeException
                        {
                            Console.Write($"Number {i + 1}: ");
                            numbers[i] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }

             */



            /* Program 3: Accept a number from the user and throw an exception if it's not even
            
                    try
                    {
                        Console.Write("Enter a number: ");
                        int number = Convert.ToInt32(Console.ReadLine());

                        if (number % 2 != 0)
                        {
                            throw new Exception("Number is not even.");
                        }

                        Console.WriteLine("Number is even.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }

            */



            /* Program 4: Create an abstract class with abstract methods and implement them
                    abstract class Sum
                    {
                        public abstract int SumOfTwo(int a, int b);
                        public abstract int SumOfThree(int a, int b, int c);
                    }

                    class Calculate : Sum
                    {
                        public override int SumOfTwo(int a, int b)
                        {
                            return a + b;
                        }

                        public override int SumOfThree(int a, int b, int c)
                        {
                            return a + b + c;
                        }
                    }

                    Calculate calc = new Calculate();
                    Console.WriteLine("Sum of two numbers: " + calc.SumOfTwo(5, 10));
                    Console.WriteLine("Sum of three numbers: " + calc.SumOfThree(5, 10, 15));

        */



        /* Program 5: Create an interface and implement it in another class
                    interface ICalculate
                    {
                        int Addition(int a, int b);
                        int Subtraction(int a, int b);
                    }

                    class Result : ICalculate
                    {
                        public int Addition(int a, int b)
                        {
                            return a + b;
                        }

                        public int Subtraction(int a, int b)
                        {
                            return a - b;
                        }
                    }

                    Result res = new Result();
                    Console.WriteLine("Addition: " + res.Addition(5, 10));
                    Console.WriteLine("Subtraction: " + res.Subtraction(10, 5));

        */



        /* Program 6: Create an interface named Shape and implement it
                interface IShape
                {
                    double Circle(double radius);
                    double Triangle(double baseLength, double height);
                    double Square(double side);
                }

                class Shape : IShape
                {
                    public double Circle(double radius)
                    {
                        return Math.PI * radius * radius;
                    }

                    public double Triangle(double baseLength, double height)
                    {
                        return 0.5 * baseLength * height;
                    }

                    public double Square(double side)
                    {
                        return side * side;
                    }
                }

                Shape shape = new Shape();
                Console.WriteLine("Area of Circle: " + shape.Circle(5));
                Console.WriteLine("Area of Triangle: " + shape.Triangle(4, 6));
                Console.WriteLine("Area of Square: " + shape.Square(5));

        */



        /* Program 7: Use common methods of String class
                string text = "Hello, World!";
                Console.WriteLine("Length: " + text.Length);
                Console.WriteLine("Substring: " + text.Substring(7));
                Console.WriteLine("Uppercase: " + text.ToUpper());
                Console.WriteLine("Lowercase: " + text.ToLower());
                Console.WriteLine("Index of 'World': " + text.IndexOf("World"));
                Console.WriteLine("Replace: " + text.Replace("Hello", "Hi"));

         */

        /* Program 8: Replace lowercase characters to uppercase and vice versa
                string input = "Hello, World!";
                string converted = "";

                foreach (char ch in input)
                {
                    if (Char.IsLower(ch))
                    {
                        converted += Char.ToUpper(ch);
                    }
                    else if (Char.IsUpper(ch))
                    {
                        converted += Char.ToLower(ch);
                    }
                    else
                    {
                        converted += ch;
                    }
                }

                Console.WriteLine("Converted: " + converted);
        */



        /* Program 9: Find the longest word in a string
                string sentence = "The quick brown fox jumps over the lazy dog";
                string[] words = sentence.Split(' ');
                string longestWord = "";

                foreach (string word in words)
                {
                    if (word.Length > longestWord.Length)
                    {
                        longestWord = word;
                    }
                }

                Console.WriteLine("Longest word: " + longestWord);
         */



           /* Program 10: Change the case of an entered character
                Console.Write("Enter a character: ");
                char character = Console.ReadLine()[0];

                if (Char.IsLower(character))
                {
                    Console.WriteLine("Uppercase: " + Char.ToUpper(character));
                }
                else if (Char.IsUpper(character))
                {
                    Console.WriteLine("Lowercase: " + Char.ToLower(character));
                }
                else
                {
                    Console.WriteLine("Not a letter.");
                }
            */


    }
}

}
