using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPattern.Memento
{
    public class Memento
    {
        public string State { get; set; }   

        public Memento(string state)
        {
            this.State = state;
        }
    }
}