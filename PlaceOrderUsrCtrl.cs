using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trial.DAO;
using Trial.DAOImpl;
using Trial.entity;
using System.Collections;
using DataBaseConfig;
using System.Data.SqlClient;
using Trial;

namespace Trial
{
    public partial class PlaceOrderUsrCtrl : UserControl
    {
        string username;
        string mobileNo;
        string EmailId;

        private static List<double> price = new List<double>();
        private int qty = 1;
        private int flag = 0, flag1 = 0, billNo = 1,flagForSearch=0,flagForReset=0;
       
        private List<ArrayList> listOfItems = new List<ArrayList>();
        private string str1;

        public PlaceOrderUsrCtrl()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if(flagForSearch>0 && flagForReset==0)
            {
                Console.WriteLine("search called :{0}", flagForSearch);
                clear();

            }
              
            ItemDAO itemsDAORef = new ItemDAOImpl();
            Items itemsRef = new Items();
            Category c = new Category();
            c.categoryName = categorynameCmb.Text;
            itemsRef.category = c;
            itemsRef.itemName = null;
            List<string> listNm = new List<string>();
            listNm.Add("Item Name");
            listNm.Add("Category Name");
            listNm.Add("Item Desciption");
            listNm.Add("Item Type");
            listNm.Add("Quantity");
            listNm.Add("Price");
            List<ArrayList> itemList = new List<ArrayList>();
            dataGridViewItemsList.ColumnHeadersVisible = true;
            itemList = itemsDAORef.getItemsListSample(itemsRef);

            dataGridViewItemsList.DataSource = CreateDataTable(listNm, itemList);
            for (int i = 0; i < itemList.Count; i++)
            {
                double d=Convert.ToDouble(itemList[i][5]);
                price.Add(d);
            }
            for (int i = 0; i < price.Count; i++)
            {
                Console.WriteLine("p[{0}]={1}", i, price[i]);
            }

            
            //  dataGridViewItemsList.SelectedCells[0].ReadOnly = true;
            //dataGridViewItemsList.Columns[0].ReadOnly = true;
            //dataGridViewItemsList.Columns[1].ReadOnly = true;
            //dataGridViewItemsList.Columns[2].ReadOnly = false;
            //dataGridViewItemsList.Columns[3].ReadOnly = false;
            //dataGridViewItemsList.Columns[4].ReadOnly = false;
            //dataGridViewItemsList.Columns[5].ReadOnly = false;
            // flag is used to ensure that the following buttons are added only once even if the search button pressed for number of times.
           if(flag==0 )
            {
                DataGridViewButtonColumn col1 = new DataGridViewButtonColumn();
                col1.UseColumnTextForButtonValue = true;
                col1.Text = "+";
                col1.Name = "+";
                dataGridViewItemsList.Columns.Add(col1);
                
                DataGridViewButtonColumn col2 = new DataGridViewButtonColumn();
                col2.UseColumnTextForButtonValue = true;
                col2.Text = "-";
                col2.Name = "-";
                dataGridViewItemsList.Columns.Add(col2);
                DataGridViewButtonColumn col = new DataGridViewButtonColumn();
                col.UseColumnTextForButtonValue = true;
                col.Text = "Add to Cart";
                col.Name = "Add to Cart";
                dataGridViewItemsList.Columns.Add(col);
                dataGridViewItemsList.Columns[6].Width = 20;
                dataGridViewItemsList.Columns[7].Width = 20;
                dataGridViewItemsList.Columns[8].Width = 120;

                flag++;
            }
            //else
            {
                //// to make the column to fixed to right corner position .changing the display index value will shuffle position of the column in between the other columns
                //dataGridViewItemsList.Columns["Item Name"].DisplayIndex = 0;
                //dataGridViewItemsList.Columns["Category Name"].DisplayIndex = 1;
                //dataGridViewItemsList.Columns["Item Desciption"].DisplayIndex = 2;
                //dataGridViewItemsList.Columns["Item Type"].DisplayIndex = 3;
                //dataGridViewItemsList.Columns["Quantity"].DisplayIndex = 4;
                //dataGridViewItemsList.Columns["Price"].DisplayIndex = 5;
                //dataGridViewItemsList.Columns["+"].DisplayIndex = 6;
                //dataGridViewItemsList.Columns["-"].DisplayIndex = 7;
                //dataGridViewItemsList.Columns["Add to Cart"].DisplayIndex = 8;

            }

            flagForSearch++;
        }

       




