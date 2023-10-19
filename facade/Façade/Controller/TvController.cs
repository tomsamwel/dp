using Façade.Model;
namespace Façade.Controller
{
    public class TvController : IVolume
    {
        private int _volume = 10;
        private bool _power = false;
        private string _channel = "NPO 1";

        public int GetVoulume() => _volume;

        public void PressPower()
        {
            Console.WriteLine(_power ? "TV: Already powered on, now switching off" : "TV: Switched on");
            _power = !_power;
        }

        public void VolumeUp()
        {
            if (!_power) Console.WriteLine("TV: Not powered on");
            else if (GetVoulume() >= 100) Console.WriteLine("TV: Max volume");
            else
            {
                _volume++;
                Console.WriteLine($"TV: Volume is now at {GetVoulume()}");
            }
        }

        public void VolumeDown()
        {
            if (!_power) Console.WriteLine("TV: Is not powered on");
            else if (GetVoulume() <= 0) Console.WriteLine("TV: Volume is muted");
            else
            {
                _volume--;
                Console.WriteLine($"TV: Volume is now at {GetVoulume()}");
            }
        }

        public string GetChannel() => _channel;

        public void SwitchChannel(string channel)
        {
            if (!_power) Console.WriteLine("Tv: Is not powered on");
            else
            {
                _channel = channel;
                Console.WriteLine($"TV: Now on channel {channel}");
            }
        }
    }
}
