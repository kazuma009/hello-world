using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW09_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Instantiate checking object...");
            Checking c1 = new Checking("Jimmy", "Broke", "Citibank", 322271724, 9833482, 400, 0.001);
            Console.WriteLine(c1);
            Console.WriteLine("Jimmy deposited $10.04, then withdrew $5.89");
            c1.Deposit(10.04);
            c1.Withdraw(5.89);
            c1.CalculateInterest();
            Console.WriteLine("Jimmy wrote a check for $500 to buy a new TV");
            c1.WriteCheck(500);

            Console.WriteLine("\nInstantiate savings object...");
            Saving s1 = new Saving("Richie", "Rich", "Chase", 322271627, 1122345, 9999999.99, 0.01);
            Console.WriteLine(s1);
            Console.WriteLine("Richie deposited $9999, then withdrew $88888.88");
            s1.Deposit(9999);
            s1.Withdraw(88888.88);
            s1.CalculateInterest();
            Console.WriteLine("\nRichie was sympathetic to Jimmy's plight and decided to help out");
            s1.TransferToChecking(9876.88, 322271724, c1);
            Console.WriteLine("\nJimmy was grateful to Richie and used the money to buy a $1500 4K TV");
            c1.WriteCheck(1500);
            Console.WriteLine("\nJimmy returned $1000 back to Richie");
            c1.TransferToSaving(1000, 322271627, s1);
     
            Console.WriteLine("\n" + c1);
            Console.WriteLine(s1);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
