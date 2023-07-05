using DesignPattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory
{
    internal class ProductC : IProduct
    {
        public void Display()
        {
            Console.WriteLine("Product C Display!");
        }
    }
}
