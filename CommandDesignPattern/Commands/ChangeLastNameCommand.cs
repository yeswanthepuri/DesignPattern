using CommandDesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Commands
{
    public class ChangeLastNameCommand : ICommand, IUndoCommand
    {
        private readonly PersonCommand _person;
        private readonly CommandHistory _commandHistory;

        private string _previousLastName;
        public ChangeLastNameCommand(PersonCommand person, CommandHistory commandHistory)
        {
            _person = person;
            _commandHistory = commandHistory;
        }
        public void Execute()
        {
            _previousLastName = _person.LastName;
            _person.LastName = new Bogus.Faker().Person.LastName;
            _commandHistory.Push(ClonePerson());
            Console.WriteLine($"{_person.LastName}{_person.FirstName}");
        }
        public void Undo()
        {
            if (_previousLastName != null)
            {
                _person.LastName = _previousLastName;
            }
            Console.WriteLine($"{_person.LastName}{_person.FirstName}");
        }
        private ChangeLastNameCommand ClonePerson()
        {
            ChangeLastNameCommand changeFirstNameCommand = new ChangeLastNameCommand(_person, _commandHistory);
            changeFirstNameCommand._previousLastName = _previousLastName;
            return changeFirstNameCommand;
        }
    }
}
