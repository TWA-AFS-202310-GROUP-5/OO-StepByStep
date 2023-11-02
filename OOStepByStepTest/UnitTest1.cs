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
}
