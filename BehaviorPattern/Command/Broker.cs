namespace DesignPattern.BehaviorPattern.Command
{
    public class Broker
    {
        private readonly List<IOrder> orderList = new();

        public void TakeOrder(IOrder order)
        {
            orderList.Add(order);
        }

        public void PlaceOrders()
        {
            foreach (IOrder order in this.orderList)
            {
                order.execute();
            }
            orderList.Clear();
        }
    }
}