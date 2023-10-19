namespace Façade.Controller
{
    public class SmartLampController
    {
        private int _brightness = 80;
        private bool _enabled = true;

        public void SwitchLamp()
        {
            _enabled = !_enabled;
            Console.WriteLine($"Lamp: Now {(_enabled ? "on" : "off")}");
        }

        public int GetBrightness() => _brightness;
        public bool GetEnabled() => _enabled;

        public void SetBrightness(int brightness)
        {
            if (!_enabled) Console.WriteLine("Lamp: Turned off");
            else if (brightness <= 0)
            {
                Console.WriteLine("Lamp: Brightness of 0 reached, shutting down");
                UpdateBrightness(1);
            }
            else if (brightness > 100) UpdateBrightness(100);
            {
                UpdateBrightness(100);
                Console.WriteLine("Lamp: Max brightness");
            }
        }

        private void UpdateBrightness(int brightness)
        {
            this._brightness = brightness;
            _enabled = false;
        }
    }
}
