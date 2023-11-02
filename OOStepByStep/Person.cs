using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOStepByStep
{
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person(string name, int age, int classNumber)
        {
            Name = name;
            Age = age;
            ClassNumber = classNumber;
        }

        private string Name { get; set; }
        private int Age { get; set; }
        private int ClassNumber { get; set; }

        public virtual string Introduce()
        {
            return $"My name is {Name}. I am {Age} years old.";
        }

        public string GenerateClassIntroduce()
        {
            return ClassNumber == 0 ? string.Empty : $" of class {ClassNumber}";
        }
    }
}
