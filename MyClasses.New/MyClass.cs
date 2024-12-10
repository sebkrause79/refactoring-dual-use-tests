using MyClasses.Old;

namespace MyClasses.New
{
    public class MyClass : IMyClass
    {
        private IMyClass _vbOriginal;

        public MyClass(int factor)
        {
            _vbOriginal = new MyClasses.Old.MyClass(factor);
        }

        public int Product(int value)
        {
            return _vbOriginal.Product(value);
        }
    }
}