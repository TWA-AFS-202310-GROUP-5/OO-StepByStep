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
    }
}
