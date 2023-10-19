using Façade.Controller;
using Façade.Model;

namespace Façade
{
    public class Facade
    {
        private TvController _tvController = new TvController();
        private SpeakerController _speakerController = new SpeakerController();
        private StofzuigerController _stfzuigerController = new StofzuigerController();
        private SmartLampController _smartLampController = new SmartLampController();

        public void SwitchTvPower() => _tvController.PressPower();
        public void TurnVolumeTvUp() => _tvController.VolumeUp();
        public void TurnVolumeTvDown() => _tvController.VolumeDown();
        public void TurnVolumeSpeakerUp() => _speakerController.VolumeUp();
        public void TurnVolumeSpeakerDown() => _speakerController.VolumeDown();
        public void StartVacuuming() => _stfzuigerController.SetState(State.Vacuuming);
        public void StopVacuuming() => _stfzuigerController.SetState(State.Returning);
        public void IncreaseBrightness() => _smartLampController.SetBrightness(_smartLampController.GetBrightness() + 5);
        public void DecreaseBrightness() => _smartLampController.SetBrightness(_smartLampController.GetBrightness() - 5);
        public void TurnEverythingDown()
        {
            _speakerController.VolumeDown();
            _tvController.VolumeDown();
        }
        public void TurnEverythingUp()
        {
            _tvController.VolumeUp();
            _speakerController.VolumeUp();
        }
        public void MovieTime()
        {
            while(_speakerController.GetVolume() != 0) { _speakerController.VolumeDown(); Thread.Sleep(200); }
            for (int i = 0; i < 20; i++) { _tvController.VolumeUp(); Thread.Sleep(500 / (i > 0 ? i : 1)); }
            
            _stfzuigerController.SetState(State.Returning);
            _smartLampController.SetBrightness(20);
            _tvController.SwitchChannel("Film 1");
        }


    }
}
