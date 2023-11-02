namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class ClassTest
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
    }
}
