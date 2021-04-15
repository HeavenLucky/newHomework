using System;

namespace homework5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Goods goods1 = new Goods("蛋糕", 20, 001);

            Goods goods2 = new Goods("蛋糕", 20, 002);
           
            Customer customer = new Customer("ll", "武汉");
            OrderDetails orderDetails = new OrderDetails(2, goods1);
           
            Order order = new Order(1, customer, DateTime.Now, orderDetails);
            

        }
    }
}
