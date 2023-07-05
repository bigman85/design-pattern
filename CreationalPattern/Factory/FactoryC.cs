namespace DesignPattern.CreationalPattern.Factory
{
    internal class FactoryC : IFactory
    {
        public IProduct CreateProduct()
        {
            return new ProductC();
        }
    }
}
