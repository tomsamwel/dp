using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class AccessProxy : IBackAccount
    {
        private IBackAccount _bankAccount;
        private string _owner;
        public AccessProxy(IBackAccount bankAccount, string owner)
        {
            _bankAccount = bankAccount;
            _owner = owner;
        }

        private bool IsOwner(string customer)
        {
            return _owner == customer;
        }

        public double CheckBalance(string customer)
        {
            if (!IsOwner(customer)) throw new AccessDeniedException();
            return _bankAccount.CheckBalance(customer);
        }

        public void WithDraw(string customer, double amount)
        {
            if (!IsOwner(customer)) throw new AccessDeniedException();
            _bankAccount.WithDraw(customer, amount);
        }

        
    }
    public class AccessDeniedException : Exception
    {
        public AccessDeniedException()
        {
            System.Console.WriteLine("Access Denied");
        }

        public AccessDeniedException(string? message) : base(message)
        {
        }

        public AccessDeniedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected AccessDeniedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
