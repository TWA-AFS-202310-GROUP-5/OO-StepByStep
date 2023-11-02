namespace OOStepByStepTest
{
    using OOStepByStep;
    using System.Xml.Linq;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Should_return_person_introduction_when_introduce_given_person()
        {
            //Given
            var name = "Tom";
            var age = 10;

            //When
            var person = new Person { Name = name, Age = age };
            var result = person.Introduce();

            //Then
            Assert.Equal($"I am {name}, I am {age}years old", result);
            

        }
    }
}
