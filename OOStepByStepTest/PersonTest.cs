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
        public void Should_return_name_age_profession_class_teacher(string name, int age)
        {
            //given
            var class1 = new SchoolClass("class1");
            var teacher = new Teacher(name, age);
            class1.AddTeacher(teacher);
            //when
            var actualTeacher = teacher.Introduce();
            var expectedTeacher = "My name is Amy,I am 30 years old.I am a teacher of class1.";
            Assert.Equal(expectedTeacher, actualTeacher);
        }

        [Theory]
        [InlineData("Tom", 18)]
        public void Should_return_name_age_profession_class_student(string name, int age)
        {
            //given
            var class1 = new SchoolClass("class1");
            var student = new Student(name, age);
            var welcome = class1.AddStudent(student);
            //when
            var actual = student.Introduce();
            var expected = "My name is Tom,I am 18 years old.I am a student of class1.";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_return_welcomeMessage_when_add_new_student()
        {
            //given
            var class1 = new SchoolClass("class1");
            var teacher = new Teacher("Amy", 30);
            var student1 = new Student("Tom", 18);
            //var student2 = new Student("Jim", 18);
            //var student3 = new Student("Jane", 18);
            class1.AddTeacher(teacher);
            var actual1 = class1.AddStudent(student1);
            //var actual2 = class1.AddStudent(student2);
            //class1.AddStudent(student3);
            //when
            var expected1 = $"My name is Amy,I am 30 years old.I am a teacher of class1.Welcome Tom join in class1.\n";
            //var expected2 = $"My name is Amy,I am 30 years old.I am a teacher of class1.Welcome Tom join in class1.\n" +
                //$"My name is Tom,I am 18 years old.I am a student of class1.Welcome Jim join in class1.\n";
            Assert.Equal(expected1, actual1);
            //Assert.Equal(expected2, actual2);
        }
    }
}
