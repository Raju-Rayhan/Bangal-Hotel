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
    public partial class DeleteRoom : Form
    {
        public DeleteRoom()
        {
            InitializeComponent();
            //Example
        }

        private void scroll_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            try
            {
                grid.FirstDisplayedScrollingRowIndex = grid.Rows[e.Value].Index;
            }
            catch(Exception)
            {

            } 
        }

        private void grid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                scroll.Maximum = grid.RowCount;
            }
            catch(Exception)
            {

            }
            
        }

        private void grid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                scroll.Maximum = grid.RowCount-1;
            }
            catch(Exception)
            {

            }
        }

        private void scroll_Scroll_1(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
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
            if (searchBox.Text == "")
            {
                DialogBox dialogBox = new DialogBox();
                dialogBox.setMessage("Please Enter Room Number !");
                dialogBox.ChangeAnimationIcon(2);
                dialogBox.Show();
            }
            else
            {
                string query = "Delete [Room] where Room_No = '" + searchBox.Text + "'";
                int result = DatabaseConnection.ExecuteQuery(query);
                DialogBox dialogBox = new DialogBox();

                if (result > 0)
                {
                    dialogBox.setMessage("Room Number, " + searchBox.Text + ",Successfully Deleted!");
                    dialogBox.Show();
                    load();
                }
                else
                {
                    dialogBox.setMessage("Room Number, " + searchBox.Text + ",Failed To Deleted!");
                    dialogBox.ChangeAnimationIcon(2);
                    dialogBox.Show();
                }
            }
            
        }
        private void DeleteRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bangalHotelDataSet1.Room' table. You can move, or remove it, as needed.
            
            load();
            
        }
        private void load()
        {
            this.roomTableAdapter.Fill(this.bangalHotelDataSet1.Room);
        }

        private void availableBtn_Click(object sender, EventArgs e)
        {
            string query = "select *from [Room] where Available='yes'";
            DataTable table = DatabaseConnection.ExecuteQuery2(query);
            grid.DataSource = table;

        }

        private void bookedBtn_Click(object sender, EventArgs e)
        {
            string query = "select *from [Room] where Available='no'";
            DataTable table = DatabaseConnection.ExecuteQuery2(query);
            grid.DataSource = table;
        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            string query = "select *from [Room] ";
            DataTable table = DatabaseConnection.ExecuteQuery2(query);
            grid.DataSource = table;
        }
    }
}
