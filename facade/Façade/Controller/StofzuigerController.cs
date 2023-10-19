using Façade.Model;

namespace Façade.Controller
{
    public class StofzuigerController
    {
        private State _state = State.Home;

        public State GetState() => _state;

        public void SetState(State state)
        {
            if (state == _state) Console.WriteLine($"Vacuum: Already {state}");
            else if (_state == State.Home && state == State.Vacuuming)
                SetStateVacuuming();
            else if (_state == State.Vacuuming && state == State.Returning)
                SetStateReturning();
            else if (state == State.Returning && _state == State.Home)
                Console.WriteLine($"Vacuum: I am home already");
            else if (state == State.Home) Console.WriteLine($"Vacuum: You can't decide when I am home");
        }

        private void SetStateVacuuming()
        {
            Console.WriteLine($"Vacuum: Starting to vacume");
            _state = State.Vacuuming;
            return;
        }

        private void SetStateReturning()
        {
            Console.WriteLine($"Vacuum: Returning to home, ETA 10s");
            _state = State.Returning;
            ReturnHome();
        }

        private async void ReturnHome()
        {
            await Task.Delay(10000);
            if (_state == State.Returning)
            {
                Console.WriteLine($"Vacuum: I am home");
                _state = State.Home;
            }
        }
    }
}
