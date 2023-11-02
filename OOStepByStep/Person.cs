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
        private int classNumber;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person(string name, int age, int classNumber)
        {
            this.name = name;
            this.age = age;
            this.ClassNumber = classNumber;
        }

        public int Age { get => age; set => age = value; }

        public string Name => name;

        public int ClassNumber { get => classNumber; set => classNumber = value; }

        public virtual string Introduce()
        {
            return $"My name is {Name}. I am {Age} years old.";
        }

        public void Welcome(Student newStudent)
        {
            Console.WriteLine($"{Introduce()} Welcome {newStudent.Name} join class {ClassNumber}.");
        }

        public string GenerateClassIntroduce()
        {
            return ClassNumber == 0 ? string.Empty : $" of class {ClassNumber}";
        }
    }
}
