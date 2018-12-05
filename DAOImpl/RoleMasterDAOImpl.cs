using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trial.DAO;
using Trial.entity;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DataBaseConfig;
namespace Trial.DAOImpl
{
    public class RoleMasterDAOImpl : RoleMasterDAO
    {
        public void deleteRole(RoleMaster roleMasterRef)
        {


            DataBaseconnection DbCon = new DataBaseconnection();
            string qry = "delete from dbo.order_role where rolename= '" + roleMasterRef.roleName + "';";
            SqlConnection cnn = DbCon.ObtainConnection();
           // MessageBox.Show("Connectiom established !!");
            SqlDataAdapter da = new SqlDataAdapter();
            //  SqlCommand cmd = new SqlCommand(qry, cnn);
            da.InsertCommand = new SqlCommand(qry, cnn);
            da.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("delete successfull !!");
            cnn.Dispose();
            cnn.Close();
            //MessageBox.Show("Connectiom closed !!");



        }

        public RoleMaster findbyprimaryKey(string roleName)
        {
            DataBaseconnection DbCon = new DataBaseconnection();
            string qry = "select * from dbo.order_role where rolename= '" + roleName + "';";
            SqlConnection cnn = DbCon.ObtainConnection();
           // MessageBox.Show("Connectiom established !!");
            SqlDataAdapter da = new SqlDataAdapter();
             SqlCommand cmd = new SqlCommand(qry, cnn);
          //  da.InsertCommand = new SqlCommand(qry, cnn);
           // da.InsertCommand.ExecuteReader();

            SqlDataReader reader = cmd.ExecuteReader();
            RoleMaster roleMasterref = new RoleMaster();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("\n inserted  values \n");
                    Console.WriteLine("{0}\t{1}\n", reader.GetString(0),
                        reader.GetString(1));
                    roleMasterref.roleName = reader.GetString(0);
                    roleMasterref.roleDesc = reader.GetString(1);
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            
            Console.WriteLine("{0}\t{1}\n", roleMasterref.roleName,
                            roleMasterref.roleDesc);
            reader.Close();
          //  MessageBox.Show("display successfull !!");

            


            cnn.Dispose();
            cnn.Close();
          //  MessageBox.Show("Connectiom closed !!");

            return roleMasterref;
        }

        public void insertRole(RoleMaster roleMasterRef)
        {
            DataBaseconnection DbCon = new DataBaseconnection();
          string qry = "insert into dbo.order_role(rolename,roleDesc) values('" + roleMasterRef.roleName + "','" + roleMasterRef.roleDesc + "')";
            SqlConnection cnn = DbCon.ObtainConnection();
          //MessageBox.Show("Connectiom established !!");
            SqlDataAdapter da = new SqlDataAdapter();
            //  SqlCommand cmd = new SqlCommand(qry, cnn);
            da.InsertCommand = new SqlCommand(qry, cnn);
            da.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("insert successfull !!");
            cnn.Dispose();
            cnn.Close();
        //    MessageBox.Show("Connectiom closed !!");

        }
        public void updaterole(RoleMaster roleMasterRef)
        {

            DataBaseconnection DbCon = new DataBaseconnection();
            string qry = "update dbo.order_role set roleDesc = '" + roleMasterRef.roleDesc + "' where rolename= '" + roleMasterRef.roleName + "';";
            SqlConnection cnn = DbCon.ObtainConnection();
         //   MessageBox.Show("Connectiom established !!");
            SqlDataAdapter da = new SqlDataAdapter();
            //  SqlCommand cmd = new SqlCommand(qry, cnn);
            da.InsertCommand = new SqlCommand(qry, cnn);
            da.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("update successfull !!");
            cnn.Dispose();
            cnn.Close();
          //  MessageBox.Show("Connectiom closed !!");

        }
    }
}
