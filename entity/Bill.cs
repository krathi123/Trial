using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial.entity
{
    public class Bill
    {
        public int orderId{get;set;}
        public OrderCredentials billNoRef { get; set; }
        public string selectedItemName {get; set;}
        public int quantity { get; set; }
        public double price { get; set; }

        public ArrayList BillList(int orderid,int billNo,string name,int q,double p)
        {
            ArrayList ilist = new ArrayList();
            ilist.Add(orderid);
            ilist.Add(billNo);
            ilist.Add(name);
            ilist.Add(q);
            ilist.Add(p);
            return ilist;

        }

    }
}
