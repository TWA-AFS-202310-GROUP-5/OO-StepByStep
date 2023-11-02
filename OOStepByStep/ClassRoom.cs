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

        public void SetTeacher(string name, int age)
        {
            this.teacher = new Teacher(name, age, classNum);
        }

        public void AddStudent(string name, int age)
        {
            this.students.Add(new Student(name, age, classNum));
        }

        public string Join(string name, int age)
        {
            StringBuilder msg = new StringBuilder();
            msg.AppendLine(teacher.SelfIntroduceMsg() + $" Welcome {name} join class {classNum}.");
            foreach (var stu in students)
            {
                msg.AppendLine(stu.SelfIntroduceMsg() + $" Welcome {name} join class {classNum}.");
            }
            this.students.Add(new Student(name, age, classNum));
            return msg.ToString();
        }
    }
}
