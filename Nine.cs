using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AccountDetails
    {
        protected string accountNumber;
        protected double balance;
        protected double interestRate;

        public AccountDetails(string accNum, double bal, double intRate)
        {
            accountNumber = accNum;
            balance = bal;
            interestRate = intRate;
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Balance: $" + balance);
            Console.WriteLine("Interest Rate: " + interestRate + "%");
        }
    }

    class Interest : AccountDetails
    {
        private double totalInterest;

        public Interest(string accNum, double bal, double intRate)
            : base(accNum, bal, intRate)
        {
            CalculateInterest();
        }

        private void CalculateInterest()
        {
            totalInterest = balance * interestRate / 100;
        }

        public void DisplayInterest()
        {
            DisplayAccountInfo();
            Console.WriteLine("Total Interest: $" + totalInterest);
        }
    }
    internal class Nine
    {
        public static void main()
        {
            string accountNumber;
            double balance, interestRate;

            Console.Write("Enter the account number: ");
            accountNumber = Console.ReadLine();

            Console.Write("Enter the account balance: ");
            balance = double.Parse(Console.ReadLine());

            Console.Write("Enter the interest rate: ");
            interestRate = double.Parse(Console.ReadLine());

            Interest interestObj = new Interest(accountNumber, balance, interestRate);
            interestObj.DisplayInterest();
        }
    }
}
