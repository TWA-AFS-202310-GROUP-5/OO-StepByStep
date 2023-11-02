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
        private readonly string name;
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
            this.classNumber = classNumber;
        }

        public virtual string Introduce()
        {
            return $"My name is {name}. I am {age} years old.";
        }

        public void Welcome(Student newStudent)
        {
            Console.WriteLine($"{Introduce()} Welcome {newStudent.name} join class {classNumber}.");
        }

        public string GenerateClassIntroduce()
        {
            return GetClassNumber() == 0 ? string.Empty : $" of class {classNumber}";
        }

        public void SetClassNumber(int value)
        {
            classNumber = value;
        }

        private int GetClassNumber()
        {
            return classNumber;
        }
    }
}
