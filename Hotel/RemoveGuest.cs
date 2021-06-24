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
    public partial class RemoveGuest : Form
    {
        public RemoveGuest()
        {
            InitializeComponent();
        }

        private void RemoveGuest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'guestDataSet.Guest' table. You can move, or remove it, as needed.
            this.guestTableAdapter.Fill(this.guestDataSet.Guest);
            // TODO: This line of code loads data into the 'bangalHotelDataSet3.Guest' table. You can move, or remove it, as needed.
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
            string query = "Delete [Guest] where SN = '" + searchBox.Text + "'";
            int result = DatabaseConnection.ExecuteQuery(query);
            DialogBox dialogBox = new DialogBox();

            if (result > 0)
            {
                dialogBox.setMessage("Successfully Deleted!");
                dialogBox.Show();
                load();
            }
            else
            {
                dialogBox.setMessage( "Failed To Deleted!");
                dialogBox.ChangeAnimationIcon(2);
                dialogBox.Show();
            }
        }

        private void load()
        {
            this.guestTableAdapter.Fill(this.guestDataSet.Guest);
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            string query;
            if (bunifuTextBox1.Text == "")
            {
                query = "select *from [Guest] ";
            }
            else
            {
                query = "select *from [Guest] where Name='" + bunifuTextBox1.Text + "'";
            }
            DataTable table = DatabaseConnection.ExecuteQuery2(query);
            grid.DataSource = table;
        }

        private void bunifuTextBox1_Click(object sender, EventArgs e)
        {
            bunifuTextBox1.IconLeft = null;
            bunifuTextBox1.IconRight = Hotel.Properties.Resources.outline_search_white_24dp;
        }

        private void bunifuTextBox1_MouseLeave(object sender, EventArgs e)
        {
            bunifuTextBox1.IconRight= null;
            bunifuTextBox1.IconLeft = Hotel.Properties.Resources.outline_search_white_24dp;
        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            string query = "select *from [Guest] ";
            DataTable table = DatabaseConnection.ExecuteQuery2(query);
            grid.DataSource = table;
        }

        private void availableBtn_Click(object sender, EventArgs e)
        {
            string query = "select *from [Guest] where CheckInDate ";
            DataTable table = DatabaseConnection.ExecuteQuery2(query);
            grid.DataSource = table;
        }

        private void bookedBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
