using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trial.entity;

namespace Trial.DAO
{
    interface BillDAO
    {
        void insertBill(Bill billRef);
        void updateBill(Bill billRef);
        void deleteBill(Bill billRef);
        //   Bill findbyprimaryKey(string BillName);
        List<ArrayList> getBillList(Bill billRef);
    }
}
