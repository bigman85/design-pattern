namespace DesignPattern.StructuralPattern.Bridge
{
    internal abstract class Shape
    {
        public IColor Color;

        public abstract void Draw();
    }
}
