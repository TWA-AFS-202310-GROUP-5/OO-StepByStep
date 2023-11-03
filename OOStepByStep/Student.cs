﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Student : Person
    {
        public Student() { }

        public Student(string name, int age) :base(name, age){ }

        public override string Introduce()
        {
            var classInfo = ClassId == null ? "" : $" I am a student of class {ClassId}.";
            return base.Introduce() + " I am a student." + classInfo;
        }

    }
}