        private System.Data.DataTable CreateDataTable(List<string> columnDefinitions, List<ArrayList> rows)
        {
            DataTable table = new DataTable();
            foreach (string colDef in columnDefinitions)
            {
                DataColumn column;
                column = new DataColumn();
                column.DataType = typeof(string);
                column.ColumnName = colDef;
                table.Columns.Add(column);
            }


            // Create DataRow and Add it to table
            foreach (ArrayList rowData in rows)
            {
                DataRow row = table.NewRow();
                // rowData is in same order as columnDefinitions
                for (int i = 0; i < rowData.Count; i++)
                {
                    row[i] = rowData[i];
                }
                table.Rows.Add(row);
            }


            return table;
        }

        private void categorynameCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void PlaceOrderUsrCtrl_Load(object sender, EventArgs e)
        {
            loginPage loginPageRef = new loginPage();
            username = loginPageRef.username;
            mobileNo = loginPageRef.mobileNo;
            EmailId = loginPageRef.EmailId;


            CategoryDAO categoryDAORef = new CategoryDAOImpl();
            List<Category> categoryRef = categoryDAORef.getcategoryList(null);
            foreach (Category c in categoryRef)
                categorynameCmb.Items.Add(c.categoryName);
          
            //OrderCredentials orderCredentialsRef = new OrderCredentials(billNo++, dateTime);
            //OrderCredentialsDAO orderCrDAORef = new OrderCredentialsDAOImpl();
            //orderCrDAORef.insertOrderCredentials(orderCredentialsRef);

        }

