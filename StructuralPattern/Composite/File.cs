namespace DesignPattern.StructuralPattern.Composite
{
    internal class File : AbstractFile
    {
        public File(string name) { this.Name = name; }

        public override string ToString() { return $"File: {Name}"; }

        public override void Info()
        {
            Console.WriteLine(ToString());
        }
    }
}
