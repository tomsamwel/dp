using System;

namespace Factory.Classes
{
    class Truck : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Cargo delivered by land (Truck).");
        }
    }
}