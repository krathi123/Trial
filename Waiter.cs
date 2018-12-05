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
    public partial class Waiter : Form
    {
        public Waiter()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void placeOrderBtn_Click(object sender, EventArgs e)
        {
            placeOrderUsrCtrl1.Show();
            homePage1.Hide();


        }

        private void placeOrderUsrCtrl1_Load(object sender, EventArgs e)
        {
            placeOrderUsrCtrl1.Hide();
            homePage1.Hide();
        }

        private void editOrderBtn_Click(object sender, EventArgs e)
        {
            placeOrderUsrCtrl1.Hide();
            homePage1.Hide();

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            loginPage login = new loginPage();
            login.Show();
            Hide();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            homePage1.Show();
            placeOrderUsrCtrl1.Hide();
        }

        private void Waiter_Load(object sender, EventArgs e)
        {

            homePage1.Show();

        }
    }
}
