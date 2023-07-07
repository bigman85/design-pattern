using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPattern.ChainOfResponsibility
{
    public abstract class AbstractHandler
    {
        public AbstractHandler NextHandler {get; set;}

        public abstract void Handle(String request);
    }
}