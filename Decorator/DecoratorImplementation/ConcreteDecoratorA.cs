

using Decorator.ComponentDetails;

namespace Decorator.DecoratorImplementation
{
    public class ConcreteDecoratorA : DecoratorClass
    {
        public ConcreteDecoratorA(Component component) : base(component)
        {
        }
        public override string Operation()
        {
            return $"ConcreteDecoratorA({base.Operation()})";
        }
    }
    public class ConcreteDecoratorB : DecoratorClass
    {
        public ConcreteDecoratorB(Component component) : base(component)
        {
        }
        public override string Operation()
        {
            return $"ConcreteDecoratorB({base.Operation()})";
        }
    }
}
