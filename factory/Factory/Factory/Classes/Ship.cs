using System;

namespace Factory.Classes
{
    class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Cargo delivered by sea (Ship).");
        }
    }
}