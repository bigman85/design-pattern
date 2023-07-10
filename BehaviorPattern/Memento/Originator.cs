using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPattern.Memento
{
    public class Originator
    {
        public string State {get; set;} 
        public Memento CreateMemento()
        {
            return new Memento(this.State);
        }
        public void SetMemento(Memento memento)
        {
            this.State = memento.State;
        }

        public void Show()
        {
            Console.WriteLine("State="+State);
        }
    }
}