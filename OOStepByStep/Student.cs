using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Student : Person
    {
        private int? classNum;
        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, int classNum) : base(name, age)
        {
            this.classNum = classNum;
        }

        public override string SelfIntroduceMsg()
        {
            if(classNum == null)
            {
                return base.SelfIntroduceMsg() + " I am a student.";
            }
            else
            {
                return base.SelfIntroduceMsg() + $" I am a student of class {classNum}.";
            }
            
        }
    }
}
