using MyClasses.Old;

namespace MyClasses.New
{
    public class MyClass : IMyClass
    {
        private int _factor;

        public MyClass(int factor) => _factor = factor;

        public int Product(int value) => _factor * value;
    }
}