using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bank_Account
    {
        public int Account_No { get; set; }
        public string User_Name { get; set; }
        public string Email { get; set; }
        public string Account_Type { get; set; }
        public double Account_Balance { get; set; }

        public void GetAccountDetails()
        {
            Console.WriteLine("Enter Account Details:");
            Console.Write("Account Number: ");
            Account_No = int.Parse(Console.ReadLine());

            Console.Write("User Name: ");
            User_Name = Console.ReadLine();

            Console.Write("Email: ");
            Email = Console.ReadLine();

            Console.Write("Account Type: ");
            Account_Type = Console.ReadLine();

            Console.Write("Account Balance: ");
            Account_Balance = double.Parse(Console.ReadLine());
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("\nAccount Details:");
            Console.WriteLine("Account Number: " + Account_No);
            Console.WriteLine("User Name: " + User_Name);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Account Type: " + Account_Type);
            Console.WriteLine("Account Balance: " + Account_Balance);
        }
    }


    internal class Third
    {
        public static void main()
        {
            Bank_Account bankAccount = new Bank_Account();

            // Get account details
            bankAccount.GetAccountDetails();

            // Display account details
            bankAccount.DisplayAccountDetails();
        }
    }
}
