namespace DesignPattern.Decorator
{
    public class ConcreteDecoratorB:Decorator
    {

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Operation of Concrete Decorator B");
        }


        private void AddedBehavior()
        {
            Console.WriteLine("Behavior added by Concrete Decorator B");
        }
    }
}