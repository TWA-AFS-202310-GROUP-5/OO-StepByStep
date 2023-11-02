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
        private int classNumber;

        public Teacher(string name, int age) : base(name, age)
        {
        }

        public Teacher(string name, int age, int classNumber) : base(name, age)
        {
            this.classNumber = classNumber;
        }

        public override string SelfIntroduce()
        {
            if (classNumber != 0)
            {
                return base.SelfIntroduce() + $" I am a teacher of class {classNumber}.";
            }
            else
            {
                return base.SelfIntroduce() + $" I am a teacher.";
            }
        }
    }
}
