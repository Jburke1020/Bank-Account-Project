using System;
using System.Collections.Generic;
using System.IO;  //Trying StreamWriter
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_project
{   
    //inherits from base class
    class Checking : Account
    {
        //fields
        int Balance = 100;
        string AccountName = "Checking";
        int AccountNo = 12341;
        int balance = 100;
        
        //properties
        public int _Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }
        
        
        public override void AccountBalance()
        {
            Console.WriteLine(AccountName +" Account\n" + "Account Number " + AccountNo + "\nYour balance is: " + balance + "\n--------------------");
        }
        
            public override void DepositTransaction(int userInput)
            {
                Console.WriteLine("Please enter the dollar amount of your deposit:");
                string input = Console.ReadLine();
                int Deposit; Int32.TryParse(input, out Deposit);
                Console.WriteLine("Transaction of +$" + Deposit + " dollars was entered on " + DateTime.Now);
                Account account = new Account();  
                account._Balance = Deposit + balance;
                Console.Write("Your new balance is: " + account._Balance);
        } 
        public override void WithdrawFunds(int userInput)
        {
            Console.WriteLine("Please enter the dollar amount to Withdraw:");
            string input = Console.ReadLine();
            int Withdraw; Int32.TryParse(input, out Withdraw);
            Console.WriteLine("Transaction of -$" + Withdraw + " dollars was entered on " + DateTime.Now);
            Account account = new Account();
            account._Balance = balance - Withdraw;
            Console.Write("Your new balance is: " + account._Balance);
        }

    }
}
