using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace homework5
{
    [Serializable]
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

        public static void Export()
        {

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("s.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, Orders);
            }
        }
        public void Import(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));

                var o = xmlSerializer.Deserialize(fs);
                var list = o as List<Order>;

            }

        }

        public void RemoveOrder(int orderId)
        {
            orders.RemoveAll(o => o.orderID == orderId);
        }

        public List<Order> QueryAll()
        {
            return orders;
        }

        public void Update(Order order)
        {
            RemoveOrder(order.orderID);
            orders.Add(order);
        }
    }
}
