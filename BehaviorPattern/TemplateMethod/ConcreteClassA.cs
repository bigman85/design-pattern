namespace DesignPattern.BehaviorPattern.TemplateMethod
{
    class ConcreteClassA : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("ClassA called method PrimitiveOperation1");
        }
        public override void PrimitiveOperation2()
        {
            Console.WriteLine("ClassA called method PrimitiveOperation2");
        }
    }
}