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
    }
}
