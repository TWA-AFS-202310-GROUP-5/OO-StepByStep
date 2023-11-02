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
    }
}
