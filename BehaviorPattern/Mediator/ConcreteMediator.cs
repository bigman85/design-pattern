using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPattern.Mediator
{
    public class ConcreteMediator : Mediator
    {
        public ConcreteColleague1 concreteColleague1 { get; set; }
        public ConcreteColleague2 concreteColleague2 { get; set; }

        public override void Send(string message, Colleague colleague)
        {
            if (concreteColleague1 == colleague)
            {
                concreteColleague2.Notify(message);
            }
            else if (concreteColleague2 == colleague)
            {
                concreteColleague1.Notify(message);
            }
        }
    }
}