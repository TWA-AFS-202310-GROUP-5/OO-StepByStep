using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Person
    {
        public Person(string n, int a)
        {
            Name = n;
            Age = a;
        }

        private string Name { get; set; }
        private int Age { get; set; }

        public object Introduce()
        {
            throw new NotImplementedException();
        }
    }
}
