using System;
using System.Collections.Generic;

namespace homework5
{
    public class OrderDetails
    {
        Dictionary<int, Goods> details = new Dictionary<int, Goods>();

        public int goodsamount;
       public Goods goods;
          

        public OrderDetails( int  goodsamount, Goods goods)
        {
            this.goodsamount = goodsamount;
            this.goods = goods;

        }

        public override string ToString()
        {
            return details.Keys+" "+details.Values;
        }

        internal void Add(int v, Goods goods3)
        {
            throw new NotImplementedException();
        }

        public  bool Equals(OrderDetails odetails)
        {
            return (this.goodsamount==odetails.goodsamount)&&(goods==odetails.goods);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
