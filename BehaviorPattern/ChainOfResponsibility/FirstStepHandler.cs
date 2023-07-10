using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPattern.ChainOfResponsibility
{
    public class FirstStepHandler : AbstractHandler
    {
        public override void Handle(string request)
        {
            Console.WriteLine($"First step handler with parameter {request}");
            if(this.NextHandler!=null){
                this.NextHandler.Handle(request);
            }
        }
    }
}