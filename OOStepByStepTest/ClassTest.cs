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
            var person = new Person();
            //when
            //then
            Assert.NotNull(person);
        }
    }
}
