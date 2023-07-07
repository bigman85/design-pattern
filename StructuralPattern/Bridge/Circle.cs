namespace DesignPattern.StructuralPattern.Bridge
{
    internal class Circle : Shape
    {

        public override void Draw()
        {
            Console.WriteLine($"This is a Circle");
            if(this.Color != null)
            {
                this.Color.Fill();
            }
        }
    }
}
