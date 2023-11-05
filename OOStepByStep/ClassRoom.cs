using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class ClassRoom
    {
        private Teacher? teacher;
        private List<Student> students = new List<Student>();

        private int classNum;
        public ClassRoom(int classNum)
        {
            this.classNum = classNum;
        }

        public void SetTeacher(Teacher teacher)
        {
            teacher.ClassNum = classNum;
            this.teacher = teacher;
        }

        public void AddStudent(Student student)
        {
            student.ClassNum = classNum;
            this.students.Add(student);
        }

        public string Join(Student stu)
        {
            StringBuilder msg = new StringBuilder();
            msg.AppendLine(teacher.SelfIntroduceMsg() + teacher.Welcome(stu.Name));
            foreach (var student in students)
            {
                msg.AppendLine(student.SelfIntroduceMsg() + student.Welcome(stu.Name));
            }
            stu.ClassNum = classNum;
            this.students.Add(stu);
            return msg.ToString();
        }
    }
}
