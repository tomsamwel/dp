using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class SavingsAccount : IBackAccount
    {
        private double _balance = 0;
        private double _target = 0;
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
