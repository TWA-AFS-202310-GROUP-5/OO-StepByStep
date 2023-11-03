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
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public int Age { get => age; set => age = value; }

        public string Name => name;

        public virtual string Introduce()
        {
            return $"My name is {Name}. I am {Age} years old.";
        }

        public virtual void Welcome(Person person)
        {
        }
    }
}
