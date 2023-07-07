using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.BehaviorPattern.Strategy;

namespace DesignPattern.BehaviorPattern.State
{
    public interface IState
    {
        void DoAction(Context context);
    }
}