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
    class ItemDAOImpl : ItemDAO
    {
        public void deleteItems(Items ItemsRef)
        {
            DataBaseconnection DbCon = new DataBaseconnection();
            string qry = "delete from dbo.order_item where itemName= '" + ItemsRef.itemName + "';";
            SqlConnection cnn = DbCon.ObtainConnection();
            SqlDataAdapter da = new SqlDataAdapter();
             da.InsertCommand = new SqlCommand(qry, cnn);
            da.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("delete successfull !!");
            cnn.Dispose();
            cnn.Close();
        }

        public List<Items> getItemsList(Items ItemsRef1)
        {
            string qry = "";
            List<Items> itemsList = new List<Items>();
            DataBaseconnection DbCon = new DataBaseconnection();
            if (ItemsRef1 == null)
            {
                qry = "select * from dbo.order_item";
                Console.WriteLine("inside if ");
            }
            else
            {
                qry = "select * from dbo.order_item where itemName= '" + ItemsRef1.itemName + "';";
                Console.WriteLine("inside else ");
            }
            SqlConnection cnn = DbCon.ObtainConnection();

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(qry, cnn);


            SqlDataReader reader = cmd.ExecuteReader();
            Items ItemsRef = new Items();
            Category categoryRef = new Category();
            List<string> itemm = new List<string>();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("\n\n select *   values \n\n");
                //    itemm=ItemsRef.Itemss(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));

                    //ItemsRef.itemName = reader.GetString(0);
                    //categoryRef.categoryName = reader.GetString(1);
                    //string catName = reader.GetString(1);
                    
                    //ItemsRef.category.categoryName = catName;
                    //ItemsRef.description= reader.GetString(2);
                    //ItemsRef.itemType= reader.GetString(3);
                    //Console.WriteLine("@@@@@@@@@\nItem name:{0} \n  Item category:{1}\n description:{2}\n Item Name:{3}\n", ItemsRef.itemName, categoryRef.categoryName, ItemsRef.description, ItemsRef.itemName);
                    ////   Items categoryAdd = new Items(ItemsRef.itemName,categoryRef, ItemsRef.description, ItemsRef.itemName);
                    //itemsList.Add(ItemsRef);
                    //Console.WriteLine("{0}\t{1}\n", reader.GetString(0),
                    //  reader.GetString(1));


                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }

            foreach (Items ItemsRef2 in itemsList)
                Console.WriteLine("$$$$$$$$$$$$$$$$$\nItem name:{0} \n  Item category:{1}\n description:{2}\n Item Name:{3}\n", ItemsRef2.itemName, ItemsRef2.category, ItemsRef2.description, ItemsRef2.itemName);
             return itemsList;
            
        }


        public List<ArrayList> getItemsListSample(Items ItemsRef1)
        {
            string qry = "";
            // List<Items> itemsList = new List<Items>();
            ArrayList itemsList = new ArrayList();
            DataBaseconnection DbCon = new DataBaseconnection();
            if (ItemsRef1 == null)
            {
                qry = "select * from dbo.order_item";
                Console.WriteLine("inside if ");
            }
            else
            {
                Console.WriteLine("!!!!!!!!!!!!!!!! outside if ");
                if (ItemsRef1.itemName !=null)
                {
                    qry = "select * from dbo.order_item where itemName= '" + ItemsRef1.itemName + "';";
                    Console.WriteLine("item name!!!!!!!");
                }
                Console.WriteLine("!!!!!!!!!!!!!!!! outside else ");
                if (ItemsRef1.category.categoryName !=null)
                {
                    Console.WriteLine("!!!!!!!!!!!!!!!! insidceeeeeeeeee else ");
                    qry = "select * from dbo.order_item where category= '" + ItemsRef1.category.categoryName + "';";
                    Console.WriteLine("!!!!!!!!!!!!!!!! inside else ");
                    Console.WriteLine("inside else\n  category name={0} ", ItemsRef1.category.categoryName);
                }
                  
            }
            SqlConnection cnn = DbCon.ObtainConnection();

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(qry, cnn);


            SqlDataReader reader = cmd.ExecuteReader();
            Items ItemsRef = new Items();
            Category categoryRef = new Category();
            // List<List<string>> itemm = new List<List<string>>();
            List<ArrayList> itemm = new List<ArrayList>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("\n\n select *   values \n\n");
                    // itemm.Add(ItemsRef.Itemss(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),Convert.ToString(reader.GetInt16(4)),Convert.ToString(reader.GetFloat(5))));
                   // ArrayList arr = ItemsRef.Itemss(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt16(4), reader.GetFloat(5));
                    Console.WriteLine("******item name:{0}\t item Category:{1}\t      item desc:{2} \t item type:{3}\t item  stock:{4}\t item unit price:{5}", reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetDouble(5));
                    itemm.Add(ItemsRef.BillList(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),1, reader.GetDouble(5)));
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }

            return itemm;
        }





        public void inseritems(Items ItemsRef)
        {
            DataBaseconnection DbCon = new DataBaseconnection();
            string qry = "insert into dbo.order_item(itemName,category,Description,itemType,stock,unitPrice) values('" + ItemsRef.itemName+ "','" + ItemsRef.category.categoryName + "','" + ItemsRef.description+"','" + ItemsRef.itemType+ "','" + ItemsRef.stock + "','" + ItemsRef.unitprice +"')";
            SqlConnection cnn = DbCon.ObtainConnection();
            //MessageBox.Show("Connectiom established !!");
            SqlDataAdapter da = new SqlDataAdapter();
            //  SqlCommand cmd = new SqlCommand(qry, cnn);
            da.InsertCommand = new SqlCommand(qry, cnn);
            da.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("insert successfull !!");
            cnn.Dispose();
            cnn.Close();
        }

        public void updateItems(Items ItemsRef)
        {
            DataBaseconnection DbCon = new DataBaseconnection();
            //if(ItemsRef.description!=null)

           // string qry = "update dbo.order_item set Description= '" +ItemsRef.description+ "',itemType= '" + ItemsRef.itemType + "' where itemName= '" + ItemsRef.itemName+ "';";
            string qry = "update dbo.order_item set Description= '" + ItemsRef.description + "',itemType= '" + ItemsRef.itemType + "' ,stock= '" + ItemsRef.stock + "' ,unitPrice= '" + ItemsRef.unitprice + "' where itemName= '" + ItemsRef.itemName + "';";
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
