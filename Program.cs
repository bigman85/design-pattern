// See https://aka.ms/new-console-template for more information

#region Simple Factory Pattern
Console.WriteLine("DesignPattern-CreationalPattern-SimpleFactory");
DesignPattern.CreationalPattern.SimpleFactory.OperatorFactory simpleFactory = new DesignPattern.CreationalPattern.SimpleFactory.OperatorFactory();
DesignPattern.CreationalPattern.SimpleFactory.IOperator simpleOperator = simpleFactory.GetOperator("+"); // operator: + - * /
Console.WriteLine($" 1 + 2 = {simpleOperator.GetResult(1, 2)}");
Console.WriteLine("DesignPattern-CreationalPattern-SimpleFactory --END--");
Console.WriteLine();
#endregion

#region Factory Pattern
Console.WriteLine("DesignPattern-CreationalPattern-Factory");
DesignPattern.CreationalPattern.Factory.IFactory factory = new DesignPattern.CreationalPattern.Factory.FactoryA();
DesignPattern.CreationalPattern.Factory.IProduct product = factory.CreateProduct();
product.Display();
Console.WriteLine("DesignPattern-CreationalPattern-Factory --END--");
Console.WriteLine();
#endregion

#region AbstractFactory Pattern
Console.WriteLine("DesignPattern-CreationalPattern-AbstractFactory");

DesignPattern.CreationalPattern.AbstractFactory.AbstractFactory shapeFactory = DesignPattern.CreationalPattern.AbstractFactory.FactoryProducer.getFactory("SHAPE");
DesignPattern.CreationalPattern.AbstractFactory.AbstractFactory colorFactory = DesignPattern.CreationalPattern.AbstractFactory.FactoryProducer.getFactory("COLOR");
DesignPattern.CreationalPattern.AbstractFactory.IShape shape = shapeFactory.getShape("Rectangle");
DesignPattern.CreationalPattern.AbstractFactory.IColor color = colorFactory.getColor("Red");
shape.Draw();
color.Fill();
Console.WriteLine("DesignPattern-CreationalPattern-AbstractFactory --END--");
Console.WriteLine();
#endregion

#region Singleton Pattern
Console.WriteLine("DesignPattern-CreationalPattern-Singleton");
DesignPattern.CreationalPattern.Singleton.SingletonPattern singletonPattern = DesignPattern.CreationalPattern.Singleton.SingletonPattern.getInstance();
singletonPattern.Display();
Console.WriteLine("DesignPattern-CreationalPattern-Singleton --END--");
Console.WriteLine();
#endregion

#region Builder Pattern
Console.WriteLine("DesignPattern-CreationalPattern-Builder");
DesignPattern.CreationalPattern.Builder.User user = DesignPattern.CreationalPattern.Builder.User.Builder().Age(18).Name("RenZhiwei").Password("123456").NickName("GOD").Build();
user.Display();
Console.WriteLine("DesignPattern-CreationalPattern-Builder --END--");
Console.WriteLine();
#endregion


#region Prototype Pattern
Console.WriteLine("DesignPattern-CreationalPattern-Prototype");
DesignPattern.CreationalPattern.Prototype.Person person1 = new DesignPattern.CreationalPattern.Prototype.Person { Name = "aaa", Address = new DesignPattern.CreationalPattern.Prototype.Address { City = "Wuhan", Province = "HuBei" } };
Console.WriteLine("Person1 is ");
Console.WriteLine(person1.ToString());
var person2 = person1.Clone() as DesignPattern.CreationalPattern.Prototype.Person;
Console.WriteLine("Cloned Person2 is ");
Console.WriteLine(person2.ToString());
Console.WriteLine("DesignPattern-CreationalPattern-Prototype --END--");
Console.WriteLine();
#endregion

#region Strategy Pattern
Console.WriteLine("DesignPattern-BehaviorPattern-Strategy");
DesignPattern.BehaviorPattern.Strategy.Context strategyContext = new DesignPattern.BehaviorPattern.Strategy.Context(new DesignPattern.BehaviorPattern.Strategy.ConcreteStrategyA());
strategyContext.ContextInterface();
Console.WriteLine("DesignPattern-BehaviorPattern-Strategy --END--");
Console.WriteLine();
#endregion

#region Decorator Pattern
Console.WriteLine("DesignPattern-StructuralPattern-Strategy");
DesignPattern.StructuralPattern.Decorator.ConcreteComponent concreteComponent = new DesignPattern.StructuralPattern.Decorator.ConcreteComponent();
DesignPattern.StructuralPattern.Decorator.ConcreteDecoratorA concreteDecoratorA = new DesignPattern.StructuralPattern.Decorator.ConcreteDecoratorA();
DesignPattern.StructuralPattern.Decorator.ConcreteDecoratorB concreteDecoratorB = new DesignPattern.StructuralPattern.Decorator.ConcreteDecoratorB();
concreteDecoratorA.SetComponent(concreteComponent);
concreteDecoratorB.SetComponent(concreteDecoratorA);
concreteDecoratorB.Operation();
Console.WriteLine("DesignPattern-StructuralPattern-Strategy --END--");
Console.WriteLine();
#endregion

#region Proxy Pattern
Console.WriteLine("DesignPattern-StructuralPattern-Proxy");
DesignPattern.StructuralPattern.Proxy.IService proxy = new DesignPattern.StructuralPattern.Proxy.Proxy();
proxy.Method1();
Console.WriteLine("DesignPattern-StructuralPattern-Proxy --END--");
Console.WriteLine();
#endregion