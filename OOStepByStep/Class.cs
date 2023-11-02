using System;
using System.Collections.Generic;
using System.Linq;

namespace OOStepByStep
{
    public class Class
    {
        private Teacher teacher;
        private List<Student> students = new List<Student>();
        private string className;

        public Class(string className)
        {
            this.className = className;
        }

        public string Add(SchoolPersonnel person)
        {
            string msg = Welcome(person.Name);
            person.UpdateClass(className);

            if (person is Teacher)
            {
                teacher = (Teacher)person;
            }

            if (person is Student)
            {
                students.Add((Student)person);
            }

            return msg;
        }

        public string Welcome(string name)
        {
            string teacherWelcome = teacher?.Welcome(name) ?? string.Empty;
            string studentWelcome = string.Join('\n', students.Select(student => student.Welcome(name)));
            if (teacherWelcome != string.Empty && studentWelcome != string.Empty)
            {
                return teacherWelcome + '\n' + studentWelcome;
            }

            return teacherWelcome == string.Empty ? studentWelcome : teacherWelcome;
        }
    }
}
