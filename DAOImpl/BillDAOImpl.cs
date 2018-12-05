using DataBaseConfig;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trial.DAO;
using Trial.entity;

namespace Trial.DAOImpl
{
    class BillDAOImpl : BillDAO
    {
        public void deleteBill(Bill billRef)
        {

            DataBaseconnection DbCon = new DataBaseconnection();
            string qry = "delete from dbo.order_orderBill where billNo= '" + billRef.billNoRef.billNo+ "';";
            SqlConnection cnn = DbCon.ObtainConnection();
            // MessageBox.Show("Connectiom established !!");
            SqlDataAdapter da = new SqlDataAdapter();
            //  SqlCommand cmd = new SqlCommand(qry, cnn);
            da.InsertCommand = new SqlCommand(qry, cnn);
            da.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("delete successfull in bill table !!");
            cnn.Dispose();
            cnn.Close();
        }

        public List<ArrayList> getBillList(Bill billRef1)
        {
            string qry = "";
            // List<Items> itemsList = new List<Items>();
            ArrayList itemsList = new ArrayList();
            DataBaseconnection DbCon = new DataBaseconnection();
           
            { }
            if (billRef1 == null)
            {
                qry = "select * from dbo.order_orderBill";
                Console.WriteLine("inside if ");
            }
            else
            {
                Console.WriteLine("!!!!!!!!!!!!!!!! outside if ");
                if (billRef1.orderId != 0)
                {
                    qry = "select * from dbo.order_orderBill where orderId= '" + billRef1.orderId + "';";
                    Console.WriteLine("order iD !!!!!!!");
                }
                Console.WriteLine("!!!!!!!!!!!!!!!! outside else :{0} ", billRef1.billNoRef.billNo);
                if (billRef1.billNoRef.billNo >=0)
                {
                    Console.WriteLine("!!!!!!!!!!!!!!!! insidceeeeeeeeee else ");
                    qry = "select * from dbo.order_orderBill where billNo= '" + billRef1.billNoRef.billNo + "';";
                    Console.WriteLine("!!!!!!!!!!!!!!!! inside else ");
                    Console.WriteLine("inside else \n  bill No.={0} ", billRef1.billNoRef.billNo);
                }

            }
            SqlConnection cnn = DbCon.ObtainConnection();

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(qry, cnn);


            SqlDataReader reader = cmd.ExecuteReader();
            Bill billRef = new Bill();
            Category categoryRef = new Category();
            // List<List<string>> itemm = new List<List<string>>();
            List<ArrayList> bills = new List<ArrayList>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("\n\n select *   values \n\n");
                    // itemm.Add(billRef.Itemss(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),Convert.ToString(reader.GetInt16(4)),Convert.ToString(reader.GetFloat(5))));
                    // ArrayList arr = billRef.Itemss(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt16(4), reader.GetFloat(5));
                   // Console.WriteLine("******item name:{0}\t item Category:{1}\t      item desc:{2} \t item type:{3}\t item  stock:{4}\t item unit price:{5}", reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetDouble(5));
                    bills.Add(billRef.BillList(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetInt32(3),  reader.GetDouble(4)));
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }

            return bills;
        }

        public void insertBill(Bill billRef)
        {
            DataBaseconnection DbCon = new DataBaseconnection();
            string qry = "insert into dbo.order_orderBill(orderId,billNo,selectedItemName,quantity,price) values('" + billRef.orderId + "','" + billRef.billNoRef.billNo + "','" + billRef.selectedItemName + "','" + billRef.quantity + "','" + billRef.price + "')";
            SqlConnection cnn = DbCon.ObtainConnection();
            //MessageBox.Show("Connectiom established !!");
            SqlDataAdapter da = new SqlDataAdapter();
            //  SqlCommand cmd = new SqlCommand(qry, cnn);
            da.InsertCommand = new SqlCommand(qry, cnn);
            da.InsertCommand.ExecuteNonQuery();
         //   MessageBox.Show("insert successfull to Bill table !!");
            cnn.Dispose();
            cnn.Close();
        }

        public void updateBill(Bill billRef)
        {
            DataBaseconnection DbCon = new DataBaseconnection();
            //if(billRef.description!=null)

            // string qry = "update dbo.order_item set Description= '" +billRef.description+ "',itemType= '" + billRef.itemType + "' where itemName= '" + billRef.itemName+ "';";
            string qry = "update dbo.order_orderBill set selectedItemName= '" + billRef.selectedItemName + "',quantity= '" + billRef.quantity + "' ,price= '" + billRef.price + "';";
            SqlConnection cnn = DbCon.ObtainConnection();
            //   MessageBox.Show("Connectiom established !!");
            SqlDataAdapter da = new SqlDataAdapter();
            //  SqlCommand cmd = new SqlCommand(qry, cnn);
            da.InsertCommand = new SqlCommand(qry, cnn);
            da.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("update successfull !!");
            cnn.Dispose();
            cnn.Close();
        }
    }
}
