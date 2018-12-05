using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trial
{
    public partial class adminpage : Form
    {
        //List<Panel> listpanel = new List<Panel>();
        //adduserctrl addusrctrl = new adduserctrl();
       
        public adminpage()
        {
            InitializeComponent();
        }

     

        private void AddUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trainingDataSet.order_user' table. You can move, or remove it, as needed.
            this.order_userTableAdapter.Fill(this.trainingDataSet.order_user);
            menupanel.Show();
            adduserctrl1.Hide();
            editUserCtrl1.Hide();
            viewUserCtrl1.Hide();
            editRoleCtrl1.Hide();
        }


        private void homeBtn_Click(object sender, EventArgs e)
        {
        }
            
        private void adduserBtn_Click(object sender, EventArgs e)
        {
            adduserctrl1.Show();
            homePage1.Hide();
            editUserCtrl1.Hide();
            viewUserCtrl1.Hide();
            addRoleUsrCtrl1.Hide();
            editRoleCtrl1.Hide();
        }

        private void updateuserBtn_Click(object sender, EventArgs e)
        {
            homePage1.Hide();
            editUserCtrl1.Show();
            adduserctrl1.Hide();
            addRoleUsrCtrl1.Hide();
            viewUserCtrl1.Hide();
            editRoleCtrl1.Hide();
        }
        

        private void viewuserBtn_Click(object sender, EventArgs e)
        {
            homePage1.Hide();
            viewUserCtrl1.Show();
            adduserctrl1.Hide();
            editUserCtrl1.Hide();
            addRoleUsrCtrl1.Hide();
            editRoleCtrl1.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            homePage1.Hide();
            addRoleUsrCtrl1.Show();
            viewUserCtrl1.Hide();
            adduserctrl1.Hide();
            editUserCtrl1.Hide();
            editRoleCtrl1.Hide();
        }

        private void addRoleUsrCtrl1_Load(object sender, EventArgs e)
        {

        }

        private void editRolebtn_Click(object sender, EventArgs e)
        {
            editRoleCtrl1.Show();
            addRoleUsrCtrl1.Hide();
            viewUserCtrl1.Hide();
            adduserctrl1.Hide();
            editUserCtrl1.Hide();
            homePage1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loginPage login = new loginPage();
            login.Show();
            Close();
        }
    }
}
