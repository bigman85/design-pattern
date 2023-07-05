namespace DesignPattern.CreationalPattern.Factory
{
    internal class FactoryB : IFactory
    {
        public IProduct CreateProduct()
        {
            return new ProductB();
        }
    }
}
