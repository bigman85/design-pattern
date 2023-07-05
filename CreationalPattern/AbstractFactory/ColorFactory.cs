namespace DesignPattern.CreationalPattern.AbstractFactory
{
    internal class ColorFactory : AbstractFactory
    {
        public override IShape getShape(string shape)
        {
            throw new NotImplementedException();
        }

        public override IColor getColor(string color)
        {
            IColor res;
            switch (color)
            {
                case "Red":
                    res = new Red();
                    break;
                default:
                    throw new ArgumentException("ERROR SHAPE");
            }
            return res;
        }
    }
}
