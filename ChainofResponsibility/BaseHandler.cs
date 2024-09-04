using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    public class BaseHandler : IHandler
    {
        protected IHandler _handler;
        public BaseHandler()
        {
            _handler = null;
        }
        public virtual void Process(Request request)
        {
            throw new NotImplementedException();
        }

        public  void SetNextHandler(IHandler nextHandler)
        {
            _handler = nextHandler;
        }
    }
}
