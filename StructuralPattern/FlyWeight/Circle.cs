namespace DesignPattern.StructuralPattern.FlyWeight
{
    internal class Circle : IShape
    {
        public string Color { get; set; }
        public double Radius { get; set; } = 0;
        public double x { get; set; }
        public double y { get; set; }
        
        public void Draw()
        {
            Console.WriteLine($"This is a {this.Color} Circle(r = {this.Radius}, position = ({this.x},{this.y}) .");
        }
    }
}
