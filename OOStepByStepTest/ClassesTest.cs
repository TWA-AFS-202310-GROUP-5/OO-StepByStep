namespace OOStepByStepTest
{
    using OOStepByStep;
    using System.Collections.Generic;
    using Xunit;

    public class ClassesTest
    {
        [Fact] // AC1
        public void Should_return_introuduction_of_person_itself()
        {
            //given
            var person = new Person("Tom", 21);
            //when
            string introduce = person.SelfIntroduce();
            //then
            Assert.Equal("My name is Tom. I am 21 years old.", introduce);
        }

        [Fact] // AC2 - student
        public void Should_return_introuduction_of_student_itself()
        {
            //given
            var student = new Student("Tom", 18);
            //when
            string introduce = student.SelfIntroduce();
            //then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student.", introduce);
        }

        [Fact] // AC3 - student
        public void Should_return_introuduction_of_student_itself_belongs_to_a_class()
        {
            //given
            var student = new Student("Tom", 18, 2);
            //when
            string introduce = student.SelfIntroduce();
            //then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student of class 2.", introduce);
        }

        [Fact] // AC2 - teacher
        public void Should_return_introuduction_of_teacher_itself()
        {
            //given
            var teacher = new Teacher("Amy", 30);
            //when
            string introduce = teacher.SelfIntroduce();
            //then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", introduce);
        }

        [Fact] // AC3 - teacher
        public void Should_return_introuduction_of_teacher_itself_belongs_to_a_class()
        {
            //given
            var teacher = new Teacher("Amy", 30, 2);
            //when
            string introduce = teacher.SelfIntroduce();
            //then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2.", introduce);
        }

        [Fact] // AC4 - teacher
        public void Should_return_introuduction_of_teacher_itself_belongs_to_a_class_and_has_a_new_student()
        {
            //given
            int classId = 2;
            Class class_2 = new Class(classId);
            class_2.Teacher_ = new Teacher("Amy", 30, classId);

            //when
            class_2.JoinStudent("Tom", 5);
            string introduce = class_2.Teacher_.SelfIntroduce();
            //then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2. Welcome Tom join class 2.", introduce);
        }

        [Fact] // AC4 - student
        public void Should_return_introuduction_of_student_itself_belongs_to_a_class_and_has_a_new_student()
        {
            //given
            int classId = 2;
            Class class_2 = new Class(classId);
            class_2.Students_ = new List<Student>(classId);

            foreach (Student student in class_2.Students_)
            {
                //when
                class_2.JoinStudent("Jim", 9);
                string introduce = student.SelfIntroduce();
                //then
                Assert.Equal($"My name is {student.Name}. I am {student.Age} years old. I am a student of class 2. Welcome Jim join class 2.", introduce);
            }
        }
    }
}