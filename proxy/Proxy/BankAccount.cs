using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class BankAccount : IBackAccount
    {
        public readonly static double DEFAULT_BALANCE = 100.00;
        private double  _balance;

        public BankAccount()
        {
            _balance = BankAccount.DEFAULT_BALANCE;
        }

        public double CheckBalance(string customer)
        {
            return _balance;
        }

        public void WithDraw(string customer, double amount)
        {
            if (_balance - amount < 0)
                throw new ArgumentException("The amount is too high.");
            _balance -= amount;
        }
    }
}
