namespace OOStepByStep
{
    using System;
    public class Person
    {
        private string name;
        private int age;
        private IOrganizationInfo organizationInfo;

        public Person()
        {
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person(string name, int age, IOrganizationInfo organizationInfo)
        {
            this.name = name;
            this.age = age;
            this.organizationInfo = organizationInfo;
        }

        public IOrganizationInfo OrganizationInfo => organizationInfo;

        public string Name => name;

        public virtual string Introduce()
        {
            return $"My name is {name}. I am {age} years old.";
        }

        public void Print()
        {
            Console.WriteLine(Introduce());
        }
    }
}