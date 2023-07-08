using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPattern.Visitor
{
    public class ConcreteVisitor2 : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA elementA)
        {
            Console.WriteLine($"{elementA.GetType().Name} is visited by {this.GetType().Name}");
        }

        public override void VisitConcreteElementB(ConcreteElementB elementB)
        {
            Console.WriteLine($"{elementB.GetType().Name} is visited by {this.GetType().Name}");
        }
    }
}