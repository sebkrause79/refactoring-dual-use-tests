using MyClasses.Old;
using MyClasses.New;
using FluentAssertions;

namespace MyClass.Tests
{
    public abstract class TestClass
    {
        public abstract IMyClass GetTestee(int value);

        [Fact]
        public void ProductShouldBeInvariantUnderOne()
        {
            var testee = GetTestee(1);
            var value = 42;
            testee.Product(value).Should().Be(value);
        }
    }

    public class VBTestclass : TestClass
    {
        public override IMyClass GetTestee(int value) => new MyClasses.Old.MyClass(value);
    }

    public class CsharpTestclass : TestClass
    {
        public override IMyClass GetTestee(int value) => new MyClasses.New.MyClass(value);
    }
}