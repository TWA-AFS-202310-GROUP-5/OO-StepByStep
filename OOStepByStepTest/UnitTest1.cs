namespace OOStepByStepTest
{
    using OOStepByStep;
    using System.IO;
    using System.Text;
    using System;
    using System.Xml.Linq;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var class1 = new Class1();
            Assert.NotNull(class1);
        }

        [Theory]
        [InlineData("Alice", 10)]
        [InlineData("Jack", 15)]
        [InlineData("Bob", 13)]
        public void Should_return_self_introduction_given_person_with_name_and_age(string name, int age)
        {
            var person = new Person(name, age);

            var result = person.Introduce();

            Assert.Equal(result, $"My name is {name}. I am {age} years old.");
        }

        [Theory]
        [InlineData("Alice", 10)]
        [InlineData("Jack", 15)]
        [InlineData("Bob", 13)]
        public void Should_return_self_introduction_given_student_with_name_and_age(string name, int age)
        {
            var student = new Student(name, age);

            var result = student.Introduce();

            Assert.Equal(result, $"My name is {name}. I am {age} years old. I am a student.");
        }

        [Theory]
        [InlineData("Alice", 30)]
        [InlineData("Jack", 45)]
        [InlineData("Bob", 33)]
        public void Should_return_self_introduction_given_teacher_with_name_and_age(string name, int age)
        {
            var teacher = new Teacher(name, age);

            var result = teacher.Introduce();

            Assert.Equal(result, $"My name is {name}. I am {age} years old. I am a teacher.");
        }

        [Theory]
        [InlineData("Alice", 35, -1)]
        [InlineData("Jack", 20, 0)]
        public void Should_throw_exception_given_class_number_invalid_when_construct_teacher(string name, int age, int classNumber)
        {
            Action action = () => new Teacher(name, age, classNumber);

            Assert.Throws<ArgumentException>(action);
        }

        [Theory]
        [InlineData("Alice", 30, 2)]
        [InlineData("Jack", 25, 1)]
        [InlineData("Bob", 43, 5)]
        public void Should_return_self_introduction_given_teacher_with_name_and_age_and_class(string name, int age, int classNumber)
        {
            var teacher = new Teacher(name, age, classNumber);

            var result = teacher.Introduce();

            Assert.Equal(result, $"My name is {name}. I am {age} years old. I am a teacher of class {classNumber}.");
        }

        [Theory]
        [InlineData("Alice", 10, 2)]
        [InlineData("Jack", 15, 1)]
        [InlineData("Bob", 13, 5)]
        public void Should_return_self_introduction_given_student_with_name_and_age_and_class(string name, int age, int classNumber)
        {
            var student = new Student(name, age, classNumber);

            var result = student.Introduce();

            Assert.Equal(result, $"My name is {name}. I am {age} years old. I am a student of class {classNumber}.");
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void Should_throw_exception_given_class_number_invalid_when_construct_classRoom(int classNumber)
        {
            Action action = () => new ClassRoom(classNumber);

            Assert.Throws<ArgumentException>(action);
        }

        [Fact]
        public void Should_return_teacher_and_student_introduction_when_student_join_in_class()
        {
            var studentA = new Student("Alice", 10);
            var studentB = new Student("Jack", 11);
            var teacher = new Teacher("Bob", 43);
            var classRoomNumber = 2;
            var classRoom = new ClassRoom(classRoomNumber);
            var fakeOutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeOutput));

            classRoom.AddTeacher(teacher);
            classRoom.AddStudent(studentA);
            classRoom.AddStudent(studentB);

            Assert.Equal("My name is Bob. I am 43 years old. I am a teacher of class 2. Welcome Alice join class 2.\r\n" +
                "My name is Bob. I am 43 years old. I am a teacher of class 2. Welcome Jack join class 2.\r\n" +
                "My name is Alice. I am 10 years old. I am a student of class 2. Welcome Jack join class 2.\r\n", fakeOutput.ToString());
        }
    }
}
