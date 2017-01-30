using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_project
{
    class Program
    {
        
        private static readonly int userInput;

        public static int userNumber { get; private set; }
     
       //Trying StreamWriter:   string informationToWrite = "This is the text file for the Bank Account project.";
        
        static void Main(string[] args)
        {
            //Trying StreamWriter:  string informationToWrite = "Bank Account Transactions.";
            //Trying StreamWriter:  File.WriteAllText("C:..WeCanCodeIT..MyDocuments...Notes...txt", informationToWrite);

            //Menu Items
            Console.WriteLine("[1] View Client Information\n" +
                          "[2] View Accounts\n" +
                          "[3] Deposit Funds\n" +
                          "[4] Withdraw Funds\n" +
                          "[5] Exit\n");

            string userResponse = Console.ReadLine();
            userNumber = Convert.ToInt32(userResponse);
            if (userNumber == 1)
            {   
                //per assignment-one client harded into the system
                string Name = "Babs McGee ";
                int AccountNo = 1234;
                Console.WriteLine("[1] " + Name + "Base Account Number: " + AccountNo);

            }
            else if (userNumber == 2)
            {
                Account[] dab = new Account[3];
                dab[0] = new Checking();
                dab[1] = new Savings();
                dab[2] = new Reserve();
                foreach(Account update in dab)
                {
                    update.AccountBalance();
                }
                return;
            }
            else if (userNumber == 3)
            {
                Console.WriteLine("Please choose the Account for your Transaction: ");
                Console.WriteLine("[1] Checking\n" +
                          "[2] Savings\n" +
                          "[3] Reserve\n" );
                string userAccountChoice = Console.ReadLine();
                userNumber = Convert.ToInt32(userAccountChoice);
                if (userNumber == 1)
                {
                    Checking amount = new Checking();
                    amount.DepositTransaction(userInput);
                   
                    Console.ReadKey(); 
                }
                else if (userNumber == 2)
                {
                    Savings amount = new Savings();
                    amount.DepositTransaction(userInput);
                    Console.ReadKey();
                }
                else if (userNumber == 3)
                {
                    Reserve amount = new Reserve();
                    amount.DepositTransaction(userInput);
                    Console.ReadKey();
                }
                
                 return;
            }
            else if (userNumber == 4)
            {
                Console.WriteLine("Please choose the Account for your Withdrawl: ");
                Console.WriteLine("[1] Checking\n" +
                          "[2] Savings\n" +
                          "[3] Reserve\n");
                string userAccountChoice = Console.ReadLine();
                userNumber = Convert.ToInt32(userAccountChoice);
                if (userNumber == 1)
                {
                    Checking amount = new Checking();
                    amount.WithdrawFunds(userInput);
                    Console.ReadKey();
                }
                else if (userNumber == 2)
                {
                    Savings amount = new Savings();
                    amount.WithdrawFunds(userInput);
                    Console.ReadKey();
                }
                else if (userNumber == 3)
                {
                    Reserve amount = new Reserve();
                    amount.WithdrawFunds(userInput);
                    Console.ReadKey();
                }

                return;

            }

            else if (userNumber == 5)
            {
                Console.WriteLine("Press any Key to Exit");
            }

        }
           

    }



    }
    
