namespace DesignPattern.StructuralPattern.Composite
{
    internal class Directory : AbstractFile
    {
        public List<AbstractFile> Children { get; set; } = new List<AbstractFile>();

        public Directory(string name) { this.Name = name; }

        public void AddChild(AbstractFile child) {  Children.Add(child); }
        public void RemoveChild(AbstractFile child) { Children.Remove(child); }

        public override string ToString() { return $"Directory: {Name}"; }

        public override void Info()
        {
            Console.WriteLine(ToString());
            Children.ForEach(x => x.Info());
        }

    }
}
