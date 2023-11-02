using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Class
    {
        private int classId;
        private Teacher teacher;
        private List<Student> students;

        public Class(int classId)
        {
            this.classId = classId;
            this.teacher = new Teacher(classId);
            this.students = new List<Student>(classId);
        }

        public Teacher Teacher_ { get => teacher; set => teacher = value; }
        public List<Student> Students_ { get => students; set => students = value; }

        public void JoinStudent(string newStudentName, int newStudentAge)
        {
            Student newStudent = new Student(newStudentName, newStudentAge, classId);

            teacher.NewStudentName = newStudentName;

            foreach (Student student in students)
            {
                student.NewStudentName = newStudentName;
            }

            students.Add(newStudent);
        }
    }
}
