using System;
using System.Collections.Generic;
using System.Linq;

namespace homework5
{
    public class OrderService
    {
        private List<Order> orders = new List<Order>();

        public OrderService()
        {
           
        }
        public  void AddOrder(Order order) {
            orders.Add(order);
        }

        public  void DeleteOrder(Order order)
        {
            orders.Remove(order);
        }
       
       public   Order QueryOrderById(int orderId)
        {

            var order = orders.Where
                (o => o.orderID == orderId);
            return (Order)order;
        }

        public void Sort(Comparison<Order> comparison)
        {
            orders.Sort((x, y) => x.orderID.CompareTo(y.orderID));
            
        }
        
    }
}
