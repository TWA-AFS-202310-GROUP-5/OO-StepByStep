using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOStepByStep
{
    public class Student : Person
    {
        private string name;
        private int age;

        private string newStudentName;
        private int classId;

        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, int classId) : base(name, age)
        {
            this.classId = classId;
        }

        public Student(int classId) : base()
        {
            this.classId = classId;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public string NewStudentName { get => newStudentName; set => newStudentName = value; }
        public override string SelfIntroduce()
        {
            if (classId != 0 && NewStudentName == null)
            {
                return base.SelfIntroduce() + $" I am a student of class {classId}.";
            }
            else if (classId == 0 && NewStudentName == null)
            {
                return base.SelfIntroduce() + $" I am a student.";
            }
            else
            {
                return base.SelfIntroduce() + $" I am a student of class {classId}. Welcome {newStudentName} join class {classId}.";
            }
        }
    }
}
