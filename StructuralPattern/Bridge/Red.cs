using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralPattern.Bridge
{
    internal class Red : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Fill in Red");
        }
    }
}
