using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trial.DAO;
using Trial.DAOImpl;
using Trial.entity;

namespace Trial
{
    public partial class loginPage : Form
    {
       public string username;
      public string mobileNo;
        public string EmailId;
        public loginPage()
        {
            InitializeComponent();
        }

        private void pwdLbl_Click(object sender, EventArgs e)
        {

        }

        private void pwdTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            UserMaster usrmasterRef = new UserMaster();
            usrmasterRef.mobileNo = mobileNoTxt.Text.Trim();
            usrmasterRef.pwd = pwdTxt.Text.Trim();
            RoleMaster role = new RoleMaster();


            usrmasterRef.designationRef = role;
            UserMasterDao usrmasterDAORef = new UserMasterDAOImpl();
            UserMaster usrmasterRef1 = usrmasterDAORef.login(usrmasterRef);
             username= usrmasterRef1.username;
            mobileNo = usrmasterRef1.mobileNo;
            EmailId = usrmasterRef1.emailId;
            if (usrmasterRef1!=null)
            {
                Console.WriteLine("Role Name ={0}", usrmasterRef1.designationRef.roleName);
                if (usrmasterRef1.designationRef.roleName == "Manager")
                {
                    manager Check = new manager();
                    Check.Show();
                    Hide();
                }
                else if (usrmasterRef1.designationRef.roleName == "Waiter")
                {
                    Waiter Check = new Waiter();
                    Check.Show();
                    Hide();
                }
                else if (usrmasterRef1.designationRef.roleName == "Admin")
                {
                    adminpage Check = new adminpage();
                    Check.Show();
                    Hide();
                }
            }
           
            else
            {
                MessageBox.Show("couln't login");
            }
        }

        private void loginPage_Load(object sender, EventArgs e)
        {
            //UserMasterDao usrMasterDAOREf = new UserMasterDAOImpl();
            //List<string> rolenamelist = usrMasterDAOREf.getRoleName();
            //foreach (var item in rolenamelist)
            //{
            //    designationCmb.Items.Add(item);
            //}
        }

        private void mobileNoTxt_Validating(object sender, CancelEventArgs e)
        {
            Regex mobilePattern = new Regex("^[1-9]{10}$"); // !mobilePattern.IsMatch(strNumber);
            if (string.IsNullOrEmpty(mobileNoTxt.Text.Trim()))
            {

                errorProvidermobileNo.SetError(mobileNoTxt, "please enter mobile No.!");

            }

            else if (!mobilePattern.IsMatch(mobileNoTxt.Text.Trim()))
            {
                errorProvidermobileNo.SetError(mobileNoTxt, "invalid mobile number");
            }
            else
            {

                errorProvidermobileNo.Clear();
            }
        }

        private void designationCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
