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
using Trial.DAO;
using Trial.entity;

using System.Collections;

namespace Trial
{
    public partial class EditItem : UserControl
    {
        public EditItem()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewItems.SelectedCells[0].ReadOnly = true;
          
        }

        private void findAllBtn_Click(object sender, EventArgs e)
        {
            ItemDAO itemsDAORef = new ItemDAOImpl();
            // List<Items> itemList = new List<Items>();
            // itemList = itemsDAORef.getItemsList(null);

            List<string> listNm = new List<string>();
            listNm.Add("Item Name");
            listNm.Add("Category Name");
            listNm.Add("Item Desciption");
            listNm.Add("Item Type");
            listNm.Add("Stock");
            listNm.Add("Unit Price ");
            //List<List<string>> itemList = new List<List<string>>();
            List<ArrayList> itemList = new List<ArrayList>();
            itemList = itemsDAORef.getItemsListSample(null);
           
                dataGridViewItems.DataSource = CreateDataTable(listNm, itemList);
            //  dataGridView1.DataBindings()
            dataGridViewItems.Columns[0].ReadOnly = true;
            dataGridViewItems.Columns[1].ReadOnly = true;
            dataGridViewItems.Columns[2].ReadOnly = false;
            dataGridViewItems.Columns[3].ReadOnly = false;
            dataGridViewItems.Columns[4].ReadOnly = false;
            dataGridViewItems.Columns[5].ReadOnly = false;
            deleteBtn.Visible = true;
        }

        private System.Data.DataTable CreateDataTable(List<string> columnDefinitions, List<ArrayList> rows)
        {
            DataTable table = new DataTable();
            foreach (string colDef in columnDefinitions)
            {
                DataColumn column;
                column = new DataColumn();
                column.DataType = typeof(string);
                column.ColumnName = colDef;
                table.Columns.Add(column);
            }


            // Create DataRow and Add it to table
            foreach (ArrayList rowData in rows)
            {
                DataRow row = table.NewRow();
                // rowData is in same order as columnDefinitions
                for (int i = 0; i < rowData.Count; i++)
                {
                    row[i] = rowData[i];
                }
                table.Rows.Add(row);
            }


            return table;
        }

        private void searchItmCategorynameBtn_Click(object sender, EventArgs e)
        {
            ItemDAO itemsDAORef = new ItemDAOImpl();
            Items itemsRef = new Items();
            Category c = new Category();
            c.categoryName = ItmcategorynameTxt.Text;
            itemsRef.category = c;
            itemsRef.itemName = null;
            List<string> listNm = new List<string>();
            listNm.Add("Item Name");
            listNm.Add("Category Name");
            listNm.Add("Item Desciption");
            listNm.Add("Item Type");
            listNm.Add("Stock");
            listNm.Add("Unit Price");
            List<ArrayList> itemList = new List<ArrayList>();

            itemList = itemsDAORef.getItemsListSample(itemsRef);

            dataGridViewItems.DataSource = CreateDataTable(listNm, itemList);
            //  dataGridViewItems.SelectedCells[0].ReadOnly = true;
            dataGridViewItems.Columns[0].ReadOnly = true;
            dataGridViewItems.Columns[1].ReadOnly = true;
            dataGridViewItems.Columns[2].ReadOnly = false;
            dataGridViewItems.Columns[3].ReadOnly = false;
            dataGridViewItems.Columns[4].ReadOnly = false;
            dataGridViewItems.Columns[5].ReadOnly = false;

        }

        private void ItmcategorynameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Itmsearchcategorynamelbl_Click(object sender, EventArgs e)
        {

        }

        private void searchItemyIdBtn_Click(object sender, EventArgs e)
        {
            ItemDAO itemsDAORef = new ItemDAOImpl();
            Items itemsRef = new Items();
            itemsRef.itemName = byItemNameTxt.Text;
            Category c = new Category();
            c.categoryName = null;
            itemsRef.category = c;
            //column heading
            List<string> listNm = new List<string>();
            listNm.Add("Item Name");
            listNm.Add("Category Name");
            listNm.Add("Item Desciption");
            listNm.Add("Item Type");
            listNm.Add("Stock");
            listNm.Add("Unit Price");
            // List<List<string>> itemList = new List<List<string>>();
            List<ArrayList> itemList = new List<ArrayList>();
            itemList = itemsDAORef.getItemsListSample(itemsRef);

            dataGridViewItems.DataSource = CreateDataTable(listNm, itemList);

            dataGridViewItems.Columns[0].ReadOnly = true;
            dataGridViewItems.Columns[1].ReadOnly = true;
            dataGridViewItems.Columns[2].ReadOnly = false;
            dataGridViewItems.Columns[3].ReadOnly = false;
            //   dataGridViewItems.SelectedCells[0].ReadOnly = true;
            //dataGridViewItems.SelectedCells[0].ReadOnly = true;
        }

