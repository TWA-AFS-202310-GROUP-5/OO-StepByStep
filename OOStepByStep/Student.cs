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
        //private Class class;
        private int classNumber;

        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, int classNumber) : base(name, age)
        {
            this.classNumber = classNumber;
        }

        public override string SelfIntroduce()
        {
            if (classNumber != 0)
            {
                return base.SelfIntroduce() + $" I am a student of class {classNumber}.";
            }
            else
            {
                return base.SelfIntroduce() + $" I am a student.";
            }
        }
    }
}
