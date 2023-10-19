using System;
using Factory.Classes;

namespace Factory.Factories
{
    public abstract class Logistics
    {
        // The factory method
        public abstract ITransport CreateTransport();

        public void PlanDelivery()
        {
            ITransport transport = CreateTransport();
            Console.WriteLine("Planning delivery...");
            transport.Deliver();
        }
    }
}