namespace DesignPattern.StructuralPattern.FlyWeight
{
    internal class ShapeFactory
    {
        private static Dictionary<string, Circle> dic = new Dictionary<string, Circle>();

        public static Circle GetShape(string color)
        {
            if (dic.TryGetValue(color, out var shape))
            {
                Console.WriteLine($"Totle circle instance number: { dic.Count }");
                return shape;
            }
            else
            {
                Console.WriteLine($"Totle circle instance number: {dic.Count}");
                shape = new Circle();
                shape.Color = color;
                dic[color] = shape;
                return shape;
            }
        }

    }
}
