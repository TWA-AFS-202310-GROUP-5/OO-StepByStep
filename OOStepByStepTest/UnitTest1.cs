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
        [InlineData("Alice", 10)]
        [InlineData("Jack", 15)]
        [InlineData("Bob", 13)]
        public void Should_return_self_introduction_given_person_with_name_and_age(string name, int age)
        {
            var person = new Person(name, age);

            var result = person.Introduce();

            Assert.Equal(result, $"My name is {name}. I am {age} years old.");
        }

        [Theory]
        [InlineData("Alice", 10)]
        [InlineData("Jack", 15)]
        [InlineData("Bob", 13)]
        public void Should_return_self_introduction_given_student_with_name_and_age(string name, int age)
        {
            var student = new Student(name, age);

            var result = student.Introduce();

            Assert.Equal(result, $"My name is {name}. I am {age} years old. I am a student.");
        }

        [Theory]
        [InlineData("Alice", 30)]
        [InlineData("Jack", 45)]
        [InlineData("Bob", 33)]
        public void Should_return_self_introduction_given_teacher_with_name_and_age(string name, int age)
        {
            var teacher = new Teacher(name, age);

            var result = teacher.Introduce();

            Assert.Equal(result, $"My name is {name}. I am {age} years old. I am a teacher.");
        }

        [Theory]
        [InlineData("Alice", 30, 2)]
        [InlineData("Jack", 25, 1)]
        [InlineData("Bob", 43, 5)]
        public void Should_return_self_introduction_given_teacher_with_name_and_age_and_class(string name, int age, int classNumber)
        {
            var teacher = new Teacher(name, age, classNumber);

            var result = teacher.Introduce();

            Assert.Equal(result, $"My name is {name}. I am {age} years old. I am a teacher of class {classNumber}.");
        }

        [Theory]
        [InlineData("Alice", 10, 2)]
        [InlineData("Jack", 15, 1)]
        [InlineData("Bob", 13, 5)]
        public void Should_return_self_introduction_given_student_with_name_and_age_and_class(string name, int age, int classNumber)
        {
            var student = new Student(name, age, classNumber);

            var result = student.Introduce();

            Assert.Equal(result, $"My name is {name}. I am {age} years old. I am a student of class {classNumber}.");
        }
    }
}
