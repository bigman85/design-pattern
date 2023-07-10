namespace DesignPattern.BehaviorPattern.TemplateMethod
{
    class ConcreteClassB : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("ClassB called method PrimitiveOperation1");
        }
        public override void PrimitiveOperation2()
        {
            Console.WriteLine("ClassB called method PrimitiveOperation2");
        }
    }
}