using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW09_01
{
    class BankAccount
    {
        // data members
        protected int accountNumber, routingNumber;
        protected double balance, interestRate;
        protected string firstName, lastName, bankName;

        // constructors
        public BankAccount()
        {
            bankName = "unknown";
            routingNumber = 0;
            interestRate = 0;
            accountNumber = 0;
            balance = 0;
            firstName = "John";
            lastName = "Smith";
        }
        public BankAccount(string first, string last, string bank, int routing, int acctNum, double bal, double apr)
        {
            bankName = bank;
            routingNumber = routing;
            accountNumber = acctNum;
            firstName = first;
            lastName = last;
            balance = bal;
            interestRate = apr;
        }
        public void Deposit(double deposit)
        {
            balance += deposit;
            Console.WriteLine("Balance = {0:c2} after deposit of {1:c2}", balance, deposit);
        }
        public void Withdraw(double withdraw)
        {
            if (withdraw > balance)
                Console.WriteLine("Insufficient balance for withdrawal amount of {0:c2}. Please enter small amount", withdraw);
            else
            {
                balance -= withdraw;
                Console.WriteLine("Balance = {0:c2} after withdraw of {1:c2}", balance, withdraw);
            }
        }
        public void CalculateInterest()
        {
            Console.WriteLine("Yearly interest at {0}% APR = {1:c2}", interestRate*100, interestRate*balance);
        }
        public string BankName
        {
            get { return bankName; }
            set { bankName = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { if (value >= 0) balance = value; else balance = 0; }
        }
        public double InterestRate
        {
            get { return interestRate; }
            set { if (value >= 0) interestRate = value; else interestRate = 0; }
        }
        public int AccountNumber
        {
            get { return accountNumber; }
            set { if (value >= 0) accountNumber = value; else accountNumber = 0; }
        }
        public int RoutingNumber
        {
            get { return routingNumber; }
            set { if (value >= 0) routingNumber = value; else routingNumber = 0; }
        }

        public override string ToString()
        {
            return string.Format("First Name: {0}\n", firstName) +
                string.Format("Last Name: {0}\n", lastName) +
                string.Format("Bank Name: {0}\n", bankName) +
                string.Format("Routing Number: {0}\n", routingNumber) +
                string.Format("Account Number: {0}\n", accountNumber) +
                string.Format("Balance: {0:c2}\n", balance) +
                string.Format("Interest rate: {0}%\n", interestRate*100);
        }
        ~BankAccount() { }
    }
}
