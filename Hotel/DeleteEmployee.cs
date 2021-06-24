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
    public partial class DeleteEmployee : Form
    {
        public DeleteEmployee()
        {
            InitializeComponent();
        }

        private void DeleteEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bangalHotelDataSet2.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.bangalHotelDataSet2.Employee);

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

        private void roomDeleteBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "")
            {
                DialogBox dialogBox = new DialogBox();
                dialogBox.setMessage("Please Enter Room Number !");
                dialogBox.ChangeAnimationIcon(2);
                dialogBox.Show();
            }
            else
            {
                string query = "Delete [Employee] where Email = '" + textBox.Text + "'";
                int result = DatabaseConnection.ExecuteQuery(query);
                DialogBox dialogBox = new DialogBox();

                if (result > 0)
                {
                    dialogBox.setMessage(" " + textBox.Text + ",Successfully Deleted!");
                    dialogBox.Show();
                    load();
                }
                else
                {
                    dialogBox.setMessage(" " + textBox.Text + ",Failed To Deleted!");
                    dialogBox.ChangeAnimationIcon(2);
                    dialogBox.Show();
                }
            }
            
        }

        private void load()
        {
            this.employeeTableAdapter.Fill(this.bangalHotelDataSet2.Employee);
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
    }
}
