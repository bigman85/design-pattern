using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPattern.State
{
    public class Context
    {
        public IState State { get; set; }
    }
}