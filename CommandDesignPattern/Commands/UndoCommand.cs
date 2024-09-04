using CommandDesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Commands
{
    public class UndoCommand : ICommand
    {
        private readonly CommandHistory _history;
        private string _previousLastName;
        public UndoCommand(CommandHistory history)
        {
            _history = history;
        }
        public void Execute()
        {
            IUndoCommand undoCommand = _history.Pop();
            undoCommand?.Undo();
        }
       
    }
}
