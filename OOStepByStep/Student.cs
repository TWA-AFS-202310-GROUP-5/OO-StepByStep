using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Student : Person
    {
        public int? ClassNum { get; set; }
        
        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, int classNum) : base(name, age)
        {
            this.ClassNum = classNum;
        }

        public override string SelfIntroduceMsg()
        {
            if(ClassNum == null)
            {
                return base.SelfIntroduceMsg() + " I am a student.";
            }
            else
            {
                return base.SelfIntroduceMsg() + $" I am a student of class {ClassNum}.";
            }
        }

        public string Welcome(string name)
        {
            return $" Welcome {name} join class {ClassNum}.";
        }
    }
}
