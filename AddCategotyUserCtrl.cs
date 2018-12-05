using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Trial.DAO;
using Trial.DAOImpl;
using Trial.entity;

namespace Trial
{
    public partial class AddCategotyUserCtrl : UserControl
    {
        public AddCategotyUserCtrl()
        {
            InitializeComponent();
        }

        private void categoryIdLbl_Click(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            // string constStr= ConfigurationManager.ConnectionStrings["connectionstr"].ToString();
            if(categorynameTxt.Text =="" || categorynDescTxt.Text=="")
                MessageBox.Show("pls enter all the values", "error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                CategoryDAO categoryDAORef = new CategoryDAOImpl();
                Category categoryRef = new Category();
                categoryRef.categoryName = categorynameTxt.Text;
                categoryRef.categoryDesc = categorynDescTxt.Text;
                categoryDAORef.insertCatelog(categoryRef);
                clearFields();
            }
          

        }
        private void clearFields()
        {
            categorynameTxt.Text = "";
            categorynDescTxt.Text = "";
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void categorynameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void categorynameTxt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(categorynameTxt.Text.Trim()))
                errorProvidercName.SetError(categorynameTxt, "pls enter Category name");
            else
                errorProvidercName.Clear();
        }

        private void categorynDescTxt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(categorynDescTxt.Text.Trim()))
                errorProvidercdesc.SetError(categorynDescTxt, "pls enter category name");
            else
                errorProvidercdesc.Clear();
        }
    }
}
