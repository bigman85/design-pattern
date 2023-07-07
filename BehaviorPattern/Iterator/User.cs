namespace DesignPattern.BehaviorPattern.Iterator
{
    internal class User
    {
        public string Name { get; set; }
        public User(string name) { this.Name = name; }
        public override string ToString() { return Name; }
    }
}
