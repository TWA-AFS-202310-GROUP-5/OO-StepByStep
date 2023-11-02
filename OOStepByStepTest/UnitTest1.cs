namespace OOStepByStepTest
{
    using OOStepByStep;
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
        [InlineData("Tom", 21)]
        [InlineData("Amy", 30)]
        public void Should_return_personIntroMsg_given_personInfo(string name, int age)
        {
            //given
            Person person = new Person(name, age);

            //when
            string msg = person.SelfIntroduceMsg();

            //then
            Assert.Equal($"My name is {name}. I am {age} years old.", msg);
        }

        [Theory]
        [InlineData("Tom", 18)]
        [InlineData("Jacky", 21)]
        public void Should_return_stuIntroMsg_given_stuInfo(string name, int age)
        {
            //given
            Student stu = new Student(name, age);
            //when
            string msg = stu.SelfIntroduceMsg();
            //then
            Assert.Equal($"My name is {name}. I am {age} years old. I am a student.", msg);
        }

        [Theory]
        [InlineData("Amy", 30)]
        [InlineData("Mike", 50)]
        public void Should_return_teacherIntroMsg_given_teacherInfo(string name, int age)
        {
            //given
            Teacher teacher = new Teacher(name, age);
            //when
            string msg = teacher.SelfIntroduceMsg();
            //then
            Assert.Equal($"My name is {name}. I am {age} years old. I am a teacher.", msg);
        }

        [Theory]
        [InlineData("Tom", 18, 2)]
        public void Should_return_stuIntroMsg_given_stuInfo_with_classNum(string name, int age, int classNum)
        {
            //given
            Student student = new Student(name, age, classNum);
            //when
            string msg = student.SelfIntroduceMsg();
            //then
            Assert.Equal($"My name is {name}. I am {age} years old. I am a student of class {classNum}.", msg);
        }

        [Theory]
        [InlineData("Amy", 30, 2)]
        [InlineData("Mike", 40, 5)]
        public void Should_return_teacherIntroMsg_given_teacherInfo_with_classNum(string name, int age, int classNum)
        {
            //given
            Teacher teacher = new Teacher(name, age, classNum);
            //when
            string msg = teacher.SelfIntroduceMsg();
            //then
            Assert.Equal($"My name is {name}. I am {age} years old. I am a teacher of class {classNum}.", msg);
        }

        [Fact]
        public void Should_return_teacher_and_stuIntroMsg_given_new_student_join_class()
        {
            //given
            ClassRoom c1 = new ClassRoom(2);
            c1.SetTeacher("Amy", 30);
            c1.AddStudent("Tom", 18);
            c1.AddStudent("Jack", 19);
            
            //when
            string msg = c1.Join("Jane", 19);
            string expectMsg = "My name is Amy. I am 30 years old. I am a teacher of class 2. Welcome Jane join class 2." +
                "\r\nMy name is Tom. I am 18 years old. I am a student of class 2. Welcome Jane join class 2." +
                "\r\nMy name is Jack. I am 19 years old. I am a student of class 2. Welcome Jane join class 2.\r\n";

            Assert.Equal(expectMsg, msg);
        }
    }
}
