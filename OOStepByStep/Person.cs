using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Person
    {
        public string Name { get; }
        public int Age { get; }
        public Person(string name, int age) 
        {
            Name = name;
            Age = age;
        }

        public virtual string SelfIntroduceMsg()
        {
            return $"My name is {Name}. I am {Age} years old.";
        }
    }
}
