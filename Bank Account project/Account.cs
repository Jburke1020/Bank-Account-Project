using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_project
{  
    public class Account
    {   
        //fields
        public int balance;
        private int deposit;
        private int withdraw;

        //properites
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
        public int Deposit
        {
            get
            {
                return deposit;
            }
            private set
            {
                deposit = value;
            }
        }
        public int Withdraw
        {
            get
            {
                return withdraw;
            }
            private set
            {
                withdraw = value;
            }
        }
                   
        public virtual void AccountBalance()
        {   

        }

               
        public virtual void DepositTransaction(int userInput)
        {
            Console.WriteLine("Please enter the dollar amount of your deposit:");
            string input = Console.ReadLine();
            int Deposit; Int32.TryParse(input, out Deposit);
            
            Console.WriteLine("Transaction of +$" + Deposit + " dollars was entered on " + DateTime.Now);
            Account account = new Account();
            account._Balance = Deposit + balance;
            Console.Write("Your new balance is: " + account._Balance);
            
        }
        public virtual void WithdrawFunds(int userInput)
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

