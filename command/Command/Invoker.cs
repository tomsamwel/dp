using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Invoker
    {
        private ICommand _increase;
        private ICommand _decrease;
        private ICommand _set;
        private ICommand _add;
        private ICommand _subtract;
        private ICommand _undo;

        public void setIncrease(ICommand increase)
        {
            _increase = increase;
        }
        public void setDecrease(ICommand decrease)
        {
            _decrease = decrease;
        }
        public void setSet(ICommand set)
        {
            _set = set;
        }
        public void setAdd(ICommand add)
        {
            _add = add;
        }
        public void setSubtract(ICommand subtract)
        {
            _subtract = subtract;
        }
        public void setUndo(ICommand undo)
        {
            _undo = undo;
        }

        public void ExecuteCommands()
        {
            if(this._increase is ICommand)
            {
                this._increase.Execute();
                this._increase = null;
            }
            if (this._decrease is ICommand)
            {
                this._decrease.Execute();
                this._decrease = null;
            }
            if (this._set is ICommand)
            {
                this._set.Execute();
                this._set = null;
            }
            if (this._add is ICommand)
            {
                this._add.Execute();
                this._add = null;
            }
            if (this._subtract is ICommand)
            {
                this._subtract.Execute();
                this._subtract = null;
            }
            if (this._undo is ICommand)
            {
                this._undo.Execute();
                this._undo = null;
            }
        }
    }
}
