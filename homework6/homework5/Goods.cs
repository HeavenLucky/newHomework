using System;
using System.Collections.Generic;

namespace homework5
{
    public class Goods
    {
        public String goodsname;
        public double price;
        public int goodsid;
       

            
        public Goods(String goodsname, double price,int goodsid)
        {
            this.goodsid = goodsid;
            this.goodsname = goodsname;
            this.price = price;

        }
        public override string ToString()
        {
            return goodsid + " " + goodsname + " " + price;

        }
        public  bool Equals(Goods go)
        {
            return this.goodsid == go.goodsid;
        }
    }
}
