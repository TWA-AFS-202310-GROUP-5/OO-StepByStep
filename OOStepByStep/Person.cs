﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Person
    {
        private string name;
        public string Name { get; }
        private int age;
        public Person(string name, int age) 
        {
            this.name = name;
            this.age = age;
        }

        public virtual string SelfIntroduceMsg()
        {
            return $"My name is {name}. I am {age} years old.";
        }
    }
}
