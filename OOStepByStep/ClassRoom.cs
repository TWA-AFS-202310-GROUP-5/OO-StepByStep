using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class ClassRoom
    {
        public ClassRoom(int number)
        {
            ClassNumber = number;
            Students = new List<Student>();
        }

        private List<Student> Students { get; set; }
        private Teacher Teacher { get; set; }
        private int ClassNumber { get; set; }

        public void AddStudent(Student newStudent)
        {
            Teacher.Welcome(newStudent);
            Students.ForEach(student => student.Welcome(newStudent));
            newStudent.ClassNumber = ClassNumber;
            Students.Add(newStudent);
        }

        public void AddTeacher(Teacher teacher)
        {
            teacher.ClassNumber = ClassNumber;
            Teacher = teacher;
        }
    }
}
