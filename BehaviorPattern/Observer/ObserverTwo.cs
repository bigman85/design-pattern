namespace DesignPattern.BehaviorPattern.Observer
{
    internal class ObserverTwo : Observer
    {
        public ObserverTwo(Subject subject)
        {
            this.subject = subject;
            this.subject.AddObserver(this);
        }
        public override void update()
        {
            Console.WriteLine($"ObserverTwo update status {this.subject.Status}");
        }
    }
}
