using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial.entity
{
    public class OrderCredentials
    {
        public int billNo { get; set; }
        public DateTime orderDate { get; set; }
        public OrderCredentials()
        {

        }
        public OrderCredentials(int b,DateTime d)
        {
            billNo = b;
            orderDate = d;
        }
        public ArrayList OrderCredentialsList(int b, DateTime d)
        {
            ArrayList a = new ArrayList();
            a.Add(b);
            a.Add(d);
            return a;
           
        }
    }
}
