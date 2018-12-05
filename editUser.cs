using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trial.entity;
using Trial.DAO;
using Trial.DAOImpl;
using System.Collections;

namespace Trial
{
    public partial class editUser : UserControl
    {
        public editUser()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            UserMaster usrmasterRef = new UserMaster();
            usrmasterRef.username = byuseridTxt.Text;
            RoleMaster rolemasterRef = new RoleMaster();
            rolemasterRef.roleName = null;
            usrmasterRef.designationRef = rolemasterRef;
            UserMasterDao userMasterDaoRef = new UserMasterDAOImpl();
            List<string> listNm = new List<string>();
            listNm.Add("user Id");
            listNm.Add("User Name");
            listNm.Add("Mobile No");
            listNm.Add("Address");
            listNm.Add("gender");
            listNm.Add("Email Id");
            listNm.Add("DOB");
            listNm.Add("password");
            listNm.Add("designation");
            // List<List<string>> itemList = new List<List<string>>();
            List<ArrayList> usrList = new List<ArrayList>();
            usrList = userMasterDaoRef.getUsrList(usrmasterRef);

            dataGridVieweditUsr.DataSource = CreateDataTable(listNm, usrList);

            dataGridVieweditUsr.Columns[0].ReadOnly = true;
            dataGridVieweditUsr.Columns[1].ReadOnly = false;
            dataGridVieweditUsr.Columns[2].ReadOnly = false;
            dataGridVieweditUsr.Columns[3].ReadOnly = false;
            dataGridVieweditUsr.Columns[4].ReadOnly = false;
            dataGridVieweditUsr.Columns[5].ReadOnly = false;
            dataGridVieweditUsr.Columns[6].ReadOnly = false;
            dataGridVieweditUsr.Columns[7].ReadOnly = false;
            dataGridVieweditUsr.Columns[8].ReadOnly = true;
            dataGridVieweditUsr.FirstDisplayedScrollingRowIndex = dataGridVieweditUsr.RowCount - 1;
            dataGridVieweditUsr.FirstDisplayedScrollingRowIndex = dataGridVieweditUsr.ColumnCount - 1;

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

        private void searchdesgBtn_Click(object sender, EventArgs e)
        {

            UserMaster usrmasterRef = new UserMaster();
            usrmasterRef.username = "";
            RoleMaster rolemasterRef = new RoleMaster();
            rolemasterRef.roleName = searchdesgTxt.Text;
            Console.WriteLine("inside else if \nRole Name:{0}", rolemasterRef.roleName);
            usrmasterRef.designationRef = rolemasterRef;
            Console.WriteLine("in user edit \nRole Name:{0}", usrmasterRef.designationRef.roleName);
            UserMasterDao userMasterDaoRef = new UserMasterDAOImpl();
            List<string> listNm = new List<string>();
            listNm.Add("user Id");
            listNm.Add("User Name");
            listNm.Add("Mobile No");
            listNm.Add("Address");
            listNm.Add("gender");
            listNm.Add("Email Id");
            listNm.Add("DOB");
            listNm.Add("password");
            listNm.Add("designation");
            // List<List<string>> itemList = new List<List<string>>();
            List<ArrayList> usrList = new List<ArrayList>();
            usrList = userMasterDaoRef.getUsrList(usrmasterRef);

            dataGridVieweditUsr.DataSource = CreateDataTable(listNm, usrList);
            dataGridVieweditUsr.Columns[0].ReadOnly = true;
            dataGridVieweditUsr.Columns[1].ReadOnly = false;
            dataGridVieweditUsr.Columns[2].ReadOnly = false;
            dataGridVieweditUsr.Columns[3].ReadOnly = false;
            dataGridVieweditUsr.Columns[4].ReadOnly = false;
            dataGridVieweditUsr.Columns[5].ReadOnly = false;
            dataGridVieweditUsr.Columns[6].ReadOnly = false;
            dataGridVieweditUsr.Columns[7].ReadOnly = false;
            dataGridVieweditUsr.Columns[8].ReadOnly = true;
            dataGridVieweditUsr.FirstDisplayedScrollingRowIndex = dataGridVieweditUsr.RowCount - 1;
        //    dataGridVieweditUsr.FirstDisplayedScrollingRowIndex = dataGridVieweditUsr.ColumnCount - 1;
        }

