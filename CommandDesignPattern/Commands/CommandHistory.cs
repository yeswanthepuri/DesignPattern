using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Commands
{
    public class CommandHistory
    {
        private readonly Stack<IUndoCommand> history;
        public CommandHistory()
        {
            history = new Stack<IUndoCommand>();
        }
        public void Push(IUndoCommand command) {
            history.Push(command);
        }
        public IUndoCommand Pop()
        {
            if(history.Count == 0)
            {
                return null;
            }
            return history.Pop();
        }
    }
}
