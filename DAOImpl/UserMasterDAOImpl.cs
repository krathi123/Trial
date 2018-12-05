using DataBaseConfig;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trial.DAO;
using Trial.entity;
using System.Collections;

namespace Trial.DAOImpl
{
    class UserMasterDAOImpl : UserMasterDao
    {
        public void deleteUser(UserMaster userMasterRef)
        {

            DataBaseconnection DbCon = new DataBaseconnection();
            string qry = "delete from dbo.order_user where userid= '" + userMasterRef.userid + "';";
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

        public UserMaster findbyprimaryKey(int userId)
        {

            DataBaseconnection DbCon = new DataBaseconnection();
            string qry = "select * from dbo.order_user where userid= '" + userId + "';";
            SqlConnection cnn = DbCon.ObtainConnection();
            // MessageBox.Show("Connectiom established !!");
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(qry, cnn);
            //  da.InsertCommand = new SqlCommand(qry, cnn);
            // da.InsertCommand.ExecuteReader();

            SqlDataReader reader = cmd.ExecuteReader();
            UserMaster userMasterref = new UserMaster();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("\n inserted  values \n");
                    Console.WriteLine("{0}\t{1}\n", reader.GetString(0),
                        reader.GetString(1));
                    userMasterref.userid = reader.GetInt32(0);
                    userMasterref.username = reader.GetString(1);
                    userMasterref.mobileNo = reader.GetString(2);
                    userMasterref.address = reader.GetString(3);
                    userMasterref.gender = reader.GetString(4);
                    userMasterref.emailId = reader.GetString(5);
                    userMasterref.dob = reader.GetDateTime(6);
                    userMasterref.pwd = reader.GetString(7);
                    RoleMaster roleMasterRef = new RoleMaster();
                    roleMasterRef.roleName = reader.GetString(8);

                    userMasterref.designationRef = roleMasterRef;

                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }


            reader.Close();
            //  MessageBox.Show("display successfull !!");




            cnn.Dispose();
            cnn.Close();
            //  MessageBox.Show("Connectiom closed !!");

            return userMasterref;
        }



        public void insertUser(UserMaster userMasterRef)
        {
            DataBaseconnection DbCon = new DataBaseconnection();
            // string qry = "insert into dbo.order_user(userid,name,mobileNo,address,gender,emailid,dob,pwd,designation) values('" + userMasterRef.userid + "','" + userMasterRef.username + "','" + userMasterRef.mobileNo + "','" + userMasterRef.address + "','" + userMasterRef.gender + "','" + userMasterRef.emailId + "','" + userMasterRef.dob + "','" + userMasterRef.pwd + "','" + userMasterRef.designationRef.roleName + "')";
            string qry = "insert into dbo.order_user(name,mobileNo,address,gender,emailid,dob,pwd,designation) values('" + userMasterRef.username + "','" + userMasterRef.mobileNo + "','" + userMasterRef.address + "','" + userMasterRef.gender + "','" + userMasterRef.emailId + "','" + userMasterRef.dob + "','" + userMasterRef.pwd + "','" + userMasterRef.designationRef.roleName + "')";
            SqlConnection cnn = DbCon.ObtainConnection();
            //MessageBox.Show("Connectiom established !!");
            SqlDataAdapter da = new SqlDataAdapter();
            //  SqlCommand cmd = new SqlCommand(qry, cnn);
            da.InsertCommand = new SqlCommand(qry, cnn);
            da.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("User Added !!");
            cnn.Dispose();
            cnn.Close();
            //    MessageBox.Show("Connectiom closed !!");
        }

        public void updateUser(UserMaster userMasterRef)
        {
            DataBaseconnection DbCon = new DataBaseconnection();
            string qry = "update dbo.order_user set name = '" + userMasterRef.username + "',  mobileNo= '" + userMasterRef.mobileNo + "',  address= '" + userMasterRef.address + "',  gender= '" + userMasterRef.gender + "',  emailid= '" + userMasterRef.emailId + "', dob= '" + userMasterRef.dob + "', pwd= '" + userMasterRef.pwd + "' where userid= '" + userMasterRef.userid + "';";
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


        public List<string> getRoleName()
        {
            DataBaseconnection DbCon = new DataBaseconnection();
            string qry = "select * from dbo.order_role";
            SqlConnection cnn = DbCon.ObtainConnection();
            // MessageBox.Show("Connectiom established !!");
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(qry, cnn);


            SqlDataReader reader = cmd.ExecuteReader();
            RoleMaster roleRef = new RoleMaster();
            List<string> roleNames = new List<string>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("\n inserted  values \n");
                    Console.WriteLine("{0}\t\n", reader.GetString(0));
                    roleNames.Add(reader.GetString(0));


                }
            }
            else
            {
                Console.WriteLine("couldn't display");
            }


