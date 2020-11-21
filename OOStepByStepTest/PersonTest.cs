namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class PersonTest
    {
        [Fact]
        public void Should_return_Tom_21()
        {
            //given
            var person = new Person("Tom", 21);
            //when
            var actual = person.Introduce();
            var expected = "My name is Tom,I am 21 years old.";
            Assert.Equal(expected, actual);
        }

        //[Theory]
        //[InlineData("Tom", 18)]
        [Fact]
        public void Should_return_Tom_18_student()
        {
            //given
            var student = new Student("Tom", 18);
            //when
            var actual = student.Introduce();
            var expected = "My name is Tom,I am 18 years old.I am a student.";
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Amy", 30)]
        public void Should_return_Amy_30_student(string name, int age)
        {
            //given
            var teacher = new Teacher(name, age);
            //when
            var actual = teacher.Introduce();
            var expected = "My name is Amy,I am 30 years old.I am a teacher.";
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Amy", 30)]
        public void Should_return_name_age_profession_class(string name, int age)
        {
            //given
            var class1 = new SchoolClass("class1");
            var teacher = new Teacher(name, age);
            class1.AddTeacher(teacher);
            //when
            var actual = teacher.Introduce();
            var expected = "My name is Amy,I am 30 years old.I am a teacher.I am in class1.";
            Assert.Equal(expected, actual);
        }
    }
}
