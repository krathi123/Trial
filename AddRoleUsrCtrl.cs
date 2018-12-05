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

namespace Trial
{
    public partial class AddRoleUsrCtrl : UserControl
    {
        public AddRoleUsrCtrl()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (RoleNamecomboBox.Text == "" || roleDescTxt.Text == "")
                MessageBox.Show("enter all the values", "error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                RoleMasterDAOImpl r = new RoleMasterDAOImpl();
                RoleMaster roleMaster = new RoleMaster();
                roleMaster.roleName = RoleNamecomboBox.Text;
                roleMaster.roleDesc = roleDescTxt.Text;
                r.insertRole(roleMaster);
                clearTxt();
            }
           
        }

        private void clearTxt()
        {
            RoleNamecomboBox.Text = "";
            roleDescTxt.Text = "";
        }

        private void Rest_Click(object sender, EventArgs e)
        {
            RoleNamecomboBox.Text = "";
            roleDescTxt.Text = "";
        }

        private void AddRoleUsrCtrl_Load(object sender, EventArgs e)
        {
            List<string> roleList = new List<string>();
            roleList.Add("Manager");
            roleList.Add("Waiter");
            roleList.Add("Admin");
            foreach (var item in roleList)
            {
                RoleNamecomboBox.Items.Add(item);
            }
        }
    }
}
