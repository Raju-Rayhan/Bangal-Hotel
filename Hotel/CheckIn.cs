using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Hotel.GuestDataSet;

namespace Hotel
{
    public partial class CheckIn : Form
    {
        public CheckIn()
        {
            InitializeComponent();
        }

        private void checkinBtn_Click(object sender, EventArgs e)
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
                isCheckinOrNot();
                if (DatabaseConnection.isCheckin == "")
                {
                    CheckinOperation();
                }
                else
                {
                    db.setMessage("Already Check In !");
                    db.ChangeAnimationIcon(1);
                    db.Show();
                }
            }
            
        }

        

        private void CheckIn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'guestCheckInDataset.Guest' table. You can move, or remove it, as needed.
            this.guestTableAdapter.Fill(this.guestCheckInDataset.Guest);

        }
        private void dataSetLoad()
        {
            this.guestTableAdapter.Fill(this.guestCheckInDataset.Guest);
        }

        private void CheckinOperation()
        {

            string query = "UPDATE [Guest] SET CheckInDate='" + Time() + "' where SN='" + textBox.Text + "'";
            int result = DatabaseConnection.ExecuteQuery(query);
            DialogBox db = new DialogBox();
            if (result > 0)
            {
                db.setMessage("Check In Successfull");
                dataSetLoad();
                db.Show();
            }
            else
            {
                db.setMessage("Check In Failed !");
                db.ChangeAnimationIcon(2);
                db.Show();
            }
        }
        private void isCheckinOrNot()
        {
            string query = "select *from [Guest] where SN='" + textBox.Text + "'";
            DatabaseConnection.ExecuteQuery8(query);
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

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "select *from [Guest] ";
            DataTable table = DatabaseConnection.ExecuteQuery2(query);
            grid.DataSource = table;
        }
    }
}
