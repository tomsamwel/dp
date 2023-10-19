using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class DecreaseCommand : ICommand
    {
        private RaceTimer _raceTimer;
        public DecreaseCommand(RaceTimer editor)
        {
            this._raceTimer = editor;
        }
        public void Execute()
        {
            this._raceTimer.DecreaseAmount();
        }
    }
}
