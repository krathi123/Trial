using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trial.DAOImpl;
using Trial.entity;
using Trial.DAO;

namespace Trial
{
    public partial class EditRoleCtrl : UserControl
    {
        public EditRoleCtrl()
        {
            InitializeComponent();
        }

        private void roleNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            RoleMasterDAO r = new RoleMasterDAOImpl();
            RoleMaster roleMaster = new RoleMaster();
            string roleName = roleNameTxt.Text;
            RoleMaster role = r.findbyprimaryKey(roleName);
            roleDescTxt.Text = role.roleDesc;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            RoleMaster roleMaster = new RoleMaster();
            RoleMasterDAO r = new RoleMasterDAOImpl();
            roleMaster.roleName = roleNameTxt.Text;
            roleMaster.roleDesc = roleDescTxt.Text;
            r.updaterole(roleMaster);
            clearfields();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            RoleMaster roleMaster = new RoleMaster();
            RoleMasterDAO r = new RoleMasterDAOImpl();
            roleMaster.roleName = roleNameTxt.Text;
            roleMaster.roleDesc = roleDescTxt.Text;
            r.deleteRole(roleMaster);
            clearfields();
        }
        private void clearfields()
        {
            roleNameTxt.Text = "";
            roleDescTxt.Text = "";
        }
    }
}
