using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Invoker_Queue
    {
        private readonly Queue<ICommand> _queue = new Queue<ICommand>();
        //can be used for an undo button
        //private readonly Queue<ICommand> _commandHistory = new Queue<ICommand>();

        public void addCommand(ICommand cmd)
        {
            _queue.Enqueue(cmd);
        }

        public void ExecuteCommands()
        {
           while(_queue.Count > 0)
            {
                ICommand cmd = _queue.Dequeue();
                cmd.Execute();
            }
        }
    }
}
