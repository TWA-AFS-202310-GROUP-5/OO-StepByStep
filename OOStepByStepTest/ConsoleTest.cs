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
        public void Should_print_message_include_name_age_when_print_given_person()
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

        [Fact]
        public void Should_print_message_include_name_age_when_print_given_student()
        {
            //Given
            var fakeOutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeOutput));
            Student student = new Student("Tom", 21);

            //When
            student.Print();

            //Then
            Assert.Equal("My name is Tom. I am 21 years old. I am a student.\r\n", fakeOutput.ToString());
        }

        [Fact]
        public void Should_print_message_include_name_age_when_print_given_teacher()
        {
            //Given
            var fakeOutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeOutput));
            Teacher teacher = new Teacher("Amy", 30);

            //When
            teacher.Print();

            //Then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.\r\n", fakeOutput.ToString());
        }
    }
}
