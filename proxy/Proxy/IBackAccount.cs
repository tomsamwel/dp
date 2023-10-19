using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public interface IBackAccount
    {
        double CheckBalance(string customer);
        void WithDraw(string customer, double amount);
    }
}