        private void findAllbtn_Click(object sender, EventArgs e)
        {
            
            UserMasterDao userMasterDaoRef = new UserMasterDAOImpl();
            List<string> listNm = new List<string>();
            listNm.Add("user Id");
            listNm.Add("User Name");
            listNm.Add("Mobile No");
            listNm.Add("Address");
            listNm.Add("gender");
            listNm.Add("Email Id");
            listNm.Add("DOB");
            listNm.Add("password");
            listNm.Add("designation");
            // List<List<string>> itemList = new List<List<string>>();
            List<ArrayList> usrList = new List<ArrayList>();
            usrList = userMasterDaoRef.getUsrList(null);

            dataGridVieweditUsr.DataSource = CreateDataTable(listNm, usrList);
            dataGridVieweditUsr.Columns[0].ReadOnly = true;
            dataGridVieweditUsr.Columns[1].ReadOnly = false;
            dataGridVieweditUsr.Columns[2].ReadOnly = false;
            dataGridVieweditUsr.Columns[3].ReadOnly = false;
            dataGridVieweditUsr.Columns[4].ReadOnly = false;
            dataGridVieweditUsr.Columns[5].ReadOnly = false;
            dataGridVieweditUsr.Columns[6].ReadOnly = false;
           dataGridVieweditUsr.Columns[7].ReadOnly = false;
            dataGridVieweditUsr.Columns[8].ReadOnly = true;
            dataGridVieweditUsr.FirstDisplayedScrollingRowIndex = dataGridVieweditUsr.RowCount - 1;
            //dataGridVieweditUsr.FirstDisplayedScrollingRowIndex = dataGridVieweditUsr.ColumnCount - 1;
        }

        private void byuseridTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchdesgTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void editUser_Load(object sender, EventArgs e)
        {

        }

