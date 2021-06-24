using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class AllEmployee : Form
    {
        public AllEmployee()
        {
            InitializeComponent();
        }

        private void grid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                scroll.Maximum = grid.RowCount;
            }
            catch (Exception)
            {

            }

        }

        private void grid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                scroll.Maximum = grid.RowCount - 1;
            }
            catch (Exception)
            {

            }
        }
        private void scroll_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            try
            {
                grid.FirstDisplayedScrollingRowIndex = grid.Rows[e.Value].Index;
            }
            catch (Exception)
            {

            }
        }

        private void load()
        {
           
        }

        private void availableBtn_Click(object sender, EventArgs e)
        {
            string query = "select *from [Employee] where EmpType='Admin'";
            DataTable table = DatabaseConnection.ExecuteQuery2(query);
            grid.DataSource = table;
        }

        private void bookedBtn_Click(object sender, EventArgs e)
        {
            string query = "select *from [Employee] where EmpType='Manager'";
            DataTable table = DatabaseConnection.ExecuteQuery2(query);
            grid.DataSource = table;
        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            string query = "select *from [Employee] where EmpType='Recipsonist'";
            DataTable table = DatabaseConnection.ExecuteQuery2(query);
            grid.DataSource = table;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string query = "select *from [Employee] ";
            DataTable table = DatabaseConnection.ExecuteQuery2(query);
            grid.DataSource = table;
        }

        private void AllEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allEmployeeDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.allEmployeeDataSet.Employee);

        }
    }
}
