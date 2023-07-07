namespace DesignPattern.BehaviorPattern.Observer
{
    internal class Subject
    {
        private List<Observer> _observers = new List<Observer>();

        public int Status
        {
            get 
            {
                return this._status; 
            }
            set
            {
                this._status = value;
                UpdateStatus();
            }
        }
        private int _status;

        public void AddObserver(Observer observer)
        {
            _observers.Add(observer);
        }
        public void RemoveObserver(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Clear()
        {
            _observers.Clear();
        }

        public void UpdateStatus()
        {
            _observers.ForEach(x => x.update());
        }
    }
}
