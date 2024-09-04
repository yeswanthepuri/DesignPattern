using CommandDesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Commands
{
    public class ChangeFirstNameCommand : ICommand, IUndoCommand
    {
        private readonly PersonCommand _person;
        private readonly CommandHistory _commandHistory;
        private string _previousFirstName;
        public ChangeFirstNameCommand(PersonCommand person,CommandHistory commandHistory)
        {
            _person = person;
            _commandHistory = commandHistory;
        }
        public void Execute()
        {
            _previousFirstName = _person.FirstName;
            _person.FirstName = new Bogus.Faker().Person.FirstName;
            _commandHistory.Push(ClonePerson());
            Console.WriteLine($"{_person.LastName}{_person.FirstName}");
        }
        public void Undo()
        {
            if(_previousFirstName != null)
            {
                _person.FirstName = _previousFirstName;
            }
            Console.WriteLine($"{_person.LastName}{_person.FirstName}");
        }
        private ChangeFirstNameCommand ClonePerson()
        {
            ChangeFirstNameCommand changeFirstNameCommand = new ChangeFirstNameCommand(_person, _commandHistory);
            changeFirstNameCommand._previousFirstName = _previousFirstName;
            return changeFirstNameCommand;
        }
    }
}