            reader.Close();
            //  MessageBox.Show("display successfull !!");




            cnn.Dispose();
            cnn.Close();
            //  MessageBox.Show("Connectiom closed !!");

            return roleNames;
        }

        public List<ArrayList> getUsrList(UserMaster usermasterRef)
        {
            UserMaster usrmasterRef = new UserMaster();
            List<ArrayList> listOfUsers = new List<ArrayList>();
            DataBaseconnection DbCon = new DataBaseconnection();
            List<ArrayList> usrList = new List<ArrayList>();
            SqlConnection cnn = DbCon.ObtainConnection();
            UserMaster usrMasterRef = new UserMaster();
            string qry = null;
            if (usermasterRef == null)
            {
                qry = "select * from dbo.order_user";
            }
            else
            {
                if (usermasterRef.username != "")
                {
                    Console.WriteLine("\n ^^^^^^^^^^^^inside if User name\n");
                    Console.WriteLine("user Name:{0}\n", usermasterRef.username);
                    qry = "select * from dbo.order_user where name='" + usermasterRef.username + "'";

                }

                if (usermasterRef.designationRef.roleName != null)
                {
                    Console.WriteLine("inside else if \nRole Name:{0}", usermasterRef.designationRef.roleName);
                    qry = "select * from dbo.order_user where designation='" + usermasterRef.designationRef.roleName + "'";
                }

            }
            Console.WriteLine("\n ^^^^^^^^^^^^outside if User name\n");
            //   Console.WriteLine("user Name:{0}\n", usermasterRef.username);

            // Console.WriteLine("outside else if \nRole Name:{0}", usermasterRef.designationRef.roleName);
            SqlCommand cmd = new SqlCommand(qry, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    Console.WriteLine("");
                    // (0 int  id,1 string usename, 2 string mobileNo,3 string address,  4 string g, 5 string mailid, 6 DateTime d,7  string pwd,8  string RoleMaster)
                    Console.WriteLine("Role name={0}", reader.GetString(8));
                    usrList.Add(usrmasterRef.getUserList(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6), reader.GetString(7), reader.GetString(8)));
                    Console.WriteLine("USER ID:{0}\n ID:{1}\n mobile no:{2}\n address:{3}\n gender:{4}\n mailid:{5}\tdob:{6}\npwd:{7}\nrole:[8]", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6), reader.GetString(7), reader.GetString(8));

                }
            }
            else
                Console.WriteLine("No row found!!\n");

            return usrList;


        }

        public UserMaster login(UserMaster usermasterRef)
        {
            Console.WriteLine("\n\n\n inside login()\n\n\n\n\n\n");
            DataBaseconnection DbCon = new DataBaseconnection();
            //string qry = "select * from dbo.order_user where mobileNo= '" + usermasterRef.mobileNo + "';";
            string qry = "select * from dbo.order_user where mobileNo= '" + usermasterRef.mobileNo + "' and pwd='" + usermasterRef.pwd + "'";
            SqlConnection cnn = DbCon.ObtainConnection();
            // MessageBox.Show("Connectiom established !!");
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(qry, cnn);
            //  da.InsertCommand = new SqlCommand(qry, cnn);
            // da.InsertCommand.ExecuteReader();

            SqlDataReader reader = cmd.ExecuteReader();
            UserMaster userMasterref = new UserMaster();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("\n inserted  values \n");
                    //Console.WriteLine("{0}\t{1}\n", reader.GetString(0),
                    //    reader.GetString(1));
                    Console.WriteLine("\n inserted  values \n");
                    //Console.WriteLine("{0}\t{1}\n", reader.GetString(0),
                    //    reader.GetString(1));
                    userMasterref.userid = reader.GetInt32(0);
                    userMasterref.username = reader.GetString(1);
                    userMasterref.mobileNo = reader.GetString(2);
                    userMasterref.address = reader.GetString(3);
                    userMasterref.gender = reader.GetString(4);
                    userMasterref.emailId = reader.GetString(5);
                   //  userMasterref.dob = reader.GetDateTime(6);
                    userMasterref.pwd = reader.GetString(7);
                    RoleMaster roleMasterRef = new RoleMaster();
                    roleMasterRef.roleName = reader.GetString(8);
                    Console.WriteLine("\n\n++++++++++\nRole Name:{0}", roleMasterRef.roleName);
                    userMasterref.designationRef = roleMasterRef;

                    // SqlConnection cnn = DbCon.ObtainConnection();
                    // SqlCommand cmd = new SqlCommand(qry, cnn);
                    //SqlDataReader reader = cmd.ExecuteReader();
                    //if (reader.HasRows)
                    //    return 1;
                    //else return 0;

                }
            }
            cnn.Dispose();
            cnn.Close();
            return userMasterref;

        }


    }  
}
