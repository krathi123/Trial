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
    public partial class EditcategoryUsrCtrl : UserControl
    {
        public int flag = 0;
        public EditcategoryUsrCtrl()
        {
            InitializeComponent();
        }

      

       
        private void dataGridCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void testBtn_Click(object sender, EventArgs e)
        {

            flag = 1;

            CategoryDAO categoryDAORef = new CategoryDAOImpl();
            List<Category> categoryRef = new List<Category>();
             
            categoryRef = categoryDAORef.getcategoryList(null);
            Console.WriteLine("size of List :{0}", categoryRef);
            /* foreach (Category catgry in categoryRef)
                 Console.WriteLine("category name:{0} \n category value:{1}", categoryRef.); */
            dataGridViewTest.DataSource = categoryRef;
            dataGridViewTest.SelectedCells[0].ReadOnly = true;
           // Console.WriteLine("selected cell :{0}", dataGridViewTest.SelectedCells[0].ReadOnly);


            //  categoryDAORef.deleteCategory();

            deleteBtn.Visible = true;

        }

       



        private void dataGridViewTest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
        }

        private void searchCategorynameBtn_Click(object sender, EventArgs e)
        {





            flag = 1;
            Category categoryRef1 = new Category();
            categoryRef1.categoryName = categorynameTxt.Text;
            CategoryDAO categoryDAORef = new CategoryDAOImpl();
            List<Category> categoryRef = new List<Category>();

            categoryRef = categoryDAORef.getcategoryList(categoryRef1);
            Console.WriteLine("size of List :{0}", categoryRef);
            /* foreach (Category catgry in categoryRef)
                 Console.WriteLine("category name:{0} \n category value:{1}", categoryRef.); */
            dataGridViewTest.DataSource = categoryRef;
        
        // dataGridViewTest.SelectedCells[0].ReadOnly = true;
          
        }

        private void EditcategoryUsrCtrl_Load(object sender, EventArgs e)
        {
            deleteBtn.Visible = false;
        }

        private void dataGridViewTest_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridViewTest.Rows[e.RowIndex];
            var changedValue = (string)row.Cells[e.ColumnIndex].Value;
            Console.WriteLine(" *******************************Row value :{0} \n", row.Cells["categoryName"].Value);

            Console.WriteLine(" ^^^^^^^^^^^^^^^^^^Row value :{0} \n", Convert.ToString(row.Cells["categoryName"].Value));

            Category categoryRef1 = new Category();
            categoryRef1.categoryName = Convert.ToString(row.Cells["categoryName"].Value);
            categoryRef1.categoryDesc = changedValue;
            CategoryDAO categoryDAORef = new CategoryDAOImpl();
            categoryDAORef.updateCategory(categoryRef1);
            dataGridViewTest.Update();
            dataGridViewTest.Refresh();
        }
        

        private void dataGridViewTest_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


        



           

        }

        private void dataGridViewSample_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==3)
            {
                MessageBox.Show("hey");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            
            int rowIndex = dataGridViewTest.CurrentCell.RowIndex;
            var row = dataGridViewTest.Rows[rowIndex];
            var changedValue = (string)row.Cells[rowIndex].Value;
            Console.WriteLine("$$$$$$$$$$$$$$$$$ values:{0}", (string)row.Cells[rowIndex].Value);
           // dataGridViewTest.Rows.RemoveAt(rowIndex);

            Category categoryRef1 = new Category();
            categoryRef1.categoryName = Convert.ToString(row.Cells["categoryName"].Value);
            categoryRef1.categoryDesc = changedValue;
            CategoryDAO categoryDAORef = new CategoryDAOImpl();
            categoryDAORef.deleteCategory(categoryRef1);
            dataGridViewTest.Update();
            dataGridViewTest.Refresh();

        }
    }
}
