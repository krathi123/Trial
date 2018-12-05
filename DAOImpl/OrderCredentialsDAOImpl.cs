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
    class OrderCredentialsDAOImpl : OrderCredentialsDAO
    {
        public void deleteorderCredentials(OrderCredentials orderCredentialsRef)
        {
            DataBaseconnection DbCon = new DataBaseconnection();
            string qry = "delete from dbo.order_orderCredentials where billNo= '" + orderCredentialsRef.billNo + "';";
            SqlConnection cnn = DbCon.ObtainConnection();
            // MessageBox.Show("Connectiom established !!");
            SqlDataAdapter da = new SqlDataAdapter();
            //  SqlCommand cmd = new SqlCommand(qry, cnn);
            da.InsertCommand = new SqlCommand(qry, cnn);
            da.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("delete successfull in order cerdentails!!");
            cnn.Dispose();
            cnn.Close();
        }

        public List<ArrayList> getorderCredentialsList(OrderCredentials orderCredentialsRef1)
        {
            string qry = "";
            // List<Items> itemsList = new List<Items>();
            ArrayList itemsList = new ArrayList();
            DataBaseconnection DbCon = new DataBaseconnection();
            if (orderCredentialsRef1 == null)
            {
                qry = "select * from dbo.order_orderCredentials";
                Console.WriteLine("inside if ");
            }
            else
            {
                Console.WriteLine("!!!!!!!!!!!!!!!! outside if ");
                if (orderCredentialsRef1.billNo != 0)
                {
                    qry = "select * from dbo.order_orderCredentials where billNo= '" + orderCredentialsRef1.billNo + "';";
                    Console.WriteLine("item name!!!!!!!");
                }
               

            }
            SqlConnection cnn = DbCon.ObtainConnection();

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(qry, cnn);


            SqlDataReader reader = cmd.ExecuteReader();
            OrderCredentials orderCredentialsRef = new OrderCredentials();
        
            List<ArrayList> orderCredList = new List<ArrayList>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("\n\n select *   values \n\n");
                    // itemm.Add(orderCredentialsRef.Itemss(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),Convert.ToString(reader.GetInt16(4)),Convert.ToString(reader.GetFloat(5))));
                    // ArrayList arr = orderCredentialsRef.Itemss(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt16(4), reader.GetFloat(5));
                    Console.WriteLine("******item name:{0}\t item Category:{1}\t      item desc:{2} \t item type:{3}\t item  stock:{4}\t item unit price:{5}", reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetDouble(5));
                    orderCredList.Add(orderCredentialsRef.OrderCredentialsList( reader.GetInt32(0), reader.GetDateTime(1)));
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }

            return orderCredList;
        }

        public void insertOrderCredentials(OrderCredentials orderCredentialsRef)
        {
            DataBaseconnection DbCon = new DataBaseconnection();
            string qry = "insert into dbo.order_orderCredentials(billNo,OrderDate) values('" + orderCredentialsRef.billNo + "','" + orderCredentialsRef.orderDate + "')";
            SqlConnection cnn = DbCon.ObtainConnection();
            //MessageBox.Show("Connectiom established !!");
            SqlDataAdapter da = new SqlDataAdapter();
            //  SqlCommand cmd = new SqlCommand(qry, cnn);
            da.InsertCommand = new SqlCommand(qry, cnn);
            da.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("insert successfull to Order Credentails !!");
            cnn.Dispose();
            cnn.Close();
        }

        public void updateorderCredentials(OrderCredentials orderCredentialsRef)
        {
            DataBaseconnection DbCon = new DataBaseconnection();
            //if(orderCredentialsRef.description!=null)

            // string qry = "update dbo.order_item set Description= '" +orderCredentialsRef.description+ "',itemType= '" + orderCredentialsRef.itemType + "' where itemName= '" + orderCredentialsRef.itemName+ "';";
            string qry = "update dbo.order_orderCredentials set Description= '" + orderCredentialsRef.orderDate + "' where itemName= '" + orderCredentialsRef.billNo + "';";
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
