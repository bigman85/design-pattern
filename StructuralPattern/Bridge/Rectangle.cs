namespace DesignPattern.StructuralPattern.Bridge
{
    internal class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine($"This is a Rectangle");
            if (this.Color != null)
            {
                this.Color.Fill();
            }
        }
    }
}
