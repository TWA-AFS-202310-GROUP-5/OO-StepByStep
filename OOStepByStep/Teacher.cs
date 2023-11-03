using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        private int classNumber;
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public Teacher(string name, int age, int classNumber) : base(name, age)
        {
            ClassNumber = classNumber;
        }

        public int ClassNumber
        {
            get
            {
                return classNumber;
            }

            set
            {
                if (Validation.IsValidClassNumber(value))
                {
                    classNumber = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public override string Introduce()
        {
            return $"{base.Introduce()} I am a teacher{GenerateClassIntroduce()}.";
        }

        public override void Welcome(Person person)
        {
            Console.WriteLine($"{Introduce()} Welcome {person.Name} join class {ClassNumber}.");
        }

        public string GenerateClassIntroduce()
        {
            return ClassNumber == 0 ? string.Empty : $" of class {ClassNumber}";
        }
    }
}
