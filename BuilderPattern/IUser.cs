using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface IUser
    {
        public int Id { get; }
        public string Name { get; }
        public string Address { get; }
        public int Age { get; }
    }
}
