namespace DesignPattern.Decorator
{
    public class ConcreteDecoratorA:Decorator
    {
        private string addedState;
        public ConcreteDecoratorA()
        {
            addedState = "New State";            
        }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine($"Operation of Concrete Decorator A, with addedState = { addedState }");
        }
    }
}