namespace DesignPattern.CreationalPattern.AbstractFactory
{
    internal class ShapeFactory : AbstractFactory
    {
        public override IShape getShape(string shape)
        {
            IShape res;
            switch (shape)
            {
                case "Rectangle":
                    res = new Rectangle();
                    break;
                default:
                    throw new ArgumentException("ERROR SHAPE");
            }
            return res;
        }

        public override IColor getColor(string color)
        {
            throw new NotImplementedException();
        }
    }
}
