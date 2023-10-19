using System.Diagnostics;

namespace Strategy {
    class Program {
        static void Main(string[] args) {
            var client = new Client();
            client.SetPricingStrategy(new DayPricing());

            client.UsePower(1);
            client.UsePower(1.2);

            client.SetPricingStrategy(new NightPricing());

            client.UsePower(5.1);
            client.UsePower(2);
            client.UsePower(3.6);
            client.UsePower(7);
            client.UsePower(1.2);
            client.UsePower(0.8);
            client.UsePower(12.7);
            // It turns out this client is running a secret meth lab at night

            Debug.Assert(client.TotalMoneySpent == 7.14, $"Client spend {client.TotalMoneySpent} instead of 7.14.");
        }
    }
}
