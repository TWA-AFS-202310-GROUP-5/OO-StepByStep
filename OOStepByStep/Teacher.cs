using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        private int? classNum;
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public Teacher(string name, int age, int classNum) : base(name, age)
        {
            this.classNum = classNum;
        }
        public override string SelfIntroduceMsg()
        {
            if (classNum == null)
            {
                return base.SelfIntroduceMsg() + " I am a teacher.";
            }
            else
            {
                return base.SelfIntroduceMsg() + $" I am a teacher of class {classNum}.";
            }           
        }
    }
}
