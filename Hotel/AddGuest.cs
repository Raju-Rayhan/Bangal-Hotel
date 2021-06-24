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
    public partial class AddGuest : Form
    {
        int flag = 1,f2=1; 
        public AddGuest()
        {
            InitializeComponent();
            setRoomItem();
        }
        private void AddGuest_Load(object sender, EventArgs e)
        {
            setRoomItem();
            AvailableRoomCheck();
        }
        private void registerBtn_Click(object sender, EventArgs e)
        {
            EmptyCheck();
            AvailableRoomCheck();
            if (flag == 1||f2==0)
            {
                RegisterGuestOperation();
            }
        }
        private void AvailableRoomCheck()
        {
            DialogBox db = new DialogBox();
            db.ChangeAnimationIcon(1);
            if (bokroom.Items.Count==0)
            {
                flag = 0;
                Dashboard.msgcount = "1";
                Dashboard.notice = "Not available room in our hotel.";
                db.setMessage("Not Found Available Room!");
                db.Show();
            }
        }

        private void setRoomItem()
        {
            bokroom.Items.Clear();
            string query = "select Room_No from [BangalHotel].[dbo].[Room] where Available = 'yes'";
            DataTable dt = DatabaseConnection.ExecuteQuery2(query);
            foreach (DataRow dr in dt.Rows)
            {
                if (dt.Rows.Count<0)
                {
                    DialogBox db = new DialogBox();
                    db.setMessage("Not Found Available Room!");
                    db.ChangeAnimationIcon(1);
                }
                 bokroom.Items.Add(dr["Room_No"].ToString());
            }
        }

        private void RegisterGuestOperation()
        {
            string query = "select *from [BangalHotel].[dbo].[Room] where Room_No = '" + bokroom.SelectedItem.ToString()+ "'";
            DatabaseConnection.ExecuteQuery6(query);

            string amt = DatabaseConnection.Price;
            string Discountamt = DatabaseConnection.DiscountAmt;
            float price = float.Parse(amt);
            float disamt = float.Parse(Discountamt);
            if (Discountamt != null)
            {
                price = (price - disamt);
            }
            
            string query1 = "INSERT INTO [BangalHotel].[dbo].[Guest](Name,Phone,NID,Address,DOB,EntryDate,BookedRoom,Ammount) VALUES('" + name.Text + "','" + phone.Text + "','" + nid.Text + "','" + address.Text + "','" + dob.Value.ToString() + "','" + Time() + "','" + bokroom.SelectedItem.ToString() + "','"+price+"')";
            int result = DatabaseConnection.ExecuteQuery(query1);
            DialogBox db = new DialogBox();

            if (result > 0)
            {
                db.setMessage("Guest Registerd Successfull!");
                db.Show();
                AllocateRoom();
            }
            else
            {
                db.setMessage("Guest Register Faild!");
                db.ChangeAnimationIcon(2);
                db.Show();
            }
        }
        private void AllocateRoom()
        {
            string query = "UPDATE [Room] SET Available='no' where Room_No='" + bokroom.SelectedItem.ToString()+ "'";
            DatabaseConnection.ExecuteQuery(query);
        }
        private string Time()
        {
            DateTime now = DateTime.Now;
            string time = now.ToString();
            return time;
        }

        private void EmptyCheck()
        {
            if(name.Text==""||phone.Text==""||address.Text==""||nid.Text==""|| dob.Text == "" || bokroom.SelectedItem.ToString() == null)
            {
                f2 = 0;
                DialogBox db = new DialogBox();
                db.setMessage("Please Fillup All Information !");
                db.ChangeAnimationIcon(2);
                db.Show();
            }
            else
            {
                f2 = 1;
            }
        }
    }

    
}
