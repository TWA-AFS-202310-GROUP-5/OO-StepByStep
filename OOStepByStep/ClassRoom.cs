using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class ClassRoom
    {
        private int classNumber;
        private List<Student> students;
        private Teacher teacher;

        public ClassRoom(int number)
        {
            ClassNumber = number;
            Students = new List<Student>();
        }

        public int ClassNumber
        {
            get
            {
                return classNumber;
            }

            set
            {
                if (Validation.IsValidClassNumber(value))
                {
                    classNumber = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public List<Student> Students { get => students; set => students = value; }
        public Teacher Teacher { get => teacher; set => teacher = value; }

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
