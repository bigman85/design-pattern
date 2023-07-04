using System;
using System.ComponentModel;
namespace DesignPattern.Decorator
{
    public class ConcreteComponent: Component
    {
        public override void Operation()
        {
            Console.WriteLine("The concrete component's operation");
        }
    }
}