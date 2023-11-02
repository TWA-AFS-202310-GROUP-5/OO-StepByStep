using System.Collections.Generic;

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
            person.UpdateClass(className);

            if (person is Teacher)
            {
                teacher = (Teacher)person;
            }

            if (person is Student)
            {
                students.Add((Student)person);
            }

            return string.Empty;
        }
    }
}
