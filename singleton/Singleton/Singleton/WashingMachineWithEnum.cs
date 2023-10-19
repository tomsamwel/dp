using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public enum WashingMachineEnum
    {
        INSTANCE
    }
    public static class WashingMachineWithEnum
    {
        //Deze Class is bruikbaar voor MultiThread applicaties.
        private static bool _empty = true;
        private static bool _washed = false;

        private static int _instanceNumber = 1;
        public static void Fill(this WashingMachineEnum it)
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

        public static void Drain(this WashingMachineEnum it)
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

        public static void Wash(this WashingMachineEnum it)
        {
            Thread.Sleep(1000);
            if (!IsEmpty() && !IsWashed())
            {
                _washed = true;
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Wassen...");
                }
                Console.WriteLine("Wasmachine heeft gewassen");
            }
        }

        public static bool IsEmpty()
        {
            return _empty;
        }

        public static bool IsWashed()
        {
            return _washed;
        }

        public static string Message(this WashingMachineEnum it, string message)
        {
            return (message + _instanceNumber + "---");
        }

        public static void PrintInstanceNumber(this WashingMachineEnum it)
        {
            Console.Write("Number of instance is: " + _instanceNumber + "\n");
        }
    }
}
