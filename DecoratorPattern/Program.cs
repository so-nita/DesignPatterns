    using DecoratorPattern.Models;

    var concreteClass = new ConcreteComponent();
    var decoratorA = new ConcreteDecoratorA();
    var decoratorB = new ConcreteDecoratorB();

    decoratorA.SetComponent(concreteClass);
    decoratorB.SetComponent(decoratorA);

    decoratorB.Operation();

    Console.ReadKey();