        private void dataGridVieweditUsr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridVieweditUsr_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("\n++++++++++ cell changed+++++++++++++++++\n");
            var row = dataGridVieweditUsr.Rows[e.RowIndex];
            var col = dataGridVieweditUsr.Columns[e.ColumnIndex];
            var changedValue = (string)row.Cells[e.ColumnIndex].Value;
            Console.WriteLine("************row index:{0}\t col: {1}", e.RowIndex, e.ColumnIndex);
            Console.WriteLine(" *******************************Row value :{0} \n", row.Cells["User Name"].Value);
            Console.WriteLine("Changed value:{0}\n", changedValue);
            UserMaster usermasterRef = new UserMaster();
            usermasterRef.userid = Convert.ToInt32(row.Cells["user Id"].Value);
            Console.WriteLine(" *******************************Row value :{0} \n", row.Cells["user Id"].Value);
            RoleMaster role = new RoleMaster();
            role.roleName  = Convert.ToString(row.Cells["designation"].Value);
            usermasterRef.designationRef = role;
            usermasterRef.designationRef.roleName = Convert.ToString(row.Cells["designation"].Value);
            if (e.ColumnIndex==1)
            {
                MessageBox.Show("User name updated");
                usermasterRef.username= changedValue;
                usermasterRef.mobileNo =Convert.ToString(row.Cells["Mobile No"].Value);
                usermasterRef.address = Convert.ToString(row.Cells["Address"].Value);
                usermasterRef.gender = Convert.ToString(row.Cells["gender"].Value);
                usermasterRef.emailId = Convert.ToString(row.Cells["Email Id"].Value);
                usermasterRef.dob = Convert.ToDateTime(row.Cells["DOB"].Value);
                usermasterRef.pwd = Convert.ToString(row.Cells["password"].Value);
           

            }
           else if (e.ColumnIndex == 2)
            {
                MessageBox.Show("mobile No. updated!!");
                usermasterRef.mobileNo = changedValue;
                usermasterRef.username = Convert.ToString(row.Cells["User Name"].Value);
                usermasterRef.address = Convert.ToString(row.Cells["Address"].Value);
                usermasterRef.gender = Convert.ToString(row.Cells["gender"].Value);
                usermasterRef.emailId = Convert.ToString(row.Cells["Email Id"].Value);
                usermasterRef.dob = Convert.ToDateTime(row.Cells["DOB"].Value);
                usermasterRef.pwd = Convert.ToString(row.Cells["password"].Value);
             //  

            }
          else  if (e.ColumnIndex == 3)
            {
                MessageBox.Show("address updated!!");
                usermasterRef.address = changedValue;
                usermasterRef.username = Convert.ToString(row.Cells["User Name"].Value);
                usermasterRef.mobileNo = Convert.ToString(row.Cells["Mobile No"].Value);
                usermasterRef.gender = Convert.ToString(row.Cells["gender"].Value);
                usermasterRef.emailId = Convert.ToString(row.Cells["Email Id"].Value);
                usermasterRef.dob = Convert.ToDateTime(row.Cells["DOB"].Value);
                usermasterRef.pwd = Convert.ToString(row.Cells["password"].Value);
              //  usermasterRef.designationRef.roleName = Convert.ToString(row.Cells["designation"].Value);

            }
          else  if (e.ColumnIndex == 4)
            {
                MessageBox.Show("gender updated!!");
                usermasterRef.gender = changedValue;
                usermasterRef.username = Convert.ToString(row.Cells["User Name"].Value);
                usermasterRef.mobileNo = Convert.ToString(row.Cells["Mobile No"].Value);
                usermasterRef.address = Convert.ToString(row.Cells["Address"].Value);
                usermasterRef.emailId = Convert.ToString(row.Cells["Email Id"].Value);
                usermasterRef.dob = Convert.ToDateTime(row.Cells["DOB"].Value);
                usermasterRef.pwd = Convert.ToString(row.Cells["password"].Value);
              //  usermasterRef.designationRef.roleName = Convert.ToString(row.Cells["designation"].Value);

            }
         else   if (e.ColumnIndex == 5)
            {
                MessageBox.Show("emailId updated!!");
                usermasterRef.emailId = changedValue;
                usermasterRef.username = Convert.ToString(row.Cells["User Name"].Value);
                usermasterRef.mobileNo = Convert.ToString(row.Cells["Mobile No"].Value);
                usermasterRef.address = Convert.ToString(row.Cells["Address"].Value);
                usermasterRef.gender = Convert.ToString(row.Cells["gender"].Value);
                usermasterRef.dob = Convert.ToDateTime(row.Cells["DOB"].Value);
                usermasterRef.pwd = Convert.ToString(row.Cells["password"].Value);
              //  usermasterRef.designationRef.roleName = Convert.ToString(row.Cells["designation"].Value);

            }
            else if (e.ColumnIndex == 6)
            {
                MessageBox.Show("dob updated!!");
                usermasterRef.dob = Convert.ToDateTime(changedValue);
                usermasterRef.username = Convert.ToString(row.Cells["User Name"].Value);
                usermasterRef.mobileNo = Convert.ToString(row.Cells["Mobile No"].Value);
                usermasterRef.address = Convert.ToString(row.Cells["Address"].Value);
                usermasterRef.gender = Convert.ToString(row.Cells["gender"].Value);
                usermasterRef.emailId = Convert.ToString(row.Cells["Email Id"].Value);
                usermasterRef.pwd = Convert.ToString(row.Cells["password"].Value);
              //  usermasterRef.designationRef.roleName = Convert.ToString(row.Cells["designation"].Value);

            }
            else if (e.ColumnIndex == 7)
            {
                MessageBox.Show("pwd updated!!");
                usermasterRef.pwd = (changedValue);
                usermasterRef.username = Convert.ToString(row.Cells["User Name"].Value);
                usermasterRef.mobileNo = Convert.ToString(row.Cells["Mobile No"].Value);
                usermasterRef.address = Convert.ToString(row.Cells["Address"].Value);
                usermasterRef.gender = Convert.ToString(row.Cells["gender"].Value);
                usermasterRef.emailId = Convert.ToString(row.Cells["Email Id"].Value);
                usermasterRef.dob = Convert.ToDateTime(row.Cells["DOB"].Value);
             //   usermasterRef.designationRef.roleName = Convert.ToString(row.Cells["designation"].Value);

            }
           
            UserMasterDao userMasterDaoRef = new UserMasterDAOImpl();
            userMasterDaoRef.updateUser(usermasterRef);


        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
             UserMaster usermasterRef = new UserMaster();
            int rowIndex = dataGridVieweditUsr.CurrentCell.RowIndex;
            var row = dataGridVieweditUsr.Rows[rowIndex];
            var changedValue = (string)row.Cells[rowIndex].Value;
            Console.WriteLine("$$$$$$$$$$$$$$$$$ values:{0}", (string)row.Cells[rowIndex].Value);
          

            usermasterRef.userid = Convert.ToInt32(row.Cells["user Id"].Value);
          
            UserMasterDao userMasterDaoRef = new UserMasterDAOImpl();
            userMasterDaoRef.deleteUser(usermasterRef);
            dataGridVieweditUsr.Update();
            dataGridVieweditUsr.Refresh();
        }
    }
}
