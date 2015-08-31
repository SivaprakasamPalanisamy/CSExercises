using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISS.RV.LIB;

namespace CSExercises
{
    class Account
    {
        //attributes
        string AccountNumber;
        string AccountHolder;
        double Balance;

        // Constructors
        public Account(string a, string b, double c)
        {
            AccountNumber = a;
            AccountHolder = b;
            Balance = c;

        }


        // Properties
  /*      public string acno
        {
            get { return (AccountNumber); }
        }
        public string acholder
        {
            get { return (AccountHolder); }
        }
        public double bal
        {
            get { return (Balance); }
        }
   */ 

        // Methods

        public double Withdraw(double WithdrawAmount)
        {
            return (Balance = Balance - WithdrawAmount);
        }

        public double Deposit(double DepositAmount)
        {

            return (Balance = Balance + DepositAmount);
        }

        public double TransferTo(double TransferAmount, Account b)
        
            {
                b.Deposit(TransferAmount);
                return (Withdraw(TransferAmount));                
                
            }

              

        
        public double Show()
        {

            return (Balance);
        }

    }


        class BankTest
        {
            static void Main(string[] args)
            {
                Account a = new Account("001-001-001", "Tan Ah Kow", 2000);
                Account b = new Account("001-001-002", "Kim Keng Lee", 5000);
                Console.WriteLine(a.Show());
                Console.WriteLine(b.Show());
                a.Deposit(100);
                b.Deposit(200);
                Console.WriteLine(a.Show());
                Console.WriteLine(b.Show());
                a.Withdraw(200);
                b.Withdraw(100);
                Console.WriteLine(a.Show());
                a.TransferTo(300,b);
                Console.WriteLine(a.Show());
                Console.WriteLine(b.Show());
                b.TransferTo(1000, a);
                Console.WriteLine(a.Show());
                Console.WriteLine(b.Show());
    
                string exit = Console.ReadLine();

            }
      }
}   





