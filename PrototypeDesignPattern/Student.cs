using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    public class Student : Person
    {

        public Teacher Teacher { get; set; }
        public Student(string name, Teacher teacher) : base(name)
        {
            Teacher = teacher;
        }

        public override Person Clone()
        {
            Student studentclone = (Student)MemberwiseClone();
            studentclone.Teacher = new Teacher(this.Teacher.Name, this.Teacher.Cource);
           return studentclone;
        }
    }
}