        private void byItemidTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void byItemIDLbl_Click(object sender, EventArgs e)
        {

        }

        private void EditItem_Load(object sender, EventArgs e)
        {
            deleteBtn.Visible = false;
        }

        private void dataGridViewItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("\n++++++++++ cell changed+++++++++++++++++\n");
            var row = dataGridViewItems.Rows[e.RowIndex];
            var col = dataGridViewItems.Columns[e.ColumnIndex];
            var changedValue = (string)row.Cells[e.ColumnIndex].Value;
            Console.WriteLine("************row index:{0}\t col: {1}", e.RowIndex,e.ColumnIndex);
            Console.WriteLine(" *******************************Row value :{0} \n", row.Cells["Item Desciption"].Value);

            Console.WriteLine(" ^^^^^^^^^^^^^^^^^^Row value :{0} \n", Convert.ToString(row.Cells["Item Desciption"].Value));

            Items itemRef = new Items();
            itemRef.itemName= Convert.ToString(row.Cells["Item Name"].Value); ;
            if (e.ColumnIndex == 2)
            {
               
                itemRef.description = changedValue;
                itemRef.unitprice = Convert.ToDouble(row.Cells[5].Value); ;
                itemRef.itemType = Convert.ToString(row.Cells["Item Type"].Value); ;
                itemRef.stock = Convert.ToInt16(row.Cells["Stock"].Value);
                Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^\ndescription={0}\t item type:{1}", itemRef.description,itemRef.itemType);
            }
              
            else if (e.ColumnIndex == 3)
            {
                itemRef.itemType = changedValue;
                itemRef.description = Convert.ToString(row.Cells["Item Desciption"].Value); 
                itemRef.unitprice = Convert.ToDouble(row.Cells[5].Value); 
                itemRef.stock = Convert.ToInt32(row.Cells["Stock"].Value);
            }
            else if (e.ColumnIndex == 4)
            {
                itemRef.stock = int.Parse(changedValue);
                itemRef.itemType = Convert.ToString(row.Cells["Item Type"].Value); ;
                itemRef.description = Convert.ToString(row.Cells["Item Desciption"].Value);
                itemRef.unitprice= Convert.ToDouble(row.Cells[5].Value); ;

            }
            else if (e.ColumnIndex == 5)
            {
                itemRef.unitprice = double.Parse(changedValue);
                itemRef.itemType = Convert.ToString(row.Cells["Item Type"].Value); ;
                itemRef.description = Convert.ToString(row.Cells["Item Desciption"].Value);
                itemRef.stock = Convert.ToInt32(row.Cells["Stock"].Value);

            }

            //listNm.Add("Item Desciption");
            //listNm.Add("Item Type");

            ItemDAO itemDAORef = new ItemDAOImpl();
            itemDAORef.updateItems(itemRef);

            dataGridViewItems.Update();
            dataGridViewItems.Refresh();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            int rowIndex = dataGridViewItems.CurrentCell.RowIndex;
            var row = dataGridViewItems.Rows[rowIndex];
            var changedValue = (string)row.Cells[rowIndex].Value;
            Console.WriteLine("$$$$$$$$$$$$$$$$$ values:{0}", (string)row.Cells[rowIndex].Value);
            // dataGridViewTest.Rows.RemoveAt(rowIndex);

            Items itemsRef1 = new Items();
            itemsRef1.itemName = Convert.ToString(row.Cells["Item Name"].Value);
           // itemsRef1.categoryDesc = changedValue;
            ItemDAO categoryDAORef = new ItemDAOImpl();
            categoryDAORef.deleteItems(itemsRef1);
            dataGridViewItems.Update();
            dataGridViewItems.Refresh();
        }

        private void edititemLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
