namespace DesignPattern.BehaviorPattern.Observer
{
    internal class ObserverOne : Observer
    {
        public ObserverOne(Subject subject)
        {
            this.subject = subject;
            this.subject.AddObserver(this);
        }
        public override void update()
        {
            Console.WriteLine($"ObserverOne update status {this.subject.Status}");
        }
    }
}
