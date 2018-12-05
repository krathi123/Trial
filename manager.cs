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
    public partial class manager : Form
    {
        string username;
        string mobileNo;
        string EmailId;
        public manager()
        {
            InitializeComponent();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            addCategotyUserCtrl1.Hide();
            addItemUsrCtrl11.Hide();
            editItem1.Hide();
            editcategoryUsrCtrl1.Hide();
        }

        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            homePage1.Hide();
            addCategotyUserCtrl1.Show();
            addItemUsrCtrl11.Hide();
             editItem1.Hide();
            editcategoryUsrCtrl1.Hide();
        }

        private void manager_Load(object sender, EventArgs e)
        {
            loginPage loginPageRef = new loginPage();
            username = loginPageRef.username;
            mobileNo = loginPageRef.mobileNo;
            EmailId = loginPageRef.EmailId;


            addItemUsrCtrl11.Hide();
            addCategotyUserCtrl1.Hide();
            editItem1.Hide();
            editcategoryUsrCtrl1.Hide();
            homePage1.Hide();

        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            addItemUsrCtrl11.Show();
            addCategotyUserCtrl1.Hide();
            editItem1.Hide();
            editcategoryUsrCtrl1.Hide();
            homePage1.Hide();
        }

        private void addCategotyUserCtrl1_Load(object sender, EventArgs e)
        {

        }

        private void addItemUsrCtrl11_Load(object sender, EventArgs e)
        {

        }

        private void editCategoryBtn_Click(object sender, EventArgs e)
        {
            editcategoryUsrCtrl1.Show();

            addItemUsrCtrl11.Hide();
            addCategotyUserCtrl1.Hide();
            editItem1.Hide();
            homePage1.Hide();

        }

        private void editItemBtn_Click(object sender, EventArgs e)
        {
            editItem1.Show();
            addItemUsrCtrl11.Hide();
            addCategotyUserCtrl1.Hide();
    
            editcategoryUsrCtrl1.Hide();
            homePage1.Hide();
        }

        private void editItem1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginPage login = new loginPage();
            login.Show();
            Hide();
        }
    }
}
