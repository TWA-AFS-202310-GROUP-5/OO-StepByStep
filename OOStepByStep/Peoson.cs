namespace OOStepByStep
{
    using Microsoft.VisualBasic;
    using System;
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string SelfIntroduce()
        {
            return $"My name is {name}. I am {age} years old.";
        }
    }
}
