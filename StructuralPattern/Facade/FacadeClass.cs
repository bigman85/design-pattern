namespace DesignPattern.StructuralPattern.Facade
{
    public class FacadeClass
    {
        SubSystemOne  one;
        SubSystemTwo two;
        SubSystemThree three;
        SubSystemFour four;

        public FacadeClass()
        {
            this.one = new SubSystemOne();
            this.two = new SubSystemTwo();
            this.three = new SubSystemThree();
            this.four = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("Method Group A is called");
            one.MethodOne();
            two.MethodTwo();
            four.MethodFour();
        }

        public void MethodB()
        {
            Console.WriteLine("Method Group B is called");
            three.MethodThree();
            two.MethodTwo();
        }

    }
}