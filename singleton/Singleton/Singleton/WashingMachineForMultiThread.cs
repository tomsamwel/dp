using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class WashingMachineForMultiThread: IWashingMachine
    {
        //Deze Class is bruikbaar voor MultiThread applicaties.
        private bool _empty;
        private bool _washed;

        private static int _instanceNumber = 0;

        private static WashingMachineForMultiThread? _uniqueInstance;
        private static readonly object InstanceLock = new object();
        public static WashingMachineForMultiThread GetInstance
        {
            get
            {
                if (_uniqueInstance == null)
                {
                    lock (InstanceLock)
                    {
                        if (_uniqueInstance == null)
                        {
                            _uniqueInstance = new WashingMachineForMultiThread();
                        }
                    }
                }
                return _uniqueInstance;
            }
        }
        private WashingMachineForMultiThread()
        {
            ++_instanceNumber;
            _empty = true;
            _washed = false;
        }

        public void Fill()
        {
            Thread.Sleep(1000);
            if (IsEmpty())
            {
                _empty = false;
                _washed = false;
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("vullen...");
                }
                Console.WriteLine("Wasmachine is gevuld");
            }
        }

        public void Drain()
        {
            Thread.Sleep(1000);
            if (!IsEmpty() && IsWashed())
            {
                _empty = true;
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("legen...");
                }
                Console.WriteLine("Wasmachine is geleegd");
            }
        }

        public void Wash()
        {
            Thread.Sleep(1000);
            if (!IsEmpty() && !IsWashed())
            {
                _washed = true;
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("wassen...");
                }
                Console.WriteLine("Wasmachine heeft gewassen");
            }
        }

        public bool IsEmpty()
        {
            return _empty;
        }

        public bool IsWashed()
        {
            return _washed;
        }

        public string Message(string message)
        {
            return (message + _instanceNumber + "---");
        }
        public void PrintInstanceNumber()
        {
            Console.Write("Number of instance is: " + _instanceNumber + "\n");
        }
    }
}
