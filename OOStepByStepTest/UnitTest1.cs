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
            Assert.Equal($"I am {name}. I am {age} years old.", result);

        }

        [Fact]
        public void Should_return_student_introduction_when_introduce_given_student()
        {
            //Given
            var name = "Tom";
            var age = 10;

            //When
            var person = new Student{ Name = name, Age = age };
            var result = person.Introduce();

            //Then
            Assert.Equal($"I am {name}. I am {age} years old. I am a student.", result);

        }

        [Fact]
        public void Should_return_teacher_introduction_when_introduce_given_teacher()
        {
            //Given
            var name = "Tom";
            var age = 10;

            //When
            var person = new Teacher{ Name = name, Age = age };
            var result = person.Introduce();

            //Then
            Assert.Equal($"I am {name}. I am {age} years old. I am a teacher.", result);

        }

        [Fact]
        public void Should_return_student_introduction_when_introduce_given_student_with_class()
        {
            //Given
            var name = "Tom";
            var age = 10;
            var classId = "2";
            //When
            var person = new Student { Name = name, Age = age, ClassId  = classId};
            var result = person.Introduce();

            //Then
            Assert.Equal($"I am {name}. I am {age} years old. I am a student. I am a student of class {classId}.", result);

        }

        [Fact]
        public void Should_return_teacher_introduction_when_introduce_given_teacher_with_class()
        {
            //Given
            var name = "Tom";
            var age = 10;
            var classId = "2";

            //When
            var person = new Teacher { Name = name, Age = age, ClassId = classId};
            var result = person.Introduce();

            //Then
            Assert.Equal($"I am {name}. I am {age} years old. I am a teacher. I am a teacher of class {classId}.", result);

        }
    }
}
