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

        public string Add(Person person)
        {
            if (person.OrganizationInfo is SchoolPersonnel)
            {
                SchoolPersonnel schoolPersonnel = (SchoolPersonnel)person.OrganizationInfo;
                string msg = Welcome(person.Name);

                AddToClass(person);

                schoolPersonnel.UpdateClass(className);

                return msg;
            }

            return string.Empty;
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

        private void AddToClass(Person person)
        {
            teacher = person is Teacher ? (Teacher)person : teacher;

            if (person is Student)
            {
                students.Add((Student)person);
            }
        }
    }
}