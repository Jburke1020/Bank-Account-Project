using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_project
{
    //inherits from base class
    class Savings : Account
    {   
        //fields
        string AccountName = "Savings";
        int AccountNo = 12342;
        int balance = 500;

        //properties
        public override void AccountBalance()
        {
            Console.WriteLine(AccountName + " Account\n" + "Account Number " + AccountNo + "\nYour balance is: " + balance +"\n--------------------");
        }

        public decimal Balance { get; set; }

         public override void DepositTransaction(int userInput)
         {   Console.WriteLine("Please enter the dollar amount of your deposit:");
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
