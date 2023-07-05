namespace DesignPattern.CreationalPattern.AbstractFactory
{
    internal class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}
