using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial.entity
{
    public class Items
    {
        public string itemName { get; set; }
        public Category category { get; set; }
        public string description { get; set; }
        public string itemType { get; set; }
        public int stock { get; set; }
        public double unitprice { get; set; }
        public Items()
        {

        }
        public Items(string name,Category c,string desc,string type,int stock,double unitPrice )
        {
            itemName = name;
            category=c;
            description = desc;
            itemType = type;
            this.stock = stock;
            this.unitprice = unitPrice;
           
        }
        public ArrayList BillList(string name, string c, string desc, string type,int stock,double price)
        {
             ArrayList ilist = new ArrayList();
            ilist.Add(name);
            ilist.Add(c);
            ilist.Add(desc);
            ilist.Add(type);
            ilist.Add(stock);
            ilist.Add(price);
           return ilist;

        }
    }
}
