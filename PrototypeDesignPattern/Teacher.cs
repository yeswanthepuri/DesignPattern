using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    public class Teacher : Person
    {
        public Teacher(string name,string course) : base(name)
        {
            Cource = course;
        }

        public string Cource { get; set; }
        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
}
