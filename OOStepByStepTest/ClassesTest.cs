namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class ClassesTest
    {
        [Fact]
        public void Should_return_introuduction_of_person_itself()
        {
            //given
            var person = new Person("Tom", 21);
            //when
            string introduce = person.SelfIntroduce();
            //then
            Assert.Equal("My name is Tom. I am 21 years old.", introduce);
        }

        [Fact]
        public void Should_return_introuduction_of_student_itself()
        {
            //given
            var student = new Student("Tom", 18);
            //when
            string introduce = student.SelfIntroduce();
            //then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student.", introduce);
        }

        [Fact]
        public void Should_return_introuduction_of_student_itself_belongs_to_a_class()
        {
            //given
            var student = new Student("Tom", 18, 2);
            //when
            string introduce = student.SelfIntroduce();
            //then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student of class 2.", introduce);
        }

        [Fact]
        public void Should_return_introuduction_of_teacher_itself()
        {
            //given
            var teacher = new Teacher("Amy", 30);
            //when
            string introduce = teacher.SelfIntroduce();
            //then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", introduce);
        }

        [Fact]
        public void Should_return_introuduction_of_teacher_itself_belongs_to_a_class()
        {
            //given
            var teacher = new Teacher("Amy", 30, 2);
            //when
            string introduce = teacher.SelfIntroduce();
            //then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2.", introduce);
        }
    }

    public class ClassTest // Test for Class
    {
        [Fact]
        public void Should_return_introuduction_of_student_belong_to_a_class()
        {
            //given
            var person = new Person("Tom", 21);
            //when
            string introduce = person.SelfIntroduce();
            //then
            Assert.Equal("My name is Tom. I am 21 years old.", introduce);
        }

        [Fact]
        public void Should_return_introuduction_of_teacher_belong_to_a_class()
        {
            //given
            var person = new Person("Tom", 21);
            //when
            string introduce = person.SelfIntroduce();
            //then
            Assert.Equal("My name is Tom. I am 21 years old.", introduce);
        }
    }
}