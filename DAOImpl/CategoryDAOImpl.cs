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

namespace Trial.DAOImpl
{
    class CategoryDAOImpl : CategoryDAO
    {
        public void deleteCategory(Category CategoryRef)
        {

            DataBaseconnection DbCon = new DataBaseconnection();
            string qry = "delete from dbo.order_category where name= '" + CategoryRef.categoryName + "';";
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

        //public Category findbyprimaryKey(string categoryName)
        //{
        //    DataBaseconnection DbCon = new DataBaseconnection();
        //    string qry = "select * from dbo.order_category where name= '" + categoryName + "';";
        //    SqlConnection cnn = DbCon.ObtainConnection();
        //    // MessageBox.Show("Connectiom established !!");
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    SqlCommand cmd = new SqlCommand(qry, cnn);
        //    //  da.InsertCommand = new SqlCommand(qry, cnn);
        //    // da.InsertCommand.ExecuteReader();

        //    SqlDataReader reader = cmd.ExecuteReader();
        //    Category CategoryRef = new Category();

        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //            Console.WriteLine("\n inserted  values \n");
        //            Console.WriteLine("{0}\t{1}\n", reader.GetString(0),
        //                reader.GetString(1));
        //            CategoryRef.categoryName = reader.GetString(0);
        //            CategoryRef.categoryDesc = reader.GetString(1);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("No rows found.");
        //    }

        //    Console.WriteLine("{0}\t{1}\n", CategoryRef.categoryName,
        //                    CategoryRef.categoryDesc);
        //    reader.Close();
        //    //  MessageBox.Show("display successfull !!");




        //    cnn.Dispose();
        //    cnn.Close();
        //    //  MessageBox.Show("Connectiom closed !!");

        //    return CategoryRef;
        //}

        public List<Category> getcategoryList( Category CategoryRef1)
        {
            string qry = "";
            List<Category> categorylist = new List<Category>();
            DataBaseconnection DbCon = new DataBaseconnection();
            if (CategoryRef1 == null)
            {
                 qry = "select * from dbo.order_category";
                Console.WriteLine("inside if ");
            }
            else
            {
                 qry = "select * from dbo.order_category where name= '" + CategoryRef1.categoryName + "';";
                Console.WriteLine("inside else ");
            }
            SqlConnection cnn = DbCon.ObtainConnection();
        
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(qry, cnn);
         

            SqlDataReader reader = cmd.ExecuteReader();
            Category CategoryRef = new Category();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("\n\n select *   values \n\n");
                    CategoryRef.categoryName = reader.GetString(0);
                    CategoryRef.categoryDesc = reader.GetString(1);
                    Category categoryAdd = new Category(CategoryRef.categoryName, CategoryRef.categoryDesc);
                    categorylist.Add(categoryAdd);
                    Console.WriteLine("{0}\t{1}\n", reader.GetString(0),
                      reader.GetString(1));


                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }

            foreach (Category catgry in categorylist)
                Console.WriteLine("category name:{0} \n category value:{1}",catgry.categoryName,catgry.categoryDesc);
            reader.Close();
            return categorylist;

        }

        public void insertCatelog(Category CategoryRef)
        {

            DataBaseconnection DbCon = new DataBaseconnection();
            string qry = "insert into dbo.order_category(name,Categorydesc) values('" + CategoryRef.categoryName + "','" + CategoryRef.categoryDesc + "')";
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

        public void updateCategory(Category CategoryRef)
        {

            DataBaseconnection DbCon = new DataBaseconnection();
            string qry = "update dbo.order_category set Categorydesc = '" + CategoryRef.categoryDesc + "' where name= '" + CategoryRef.categoryName + "';";
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
