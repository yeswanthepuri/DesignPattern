

namespace ChainofResponsibility
{
    public class MaxageHandler : BaseHandler
    {
        public override void Process(Request request)
        {
            if (request.Data is PersonDetails person)
            {
                if (person.Age > 70)
                {
                    request.ValidationMessages.Add("You can't have age more then 70");
                    if (_handler != null)
                    {
                        _handler.Process(request);
                    }
                }
            }
            else
            {
                throw new Exception("Invalid Object");
            }
        }
    }
    public class NameHandler : BaseHandler
    {
        public override void Process(Request request)
        {
            if (request.Data is PersonDetails person)
            {
                if (string.IsNullOrWhiteSpace(person.Name))
                {
                    request.ValidationMessages.Add("Name Can't be empty");
                    if (_handler != null)
                    {
                        _handler.Process(request);
                    }
                }
            }
            else
            {
                throw new Exception("Invalid Object");
            }
        }
    }
    public class IncomeHandler : BaseHandler
    {
        public override void Process(Request request)
        {
            if (request.Data is PersonDetails person)
            {
                if (person.Income < 200)
                {
                    request.ValidationMessages.Add("We can't consider people with less then 200$ for this policy");
                    if (_handler != null)
                    {
                        _handler.Process(request);
                    }
                }
            }
            else
            {
                throw new Exception("Invalid Object");
            }
        }
    }
}
