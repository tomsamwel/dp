using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class IncreaseCommand : ICommand
    {
        private RaceTimer _raceTimer;
        public IncreaseCommand(RaceTimer editor)
        {
            this._raceTimer = editor;
        }
        public void Execute()
        {
            this._raceTimer.IncreaseAmount();
        }
    }
}
