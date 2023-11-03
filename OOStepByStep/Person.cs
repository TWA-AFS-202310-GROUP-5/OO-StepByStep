using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string ClassId { get; set; }

        public Person(){}

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual string Introduce()
        {
            return $"I am {Name}. I am {Age} years old.";
        }
    }
}
