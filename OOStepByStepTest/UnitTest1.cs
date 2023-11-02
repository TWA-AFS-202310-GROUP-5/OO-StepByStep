namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class PersonTest
    {
        [Fact]
        public void Should_return_message_include_name_age_when_introduce_given_person()
        {
            //Given
            Person person = new Person("Tom", 21);

            //When
            string result = person.Introduce();

            //Then
            Assert.Equal("My name is Tom. I am 21 years old.", result);
        }
    }

    public class StudentTest
    {
        [Fact]
        public void Should_return_message_include_name_age_student_when_introduce_given_student()
        {
            //Given
            Student student = new Student("Tom", 21);

            //When
            string result = student.Introduce();

            //Then
            Assert.Equal("My name is Tom. I am 21 years old. I am a student.", result);
        }
    }

    public class TeacherTest
    {
        [Fact]
        public void Should_return_message_include_name_age_teacher_when_introduce_given_teacher()
        {
            //Given
            Teacher teacher = new Teacher("Amy", 30);

            //When
            string result = teacher.Introduce();

            //Then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", result);
        }
    }

    public class ClassTest
    {
        [Fact]
        public void Should_return_message_include_name_age_student_class_when_introduce_given_student()
        {
            //Given
            Class class2 = new Class("2");
            Student student = new Student("Tom", 21);
            class2.Add(student);

            //When
            string result = student.Introduce();

            //Then
            Assert.Equal("My name is Tom. I am 21 years old. I am a student of class 2.", result);
        }

        [Fact]
        public void Should_return_message_include_name_age_teacher_class_when_introduce_given_teacher()
        {
            //Given
            Class class2 = new Class("2");
            Teacher teacher = new Teacher("Amy", 30);
            class2.Add(teacher);

            //When
            string result = teacher.Introduce();

            //Then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2.", result);
        }

        [Fact]
        public void Should_return_message_include_name_age_student_class_incomerName_when_welcome_given_student()
        {
            //Given
            Class class2 = new Class("2");
            Student student = new Student("Tom", 21);
            Student incommer = new Student("Jim", 20);
            class2.Add(student);

            //When
            string result = class2.Add(incommer);

            //Then
            Assert.Equal("My name is Tom. I am 21 years old. I am a student of class 2. Welcome Jim join class 2.", result);
        }

        [Fact]
        public void Should_return_message_include_name_age_teacher_class_incomerName_when_welcome_given_teacher()
        {
            //Given
            Class class2 = new Class("2");
            Teacher teacher = new Teacher("Amy", 30);
            Student incommer = new Student("Tom", 21);
            class2.Add(teacher);

            //When
            string result = class2.Add(incommer);

            //Then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2. Welcome Tom join class 2.", result);
        }

        [Fact]
        public void Should_return_message_include_name_age_job_class_incomerName_when_welcome_given_student_and_teacher()
        {
            //Given
            Class class2 = new Class("2");
            Teacher teacher = new Teacher("Amy", 30);
            Student student1 = new Student("Tom", 21);
            Student student2 = new Student("Tim", 22);
            Student incommer = new Student("Jim", 20);
            class2.Add(teacher);
            class2.Add(student1);
            class2.Add(student2);

            //When
            string result = class2.Add(incommer);

            //Then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2. Welcome Jim join class 2.\nMy name is Tom. I am 21 years old. I am a student of class 2. Welcome Jim join class 2.\nMy name is Tim. I am 22 years old. I am a student of class 2. Welcome Jim join class 2.", result);
        }
    }
}
