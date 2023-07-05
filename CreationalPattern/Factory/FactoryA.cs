namespace DesignPattern.CreationalPattern.Factory
{
    internal class FactoryA : IFactory
    {
        public IProduct CreateProduct()
        {
            return new ProductA();
        }
    }
}
