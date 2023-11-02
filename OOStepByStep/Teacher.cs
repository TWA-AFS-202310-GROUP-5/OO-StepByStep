using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        private string newStudentName;
        private int classId;

        public Teacher(string name, int age) : base(name, age)
        {
        }

        public Teacher(string name, int age, int classId) : base(name, age)
        {
            this.classId = classId;
        }

        public Teacher(int classId) : base()
        {
            this.classId = classId;
        }

        public string NewStudentName { get => newStudentName; set => newStudentName = value; }
        public override string SelfIntroduce()
        {
            if (classId != 0 && NewStudentName == null)
            {
                return base.SelfIntroduce() + $" I am a teacher of class {classId}.";
            }
            else if (classId == 0 && NewStudentName == null)
            {
                return base.SelfIntroduce() + $" I am a teacher.";
            }
            else
            {
                return base.SelfIntroduce() + $" I am a teacher of class {classId}. Welcome {newStudentName} join class {classId}.";
            }
        }
    }
}
