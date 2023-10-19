using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class AddCommand : ICommand
    {
        private RaceTimer _raceTimer;
        private int _newNumber;
        public AddCommand(RaceTimer editor, int x)
        {
            this._raceTimer = editor;
            _newNumber = x;
        }
        public void Execute()
        {
            this._raceTimer.AddAmount(_newNumber);
        }
    }
}
