namespace DesignPattern.StructuralPattern.Adapter
{
    class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Common Request");
        }
    }
}