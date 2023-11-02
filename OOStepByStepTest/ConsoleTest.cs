using System;
using System.IO;
using System.Text;

namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class ConsoleTest
    {
        [Fact]
        public void Should_print_message_include_name_age_when_introduce_given_person()
        {
            // given
            var fakeOutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeOutput));
            Person person = new Person("Tom", 21);

            // when
            person.Print();

            // then
            Assert.Equal("My name is Tom. I am 21 years old.\r\n", fakeOutput.ToString());
        }
    }
}
