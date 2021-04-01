using System;
namespace homework5
{
    public class Order
    {
        public int orderID;
        public Customer customer;
       public DateTime time;
       
       public OrderDetails orderDetails;


        public Order(int orderID,
        Customer customer,
        DateTime time,
      
        OrderDetails orderDetails
        )
        {
           
            
            this.orderDetails = orderDetails;
            this.orderID = orderID;
           
            this.time = time;
           

        }

        public override string ToString()
        {
            return customer + " " + time;
        }
        public  bool Equals(Order order)
        {
            return orderID==order.orderID;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
}
