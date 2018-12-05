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
using Trial.DAOImpl;
using Trial.DAO;
using DataBaseConfig;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Trial
{
    public partial class adduserctrl : UserControl
    {
        public adduserctrl()
        {
            InitializeComponent();
        }

        private void AddUserControl_Load(object sender, EventArgs e)
        {
            UserMasterDao usrMasterDAOREf = new UserMasterDAOImpl();
            List<string> rolenamelist = usrMasterDAOREf.getRoleName();
            foreach (var item in rolenamelist)
            {
                designationCmb.Items.Add(item);
            }

        }

        private void useridlbl_Click(object sender, EventArgs e)
        {

        }

        private void nameLbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if(userNameTxt.Text=="" || mobileNoTxt.Text=="" || emailIDTxt.Text==""|| pwdTxt.Text==""|| confirmPwdTxt.Text=="" || dobDatePicker.Value== DateTime.UtcNow.Date )
            MessageBox.Show("enter all the values", "error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //if (ValidateChildren(ValidationConstraints.Enabled))
                //{
                //    MessageBox.Show(userNameTxt.Text, "Demo App - Message!");
                //}
                UserMasterDao usrMasterDAOREf = new UserMasterDAOImpl();
                UserMaster usrMasterRef = new UserMaster();


                usrMasterRef.username = userNameTxt.Text;
                usrMasterRef.mobileNo = mobileNoTxt.Text;
                usrMasterRef.address = addressTxt.Text;
                usrMasterRef.emailId = emailIDTxt.Text;
                usrMasterRef.pwd = pwdTxt.Text;
                string cpwd = confirmPwdTxt.Text;
                RoleMaster r = new RoleMaster();
                r.roleName = designationCmb.Text;
                usrMasterRef.designationRef = r;
                usrMasterRef.dob = dobDatePicker.Value;
                Console.WriteLine("\n date = {0}\n", usrMasterRef.dob);

                bool isChecked = malerbtn.Checked;
                if (isChecked)
                    usrMasterRef.gender = "M";
                else
                    usrMasterRef.gender = "F";
                if (usrMasterRef.pwd == cpwd)
                {
                    usrMasterDAOREf.insertUser(usrMasterRef);
                    clearFields();
                }
                else
                    MessageBox.Show("password doesn't match !!");
            }

        


        }
        private void clearFields()
        {

            userNameTxt.Text = "";
            mobileNoTxt.Text = "";
            addressTxt.Text = "";
            pwdTxt.Text = "";
            designationCmb.Text = "";
            malerbtn.Checked = false;
            femalerBtn.Checked = false;
            confirmPwdTxt.Text = "";
            emailIDTxt.Text = "";
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void designationCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(designationCmb.Text.Trim()))
            {
                errorProviderDesignation.SetError(designationCmb, "Please select a designation!");
            }
        }

        private void userNameTxt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(userNameTxt.Text.Trim()))
            {
                ErrProviderUsrName.SetError(userNameTxt, "please enter name!");


            }
            else
            {
               
                ErrProviderUsrName.Clear();
            }



        }

        private void mobileNoTxt_Validating(object sender, CancelEventArgs e)
        {
            Regex mobilePattern = new Regex("^[1-9]{10}$"); // !mobilePattern.IsMatch(strNumber);
            if (string.IsNullOrEmpty(mobileNoTxt.Text.Trim()))
            {

                errorProviderMobileNo.SetError(mobileNoTxt, "please enter mobile No.!");

            }
           
            else if (!mobilePattern.IsMatch(mobileNoTxt.Text.Trim()))
            {
                errorProviderMobileNo.SetError(mobileNoTxt, "invalid mobile number");
            }
            else
            {

                errorProviderMobileNo.Clear();
            }
        }

        private void addressTxt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(addressTxt.Text.Trim()))
                errorProviderAddress.SetError(addressTxt, "please enter address");
            else
            {

                errorProviderAddress.Clear();
            }
        }

        private void emailIDTxt_Validating(object sender, CancelEventArgs e)
        {
           //Regex mRegxExpression = new Regex(@"^[a-z0-9a-Z}*@[a-za-Z]*/.[A-Za-Z]$");
            Regex mRegxExpression = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (string.IsNullOrEmpty(emailIDTxt.Text.Trim()))
                errorProviderAddress.SetError(emailIDTxt, "please enter email ID");
        }

        private void pwdTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pwdTxt.Text.Trim()))
                errorProviderPwd.SetError(pwdTxt, "please neter password!");
            else
                errorProviderPwd.Clear();

        }

        private void genderPnl_Validating(object sender, CancelEventArgs e)
        {
            if (!femalerBtn.Checked && !malerbtn.Checked)
                errorProviderDOB.SetError(genderPnl, "pls select gender");
            else
                errorProviderDOB.Clear();
        }

        private void confirmPwdTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(confirmPwdTxt.Text.Trim()))
                errorProviderConfirmPwd.SetError(confirmPwdTxt, "pls enter confirm password");
            else if (pwdTxt.Text != confirmPwdTxt.Text)
                errorProviderConfirmPwd.SetError(confirmPwdTxt, "confirm password doenot match with the password !");
            else
                errorProviderConfirmPwd.Clear();
        }
    }
}
