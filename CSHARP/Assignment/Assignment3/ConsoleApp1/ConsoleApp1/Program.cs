using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Accounts
    {
        public string accountNo;
        public string customerName;
        public string accountType;
        public char transactionType;
        public int amount;
        public int balance;

        
        public Accounts(string accountNo, string customerName, string accountType)
        {
            this.accountNo = accountNo;
            this.customerName = customerName;
            this.accountType = accountType;
            this.balance = 0; 
        }

        
        public void Credit(int amount)
        {
            balance += amount;
        }


        public void Debit(int amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }

        
        public void UpdateBalance()
        {
            if (transactionType == 'D')
            {
                Credit(amount);
            }
            else if (transactionType == 'W')
            {
                Debit(amount);
            }
            else
            {
                Console.WriteLine("Invalid transaction type!");
            }
        }

       
        public void ShowData()
        {
            Console.WriteLine($"Account Number: {accountNo}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Account Type: {accountType}");
            Console.WriteLine($"Current Balance: {balance}");
            Console.WriteLine($"Current Amount: {amount}");
            Console.WriteLine($"Transaction Type: {transactionType}");
        }


        public void PerformTransaction(char transactionType, int amount)
        {
            this.transactionType = transactionType;
            this.amount = amount;
        }

        
        public static void Main()
        {
            Console.WriteLine("Enter Account No:");
            string accountNo = Console.ReadLine();

            Console.WriteLine("Enter Customer Name:");
            string customerName = Console.ReadLine();

            Console.WriteLine("Enter Account Type:");
            string accountType = Console.ReadLine();

            Accounts ac = new Accounts(accountNo, customerName, accountType);
            Console.WriteLine("Enter transaction type (D for Deposit, W for Withdrawal):");
            char transactionType = Console.ReadLine()[0];
            Console.WriteLine("Enter amount:");
            int amount = Convert.ToInt32(Console.ReadLine());

            ac.PerformTransaction(transactionType, amount);
            ac.UpdateBalance();
            ac.ShowData();

            Console.WriteLine("-------STUDENT DETAILS-------");
            Student.stud();
            Console.WriteLine("-------SALES DETAILS-------");
            Saledetails.details();
            Console.WriteLine("-------CUSTOMER DETAILS-------");
            Customer.DisplayCustomer();

            Console.Read();
        }
    }
}


