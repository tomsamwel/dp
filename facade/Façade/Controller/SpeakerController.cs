using Façade.Model;
namespace Façade.Controller
{
    public class SpeakerController : IVolume
    {
        private int _volume = 0;

        public int GetVolume() => _volume;

        public void VolumeUp()
        {
            if (GetVolume() >= 50) Console.WriteLine("Speaker: Max volume");
            else
            {
                _volume+= 10;
                Console.WriteLine($"Speaker: Volume is now at {GetVolume()}");
            }
        }

        public void VolumeDown()
        {
            if (GetVolume() <= 0) Console.WriteLine("Speaker: Volume is muted");
            else
            {
                _volume-= 10;
                Console.WriteLine($"Speaker: Volume is now {GetVolume()}");
            }
        }
    }
}
