using Microsoft.VisualBasic.CompilerServices;
// See https://aka.ms/new-console-template for more information
#region Simple Factory Pattern
Console.WriteLine("DesignPattern-CreationalPattern-SimpleFactory");
DesignPattern.SimpleFactory.OperatorFactory simpleFactory = new DesignPattern.SimpleFactory.OperatorFactory();
DesignPattern.SimpleFactory.IOperator simpleOperator = simpleFactory.GetOperator("+"); // operator: + - * /
Console.WriteLine($" 1 + 2 = {simpleOperator.GetResult(1,2)}");
Console.WriteLine("DesignPattern-CreationalPattern-SimpleFactory --END--");
Console.WriteLine();
#endregion


#region Strategy Pattern
Console.WriteLine("DesignPattern-BehaviorPattern-Strategy");
DesignPattern.Strategy.Context strategyContext = new DesignPattern.Strategy.Context(new DesignPattern.Strategy.ConcreteStrategyA());
strategyContext.ContextInterface();
Console.WriteLine("DesignPattern-BehaviorPattern-Strategy --END--");
Console.WriteLine();
#endregion

#region Decorator Pattern
Console.WriteLine("DesignPattern-StructuralPattern-Strategy");
DesignPattern.Decorator.ConcreteComponent concreteComponent = new DesignPattern.Decorator.ConcreteComponent();
DesignPattern.Decorator.ConcreteDecoratorA concreteDecoratorA = new DesignPattern.Decorator.ConcreteDecoratorA();
DesignPattern.Decorator.ConcreteDecoratorB concreteDecoratorB = new DesignPattern.Decorator.ConcreteDecoratorB();

concreteDecoratorA.SetComponent(concreteComponent);
concreteDecoratorB.SetComponent(concreteDecoratorA);
concreteDecoratorB.Operation();

Console.WriteLine("DesignPattern-StructuralPattern-Strategy --END--");
Console.WriteLine();
#endregion