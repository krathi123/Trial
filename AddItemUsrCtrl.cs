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

namespace Trial
{
    public partial class AddItemUsrCtrl1 : UserControl
    {
        public AddItemUsrCtrl1()
        {
            InitializeComponent();
        }

        private void itemIdLbl_Click(object sender, EventArgs e)
        {

        }

        private void categoryNameLbl_Click(object sender, EventArgs e)
        {

        }

        private void descriptionLbl_Click(object sender, EventArgs e)
        {

        }

        private void itemTypelbl_Click(object sender, EventArgs e)
        {

        }

        private void AddItemUsrCtrl_Load(object sender, EventArgs e)
        {

            CategoryDAO categoryDAORef = new CategoryDAOImpl();
            List<Category> categoryRef = categoryDAORef.getcategoryList(null);
            foreach (Category c in categoryRef)
                categoryTxt.Items.Add(c.categoryName);
        }

        private void addItemSubmitbtn_Click(object sender, EventArgs e)
        {
            if (itemNameTxt.Text == "" || itemDescTxt.Text == "" || categoryTxt.Text == "" || stockTxt.Text == "" || unitPriceTxt.Text=="")
                MessageBox.Show("enter all the values", "error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
            {
                ItemDAO itemsDAORef = new ItemDAOImpl();
                Items itemsRef = new Items();
                Category cRef = new Category();
                itemsRef.itemName = itemNameTxt.Text;
                itemsRef.description = itemDescTxt.Text;
                cRef.categoryName = categoryTxt.Text;
                itemsRef.stock = int.Parse(stockTxt.Text);
                itemsRef.unitprice = float.Parse(unitPriceTxt.Text);

                itemsRef.category = cRef;
                bool isChecked = vegRadioBtn.Checked;
                bool ischeckednonVeg = nonVegRadioBtn.Checked;

                if (isChecked)
                {

                    itemsRef.itemType = "Veg";
                }

                else if (ischeckednonVeg)
                {

                    itemsRef.itemType = "non-Veg";
                }

                else
                {

                    MessageBox.Show("please mention the type");
                }



                itemsDAORef.inseritems(itemsRef);
                clearFeilds();
            }

        }
        private void clearFeilds()
        {
            itemNameTxt.Text = "";
            categoryTxt.Text = "";
            itemDescTxt.Text = "";
            vegRadioBtn.Checked = false;
            nonVegRadioBtn.Checked = false;


        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            clearFeilds();
        }

        private void itemNameTxt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(itemNameTxt.Text.Trim()))
                errorProviderItemName.SetError(itemNameTxt, "pls neter item name");
            else
                errorProviderItemName.Clear();
        }

        private void categoryTxt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(categoryTxt.Text.Trim()))
                errorProvidercategoryName.SetError(categoryTxt, "pls neter category Name ");
            else
                errorProvidercategoryName.Clear();
        }

        private void itemDescriptionTxt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(itemDescTxt.Text.Trim()))
                errorProviderItemDesc.SetError(itemDescTxt, "pls  enter item description");
            else
                errorProviderItemDesc.Clear();
        }

        private void itemDescTxt_TextChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(itemDescTxt.Text.Trim()))
            //    errorProvider.SetError(itemDescTxt, "pls neter item name");
            //else stockTxt_TextChanged
            //    errorProvidercategoryName.Clear();
        }

        private void stockTxt_TextChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(itemDescTxt.Text.Trim()))
            //    errorProvider.SetError(itemDescTxt, "pls neter item name");
            //else stockTxt_TextChanged  stockTxt_Validating
            //    errorProvidercategoryName.Clear();
        }
        private void stockTxt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(stockTxt.Text.Trim()))
                errorProviderstock.SetError(stockTxt, "pls neter stock value");
            else
                errorProviderstock.Clear();
        }

        private void unitPriceTxt_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(unitPriceTxt.Text.Trim()))
                errorProviderunitprice.SetError(unitPriceTxt, "pls enter unit price  ");
            else
                errorProviderunitprice.Clear();
        }

        private void addItemLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
