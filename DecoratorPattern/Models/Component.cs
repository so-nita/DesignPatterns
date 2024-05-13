namespace DecoratorPattern.Models
{
    public abstract class Component
    {
        public abstract void Operation();
    }
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }
    public abstract class Decorator : Component
    {
        protected Component _component = null!;
        public void SetComponent(Component component) => _component = component;
        public override void Operation()
        {
            if(_component != null)
            {
                _component.Operation();
            }
        }
    }
    public class ConcreteDecoratorA : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Concrete Decorator A");
        }
    }
    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Concrete Decorator B");
            AddedBehavior();
        }
        void AddedBehavior()
        {
            Console.WriteLine("Added Behavior in ConcreteDecorator B");
        }
    }
}
