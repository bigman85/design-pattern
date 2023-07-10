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
Console.WriteLine(person2?.ToString());
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

#region Bridge Pattern
Console.WriteLine("DesignPattern-StructuralPattern-Bridge");
DesignPattern.StructuralPattern.Bridge.Shape circle = new DesignPattern.StructuralPattern.Bridge.Circle();
circle.Color = new DesignPattern.StructuralPattern.Bridge.Green();
circle.Draw();
Console.WriteLine("DesignPattern-StructuralPattern-Bridge --END--");
Console.WriteLine();
#endregion

#region FlyWeight Pattern
Console.WriteLine("DesignPattern-StructuralPattern-FlyWeight");
string[] colors = { "Red", "Green", "Blue", "White", "Black" };
for (int i = 0; i < 20; i++)
{
    string tmpColor = colors[Random.Shared.Next(0, colors.Length)];
    var tmpCircle = DesignPattern.StructuralPattern.FlyWeight.ShapeFactory.GetShape(tmpColor);
    tmpCircle.Radius = Random.Shared.Next(10,100);
    tmpCircle.x = Random.Shared.Next(0, 1024);
    tmpCircle.y = Random.Shared.Next(0, 1024);
    tmpCircle.Draw();
}
Console.WriteLine("DesignPattern-StructuralPattern-FlyWeight --END--");

#region Template Method Pattern
Console.WriteLine("DesignPattern-StructuralPattern-TemplateMethod");
DesignPattern.BehaviorPattern.TemplateMethod.AbstractClass cb = new DesignPattern.BehaviorPattern.TemplateMethod.ConcreteClassB();
cb.TemplateMethod();
Console.WriteLine("DesignPattern-StructuralPattern-TemplateMethod --END--");
Console.WriteLine();
#endregion

#region Adapter Pattern
Console.WriteLine("DesignPattern-StructuralPattern-Adapter");
DesignPattern.StructuralPattern.Adapter.Target target = new DesignPattern.StructuralPattern.Adapter.Adapter();
target.Request();
Console.WriteLine("DesignPattern-StructuralPattern-Adapter --END--");
Console.WriteLine();
#endregion


#region Composite Pattern
Console.WriteLine("DesignPattern-StructuralPattern-Composite");
DesignPattern.StructuralPattern.Composite.Directory dirRoot = new DesignPattern.StructuralPattern.Composite.Directory("root");
dirRoot.AddChild(new DesignPattern.StructuralPattern.Composite.File("fileLv1-1"));
dirRoot.AddChild(new DesignPattern.StructuralPattern.Composite.File("fileLv1-2"));
DesignPattern.StructuralPattern.Composite.Directory dirLv1 = new DesignPattern.StructuralPattern.Composite.Directory("dirLv1-1");
dirLv1.AddChild(new DesignPattern.StructuralPattern.Composite.File("fileLv2-1"));
dirLv1.AddChild(new DesignPattern.StructuralPattern.Composite.File("fileLv2-2"));
dirRoot.AddChild(dirLv1);

dirRoot.Info();
Console.WriteLine("DesignPattern-StructuralPattern-Composite --END--");
#region Facade Pattern
Console.WriteLine("DesignPattern-StructuralPattern-Facade");
DesignPattern.StructuralPattern.Facade.FacadeClass facade = new DesignPattern.StructuralPattern.Facade.FacadeClass();
facade.MethodA();
facade.MethodB();
Console.WriteLine("DesignPattern-StructuralPattern-Facade --END--");
Console.WriteLine();
#endregion

#region Facade Pattern
Console.WriteLine("DesignPattern-BehaviorPattern-ChainOfResponsibility");
DesignPattern.BehaviorPattern.ChainOfResponsibility.FirstStepHandler firstStepHandler = new();
DesignPattern.BehaviorPattern.ChainOfResponsibility.SecondStepHandler secondStepHandler = new();
DesignPattern.BehaviorPattern.ChainOfResponsibility.ThridStepHandler thridStepHandler = new();

firstStepHandler.NextHandler = secondStepHandler;
secondStepHandler.NextHandler = thridStepHandler;

firstStepHandler.Handle("#REQUEST#");
Console.WriteLine("DesignPattern-BehaviorPattern-ChainOfResponsibility --END--");
Console.WriteLine();
#endregion

#region Command Pattern
Console.WriteLine("DesignPattern-BehaviorPattern-Command");
DesignPattern.BehaviorPattern.Command.Stock stock = new();
DesignPattern.BehaviorPattern.Command.BuyOrder buyOrder = new(stock);
DesignPattern.BehaviorPattern.Command.SellOrder sellOrder = new(stock);
DesignPattern.BehaviorPattern.Command.Broker broker = new();

broker.TakeOrder(buyOrder);
broker.TakeOrder(buyOrder);
broker.TakeOrder(sellOrder);
broker.TakeOrder(buyOrder);
Console.WriteLine();
#endregion



#region Observer Pattern
Console.WriteLine("DesignPattern-StructuralPattern-Observer");
DesignPattern.BehaviorPattern.Observer.Subject subject = new DesignPattern.BehaviorPattern.Observer.Subject();
DesignPattern.BehaviorPattern.Observer.ObserverOne observerOne = new DesignPattern.BehaviorPattern.Observer.ObserverOne(subject);
DesignPattern.BehaviorPattern.Observer.ObserverTwo observer = new DesignPattern.BehaviorPattern.Observer.ObserverTwo(subject);
subject.Status = 12;
subject.Status = 99;
Console.WriteLine("DesignPattern-StructuralPattern-Observer --END--");
Console.WriteLine();
#endregion

#region Iterator Pattern
Console.WriteLine("DesignPattern-StructuralPattern-Iterator");
DesignPattern.BehaviorPattern.Iterator.Users users = new DesignPattern.BehaviorPattern.Iterator.Users();
users.Add(new DesignPattern.BehaviorPattern.Iterator.User("Tom"));
users.Add(new DesignPattern.BehaviorPattern.Iterator.User("David"));
users.Add(new DesignPattern.BehaviorPattern.Iterator.User("Tony"));
users.Add(new DesignPattern.BehaviorPattern.Iterator.User("Jacky"));

for(var iterator = users.GetIterator(); iterator.HasNext(); )
{
    Console.WriteLine(iterator.Next().ToString());
}
Console.WriteLine("DesignPattern-StructuralPattern-Iterator --END--");
Console.WriteLine();
#endregion#region Visitor Pattern
Console.WriteLine("DesignPattern-BehaviorPattern-Visitor");
DesignPattern.BehaviorPattern.Visitor.ObjectStructure objectStructure = new ();
objectStructure.Attach(new DesignPattern.BehaviorPattern.Visitor.ConcreteElementA());
objectStructure.Attach(new DesignPattern.BehaviorPattern.Visitor.ConcreteElementB());

DesignPattern.BehaviorPattern.Visitor.ConcreteVisitor1 visitor1 = new ();
