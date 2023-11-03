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

        public string Add(Teacher teacher)
        {
            string msg = GenerateWelcomeMsg(teacher);
            this.teacher = teacher;
            return msg;
        }

        public string Add(Student student)
        {
            string msg = GenerateWelcomeMsg(student);
            students.Add(student);
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

        private string GenerateWelcomeMsg(Person person)
        {
            SchoolPersonnel schoolPersonnel = (SchoolPersonnel)person.OrganizationInfo;
            string msg = Welcome(person.Name);
            schoolPersonnel.UpdateClass(className);

            return msg;
        }
    }
}