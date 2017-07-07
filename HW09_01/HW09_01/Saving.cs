using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW09_01
{
    class Saving: BankAccount
    {
        
        // constructors
        public Saving(): base()
        { }
        public Saving(string first, string last, string bank, int routing, int acctNum, double bal, double apr) : base(first, last, bank, routing, acctNum, bal, apr)
        { }
        public void TransferToChecking(double amount, int routing, BankAccount Checking)
        {
            if (routing == Checking.RoutingNumber)
            {
                Console.WriteLine("{0} {1} of account number {2}", firstName, lastName, accountNumber);
                if (amount <= balance)
                {
                    balance -= amount;
                   
                    Console.WriteLine("Transferred {0:c2} to checking account number {1} with routing number {2}", amount, Checking.AccountNumber, Checking.RoutingNumber);
                    Console.WriteLine("Old savings balance: {0:c2}, new savings balance: {1:c2}", balance + amount, balance);
                    //             Console.WriteLine("Old checking balance: {0:c2}, new checking balance: {1:c2}", Checking.Balance, Checking.Balance + amount);
                    Checking.Balance += amount;
                }
                else
                    Console.WriteLine("Insufficient balance in savings account for transfer amount of {0:c2}. Please enter smaller amount", amount);
            }
            else Console.WriteLine("Incorrect routing number");
        }
        public override string ToString()
        {
            return 
                string.Format("First Name: {0}\n", firstName) +
                string.Format("Last Name: {0}\n", lastName) +
                string.Format("Bank Name: {0}\n", bankName) +
                string.Format("Account Type: Savings\n") +
                string.Format("Routing Number: {0}\n", routingNumber) +
                string.Format("Account Number: {0}\n", accountNumber) +
                string.Format("Balance: {0:c2}\n", balance) +
                string.Format("Interest rate: {0}%\n", interestRate * 100);
        }

        ~Saving() { }
    }
}
