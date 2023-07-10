using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPattern.Command
{
    public class BuyOrder : IOrder
    {
        private Stock stock;
        public BuyOrder(Stock stock)
        {
            this.stock = stock;
        }
        public void execute()
        {
            stock.Buy();
        }
    }
}