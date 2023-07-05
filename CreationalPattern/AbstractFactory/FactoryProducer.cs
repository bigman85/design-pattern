using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPattern.AbstractFactory
{
    internal class FactoryProducer
    {
        public static AbstractFactory getFactory(String choice)
        {
            if (choice.Equals("SHAPE",StringComparison.CurrentCultureIgnoreCase))
            {
                return new ShapeFactory();
            }
            else if (choice.Equals("COLOR", StringComparison.CurrentCultureIgnoreCase))
            {
                return new ColorFactory();
            }
            throw new ArgumentException("ERROR CHOICE");
        }
    }
}
