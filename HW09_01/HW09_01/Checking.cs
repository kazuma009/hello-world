using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW09_01
{
    class Checking: BankAccount
    {

        // constructors
        public Checking(): base()
        { }
        public Checking(string first, string last, string bank, int routing, int acctNum, double bal, double apr) : base(first, last, bank, routing, acctNum, bal, apr)
        { }
        public void WriteCheck(double amount)
        {
            Console.WriteLine("{0} {1} of account number {2}", firstName, lastName, accountNumber);
            if (amount > balance)
            {
                double penalty = 0.1 * amount;
                balance -= penalty;
                Console.WriteLine("The check for {0:c2} bounced due to insufficient fund. \nThe checking account was penalized 10% ({1:c2}) of the check",amount, penalty);
                Console.WriteLine("New balance = {0:c2}", balance);
            }
            else
            {
                balance -= amount;
                Console.WriteLine("Balance = {0:c2} after writing check of {1:c2}", balance, amount);
            }
        }
        public void TransferToSaving(double amount, int routing, BankAccount Saving)
        {
            
            if (routing == Saving.RoutingNumber)
            {
                Console.WriteLine("{0} {1} of account number {2}", firstName, lastName, accountNumber);
                if (amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine("Transferred {0:c2} to savings account number {1} with routing number {2}", amount, Saving.AccountNumber, Saving.RoutingNumber);
                    Console.WriteLine("Old checking balance: {0:c2}, new checking balance: {1:c2}", balance + amount, balance);
                    Saving.Balance += amount;
                }
                else
                    Console.WriteLine("Insufficient balance in checking account for transfer amount of {0:c2}. Please enter smaller amount", amount);
            }
            else Console.WriteLine("Incorrect routing number");
        }
        public override string ToString()
        {
            return 
                string.Format("First Name: {0}\n", firstName) +
                string.Format("Last Name: {0}\n", lastName) +
                string.Format("Bank Name: {0}\n", bankName) +
                string.Format("Account Type: Checking\n") +
                string.Format("Routing Number: {0}\n", routingNumber) +
                string.Format("Account Number: {0}\n", accountNumber) +
                string.Format("Balance: {0:c2}\n", balance) +
                string.Format("Interest rate: {0}%\n", interestRate * 100);
        }

        ~Checking() { }
    }
}
