namespace DesignPattern.CreationalPattern.AbstractFactory
{
    internal class Red : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Inside Red::fill() method.");
        }
    }
}
