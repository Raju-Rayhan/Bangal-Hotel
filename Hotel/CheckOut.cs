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
    public partial class CheckOut : Form
    {
        string Room_No;
        public CheckOut()
        {
            InitializeComponent();
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            DialogBox db = new DialogBox();
            if (textBox.Text == "")
            {
                db.setMessage("Please Enter Serial Number !");
                db.ChangeAnimationIcon(2);
                db.Show();
            }
            else
            {
                getBookRoom();
                if (DatabaseConnection.isCheckout == "")
                {
                    CheckOutOperation();
                    ReleaseRoom();
                }
                else
                {
                    db.setMessage("Alreay Check Out !");
                    db.ChangeAnimationIcon(2);
                    db.Show();
                }
            }
            
            

        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bangalHotelDataSet3.Guest' table. You can move, or remove it, as needed.
            this.guestTableAdapter.Fill(this.bangalHotelDataSet3.Guest);

        }
        private void CheckOutOperation()
        {
            string query = "UPDATE [Guest] SET CheckOutDate='" + Time() + "' where SN='" + textBox.Text + "'";
            int result = DatabaseConnection.ExecuteQuery(query);
            DialogBox db = new DialogBox();
            if (result > 0)
            {
                db.setMessage("Check Out Successfull");
                dataSetLoad();
                db.Show();
            }
            else
            {
                db.setMessage("Check Out Failed !");
                db.ChangeAnimationIcon(2);
                db.Show();
            }
        }
        private void dataSetLoad()
        {
            this.guestTableAdapter.Fill(this.bangalHotelDataSet3.Guest);
        }
        private void getBookRoom()
        {
            string query ="select *from [Guest] where SN='"+textBox.Text+"'";
            DatabaseConnection.ExecuteQuery9(query);
            Room_No = DatabaseConnection.Room_No;
        }
        private void ReleaseRoom()
        {
            string query = "UPDATE [Room] SET Available='yes' where Room_No='" +Room_No + "'";
            int result = DatabaseConnection.ExecuteQuery(query);
        }

        private string Time()
        {
            DateTime now = DateTime.Now;
            string time = now.ToString();
            return time;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string query;
            string name = bunifuTextBox1.Text;
            if (name == "")
            {
                query = "select *from [Guest] ";
            }
            else
            {
                query = "select *from [Guest] where Name='" + name + "'";
            }

            DataTable table = DatabaseConnection.ExecuteQuery2(query);
            grid.DataSource = table;
        }
        private void bunifuTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            string query = "select *from [Guest] ";
            DataTable table = DatabaseConnection.ExecuteQuery2(query);
            grid.DataSource = table;
        }
    }
}
