using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_two
{
    internal class Saving_account:Account
    {
        public double rate;
        public Saving_account()
        {
            rate = 3.0;
        }
        public override void deposit(double amount)
        {
            base.deposit(amount);
            Console.WriteLine($"savingAccount -" +
               $" withdraw called with ammount {amount}");

        }
        public new void withdraw(double amount)
        {
            base.withdraw(amount);
            Console.WriteLine($"savingAccount -" +
               $" withdraw called with ammount {amount}");

              
        }
        public override void test()
        {
            Console.WriteLine("test");
        }


    }
}
