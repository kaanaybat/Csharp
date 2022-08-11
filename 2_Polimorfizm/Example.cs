namespace Csharp.Polimorfizm
{
    public class BaseClass
    {
        public int BaseClassProp { get; set; }
    }

    public class DerivedClass:BaseClass
    {
        public int DerivedClassProp { get; set; }
    }

    public class NestedDerivedClass:DerivedClass
    {
        public int NestedDerivedClassProp { get; set; }
    }

}