using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class App
    {
        private readonly ICommand _action1Command;
        private readonly ICommand _action2Command;
        private readonly ICommand _undoCommand;

        public App(ICommand action1Command, ICommand action2Command, ICommand undoCommand)
        {
            _action1Command = action1Command;
            _action2Command = action2Command;
            _undoCommand = undoCommand;
        }
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Please enter a value A, B, C");
                ConsoleKey input = Console.ReadKey().Key; 
                Console.WriteLine("");
                switch (input)
                {
                    case ConsoleKey.A:
                        _action1Command.Execute();
                        break;
                    case ConsoleKey.B:
                        _action2Command.Execute();
                        break;
                    case ConsoleKey.C:
                        _undoCommand.Execute();
                        break;
                    default:
                        Console.WriteLine("INVALID INPUT");
                        break;
                }

            }
        }
    }
}
