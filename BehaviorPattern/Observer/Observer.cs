namespace DesignPattern.BehaviorPattern.Observer
{
    internal abstract class Observer
    {
        protected Subject subject;
        public abstract void update();
    }
}
