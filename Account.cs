using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_two
{
    internal class Account
    {

        public double Balance { get; set; }
        public string Name { get; set; }
        public Account()
        {
            Balance = 0;
            Name = "account";
        }
        public virtual void deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Account - deposit called with ammount {amount}");
        }
        public void withdraw(double amount)
        {
            if (Balance >= amount) {
                Balance -= amount; }
            Console.WriteLine($"Account -" +
                $" withdraw called with ammount {amount}");

        }
        public virtual void test()
        {
         
        }
    }
}