        private void dataGridViewItemsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
             if (e.ColumnIndex==8)
            {
                MessageBox.Show("added to Cartt successfully");
                btn_Click(sender, e);
            }
            if (e.ColumnIndex == 6)
            {
              //  MessageBox.Show("+");
                increaseByOne(sender, e);
            }
            if (e.ColumnIndex == 7)
            {
               // MessageBox.Show("-");
                decreaseByOne(sender, e);
            }
        }
        void Sendmail(String s)
        {

            try
            {
                // Create the Outlook application.
                Microsoft.Office.Interop.Outlook.Application oApp = new Microsoft.Office.Interop.Outlook.Application();
                // Create a new mail item.
                Microsoft.Office.Interop.Outlook.MailItem oMsg = (Microsoft.Office.Interop.Outlook.MailItem)oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
                // Set HTMLBody. 
                //add the body of the email
                //oMsg.HTMLBody = null;
                oMsg.HTMLBody += "Item Name &emsp;";
                oMsg.HTMLBody += "quantity &emsp;";
                oMsg.HTMLBody += "Price <br />";

                oMsg.HTMLBody += s;

                //Subject line
                oMsg.Subject = "Order Details";
                // Add a recipient.
                Microsoft.Office.Interop.Outlook.Recipients oRecips = (Microsoft.Office.Interop.Outlook.Recipients)oMsg.Recipients;
                // Change the recipient in the next line if necessary.
                Microsoft.Office.Interop.Outlook.Recipient oRecip = oRecips.Add("Krathi.Kadamba@itcinfotech.com");
                oRecip.Resolve();
                // Send.
                oMsg.Send();
                // Clean up.
                oRecip = null;
                oRecips = null;
                oMsg = null;
                oApp = null;
            }//end of try block
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }//end of catch

        }

        private void dataGridViewItemsList_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is Button)
            {
                
               // MessageBox.Show("inside button clicked event");
                Button btn = e.Control as Button;
                btn.Click -= new EventHandler(btn_Click);
                btn.Click += new EventHandler(btn_Click);
            }
        }

        private void orderLbl_Click(object sender, EventArgs e)
        {
            string content = "";
            //if condition is to ensure that the Item list is not empty
            //string str1 = "";
            //str1 += "Item Name< br />";
            //str1 += "Quantity < br />";
            //str1 += "Price < br />";
            if (listOfItems.Count == 0)
            {
               // Console.WriteLine("^^^^^^^^^^^^^^^^^^listofItems size={0}",listOfItems.Count);
                MessageBox.Show("Cart is empty !!");
            }
            else
            {
               
                billNo = generateOrderId();
             
               
                DateTime dateTime = DateTime.UtcNow.Date;
                OrderCredentials orderCredentialsRef = new OrderCredentials(billNo, dateTime);
                OrderCredentialsDAO orderCrDAORef = new OrderCredentialsDAOImpl();
                orderCrDAORef.insertOrderCredentials(orderCredentialsRef);
                BillDAO billDAORef = new BillDAOImpl();
                Bill billRef = new Bill();
                for (int i = 0; i < listOfItems.Count; i++)
                {
                    string str = "";

                    billRef.billNoRef = orderCredentialsRef;
                    billRef.orderId = generateID();
                    Console.WriteLine("quantity:{0}\n", Convert.ToInt32(listOfItems[i][1]));
                    billRef.quantity = Convert.ToInt32(listOfItems[i][1]);
                    

                    Console.WriteLine("item name:{0}\n", Convert.ToString(listOfItems[i][0]));
                    billRef.selectedItemName = Convert.ToString(listOfItems[i][0]);


                    Console.WriteLine("price:{0}\n", Convert.ToDouble(listOfItems[i][2]));
                    billRef.price = Convert.ToDouble(listOfItems[i][2]);
                    billDAORef.insertBill(billRef);

                   
                    str += billRef.selectedItemName+ " &emsp;" + " &emsp;" + " &emsp;";
                    str += billRef.quantity+ "&emsp;" + "&emsp;" + "&emsp;" + "&emsp;";
                    str += billRef.price+ " &emsp;" + "&emsp;" + "&emsp;" + "&emsp;";
                    content +=  str+ "<br />";
                    
                }
              
                MessageBox.Show("Order Placed !!");
                canecelOrderBtn.Visible = true;
                listOfItems.Clear();
                
            }
    //      str1 += content;
            Console.WriteLine(str1);
        //    MessageBox.Show(str1);
            MessageBox.Show(content);
            Sendmail(content);

        }
        private int generateID()
        {
            DataBaseconnection DbCon = new DataBaseconnection();
            string qry = "select count(orderId) from dbo.order_orderBill;";
            SqlConnection cnn = DbCon.ObtainConnection();
           SqlCommand cmd = new SqlCommand(qry, cnn);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
             cnn.Close();
            return i++;

        }
        private int generateOrderId()
        {
            DataBaseconnection DbCon = new DataBaseconnection();
            string qry = "select count(billNo) from dbo.order_orderCredentials;";
            SqlConnection cnn = DbCon.ObtainConnection();
            SqlCommand cmd = new SqlCommand(qry, cnn);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
           cnn.Close();
            return i++;

        }

        void btn_Click(object sender, EventArgs e)
        {
            int col = this.dataGridViewItemsList.CurrentCell.ColumnIndex;
            int row = this.dataGridViewItemsList.CurrentCell.RowIndex;

            var rowRef = dataGridViewItemsList.Rows[row];
            var column = dataGridViewItemsList.Columns[col];
          //  MessageBox.Show("Button in Cell[" + col.ToString() + "," + row.ToString() + "] has been clicked");
            ArrayList cartAdd = new ArrayList();
            Items itemRef = new Items();
            itemRef.itemType = Convert.ToString(rowRef.Cells["Item Name"].Value); ;
            //if(flag_orderCredentials==0)
            //{
            //    DateTime dateTime = DateTime.UtcNow.Date;
            //    OrderCredentials orderCredentialsRef = new OrderCredentials(billNo, dateTime);
            //    OrderCredentialsDAO orderCrDAORef = new OrderCredentialsDAOImpl();
            //    orderCrDAORef.insertOrderCredentials(orderCredentialsRef);
            //    flag_orderCredentials++;
            //}
            // MessageBox.Show(itemRef.itemType);
            
            ArrayList billList = new ArrayList();
         
            billList.Add(Convert.ToString(rowRef.Cells["Item Name"].Value));
            billList.Add(Convert.ToInt32(rowRef.Cells["Quantity"].Value));
            billList.Add(Convert.ToInt32(rowRef.Cells["Price"].Value));

            listOfItems.Add(billList);

          //  billList.Add();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Satep1\n");
            BillDAO billDAOImpl = new BillDAOImpl();
            OrderCredentials o = new OrderCredentials();
            o.billNo = billNo;
            Bill billref = new Bill();
            billref.billNoRef = o;
            Console.WriteLine("Step22");
            List<ArrayList> listBill = billDAOImpl.getBillList(billref);
            for(int i=0;i<listBill.Count;i++)
            {
                Console.WriteLine("Step 3 inside for Loop\t");
                billref.orderId =Convert.ToInt32( listBill[i][0]);
                billDAOImpl.deleteBill(billref);
            }
            Console.WriteLine("step 4");
            OrderCredentialsDAO ordercRedDAORef = new OrderCredentialsDAOImpl();
            Console.WriteLine("Step5");
            ordercRedDAORef.deleteorderCredentials(o);
            MessageBox.Show("Order cancelled !!");
            canecelOrderBtn.Visible = false;


            try
            {
                // Create the Outlook application.
                Microsoft.Office.Interop.Outlook.Application oApp = new Microsoft.Office.Interop.Outlook.Application();
              
                // Create a new mail item.
                Microsoft.Office.Interop.Outlook.MailItem oMsg = (Microsoft.Office.Interop.Outlook.MailItem)oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
                
                // Set HTMLBody. 
                //add the body of the email
                //oMsg.HTMLBody = null;


                oMsg.HTMLBody = "Order got cancelled!!!!";


                //Subject line
                oMsg.Subject = "Order Details";
                // Add a recipient.
                Microsoft.Office.Interop.Outlook.Recipients oRecips = (Microsoft.Office.Interop.Outlook.Recipients)oMsg.Recipients;
                // Change the recipient in the next line if necessary.
                Microsoft.Office.Interop.Outlook.Recipient oRecip = oRecips.Add("Krathi.Kadamba@itcinfotech.com");
                oRecip.Resolve();
                // Send.
                oMsg.Send();
                // Clean up.
                oRecip = null;
                oRecips = null;
                oMsg = null;
                oApp = null;
            }//end of try block
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }//end of catch

        }

        private void placeOrderLbl_Click(object sender, EventArgs e)
        {

        }

        void increaseByOne(object sender, EventArgs e)
        {
            int col = this.dataGridViewItemsList.CurrentCell.ColumnIndex;
            int row = this.dataGridViewItemsList.CurrentCell.RowIndex;

            var rowRef = dataGridViewItemsList.Rows[row];
            var column = dataGridViewItemsList.Columns[col];
           // MessageBox.Show("Button in Cell[" + col.ToString() + "," + row.ToString() + "] has been clicked");
            ArrayList cartAdd = new ArrayList();

            Items itemRef = new Items();
           // int currentVal= Convert.ToInt32(rowRef.Cells["Quantity"].Value);
            qty++;
            rowRef.Cells["Quantity"].Value = qty;
            if(flag1==0)
            {
                price[row] = Convert.ToDouble(rowRef.Cells["Price"].Value);
                flag1++;
            }
             
            rowRef.Cells["Price"].Value = qty * price[row];
            Console.WriteLine("qty={0}\t price= {1}", qty, price);

            //itemRef.stock -= qty;

            qty = 1;
            //MessageBox.Show(itemRef.itemType);
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            canecelOrderBtn.Visible = false;
            flagForReset++;
            //  clear();
            if(flagForReset<=1)
            {
                dataGridViewItemsList.DataSource = null;
                dataGridViewItemsList.Columns.Remove("+");
                dataGridViewItemsList.Columns.Remove("-");
                dataGridViewItemsList.Columns.Remove("Add to Cart");
                categorynameCmb.Text = "";
                flag = 0;
            }
          
        }

        void decreaseByOne(object sender, EventArgs e)
        {
            int col = this.dataGridViewItemsList.CurrentCell.ColumnIndex;
            int row = this.dataGridViewItemsList.CurrentCell.RowIndex;

            var rowRef = dataGridViewItemsList.Rows[row];
            var column = dataGridViewItemsList.Columns[col];
           // MessageBox.Show("Button in Cell[" + col.ToString() + "," + row.ToString() + "] has been clicked");
            ArrayList cartAdd = new ArrayList();
            if (qty > 1)
            {
                qty--;
                rowRef.Cells["Quantity"].Value = qty;
                if (flag1 == 0)
                {
                    price[row] = Convert.ToDouble(rowRef.Cells["Price"].Value);
                    flag1++;
                }
             rowRef.Cells["Price"].Value = qty*price[row];
                Console.WriteLine("qty={0}\t price= {1}", qty, price);
            }
            else
                MessageBox.Show("quantity should be > 0");

            //Items itemRef = new Items();
            //itemRef.itemType = Convert.ToString(rowRef.Cells["Item Name"].Value); ;
            //MessageBox.Show(itemRef.itemType);
        }
        public void clear()
        {
            
            dataGridViewItemsList.DataSource = null;
            dataGridViewItemsList.Columns.Remove("+");
            dataGridViewItemsList.Columns.Remove("-");
            dataGridViewItemsList.Columns.Remove("Add to Cart");
            flag = 0;//to re create button

        }
       
    }
}
