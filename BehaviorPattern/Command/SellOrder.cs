using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPattern.Command
{
    public class SellOrder: IOrder
    {
        private Stock stock;
        public SellOrder(Stock stock)
        {
            this.stock = stock;
        }
        public void execute()
        {
            stock.Sell();
        }
    }
}