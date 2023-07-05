using DesignPattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory
{
    internal class FactoryA : IFactory
    {
        public IProduct CreateProduct()
        {
            return new ProductA();
        }
    }
}
