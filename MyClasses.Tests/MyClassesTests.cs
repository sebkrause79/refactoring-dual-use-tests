using FluentAssertions;

namespace MyClass.Tests
{
    public class TestClass
    {
        public MyClasses.New.MyClass GetTestee(int value) => new MyClasses.New.MyClass(value);

        [Fact]
        public void ProductShouldBeInvariantUnderOne()
        {
            var testee = GetTestee(1);
            var value = 42;
            testee.Product(value).Should().Be(value);
        }
    }
}