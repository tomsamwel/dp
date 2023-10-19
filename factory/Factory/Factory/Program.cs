using Factory.Factories;

namespace Factory
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Logistics roadLogistics = new RoadLogistics();
            Logistics seaLogistics = new SeaLogistics();

            roadLogistics.PlanDelivery(); // Output: Planning delivery... Cargo delivered by land (Truck).
            seaLogistics.PlanDelivery();  // Output: Planning delivery... Cargo delivered by sea (Ship).
        }
    }
}