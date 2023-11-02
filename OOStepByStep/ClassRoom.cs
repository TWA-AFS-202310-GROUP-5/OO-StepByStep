using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class ClassRoom
    {
        private List<Student> students;
        private Teacher teacher;
        private int classNumber;

        public ClassRoom(int v)
        {
            V = v;
        }

        public int V { get; }

        public void AddStudent(Student studentA)
        {
            throw new NotImplementedException();
        }

        public void AddTeacher(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
