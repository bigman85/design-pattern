using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPattern.Mediator
{
    public abstract class Mediator
    {
        public abstract void Send(String message, Colleague colleague);
    }
}