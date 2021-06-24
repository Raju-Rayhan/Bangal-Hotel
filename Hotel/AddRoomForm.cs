using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;

namespace Hotel
{
    public partial class AddRoomForm : Form
    {

        int isEmpty = 0;
        public AddRoomForm()
        {
            InitializeComponent();
            hideEmptyIcon();
        }

        private void addroomBtn_Click(object sender, EventArgs e)
        {
            DialogBox dialogBox = new DialogBox();
            textBoxEmptyError();
            CheckNotEmpty();
            if (isEmpty == 0)
            {
                //here data base method
                AddroomOperation();
            }
            else
            {
                dialogBox.setMessage("Please Fillup all Information!");
                dialogBox.ChangeAnimationIcon(1);
                dialogBox.Show();
            }
            isEmpty = 0;

        }
        private void hideEmptyIcon()
        {
            iconRoomName.Visible = false;
            iconRoomNo.Visible = false;
            iconRoomType.Visible = false;
            iconFloorNo.Visible = false;
            iconCupon.Visible = false;
            iconDiscounAmount.Visible = false;
            iconPrice.Visible = false;
            iconBed.Visible = false;
        }
        private void textBoxEmptyError()
        {
            if (roomNoTextBox.Text == "")
            {
                iconRoomNo.Visible = true;
            }
            else
            {
                iconRoomNo.Visible = false;
            }
            if (bedTypeBox.SelectedItem == null)
            {
                iconBed.Visible = true;
            }
            else
            {
                iconBed.Visible = false;
            }

            if (roomNameTextBox.Text == "")
            {
                iconRoomName.Visible = true;
            }
            else
            {
                iconRoomName.Visible = false;
            }

            if (floorNoTextBox.SelectedItem == null)
            {
                iconFloorNo.Visible = true;
            }
            else 
            {
                iconFloorNo.Visible = false;
            }

            if (roomTypeTexBox.SelectedItem == null)
            {
                iconRoomType.Visible = true;
            }
            else 
            {
                iconRoomType.Visible = false;
            }

            if (priceTextBox.Text == "")
            {
                iconPrice.Visible = true;
            }
            else
            {
                iconPrice.Visible = false;
            }
            if (discountAmtTextBox.Text != "")
            {
                if (cuponcodeTextBox.Text == "")
                {
                    iconCupon.Visible = true;
                }
                else
                {
                    iconCupon.Visible = false;
                }
            }
            else
            {
                iconCupon.Visible = false;
            }

        }

        private void CheckNotEmpty()
        {
            if(roomNoTextBox.Text == ""|| roomNameTextBox.Text==""|| priceTextBox.Text==""|| 
                roomTypeTexBox.SelectedItem== null || floorNoTextBox.SelectedItem==null || bedTypeBox.SelectedItem == null)
            {
                isEmpty = 1;
            }
            if (discountAmtTextBox.Text != "" && cuponcodeTextBox.Text == "")
            {
                isEmpty = 1;
            }
        }

        private void AddroomOperation()
        {
            string query = "INSERT INTO [Room](Room_Name,Room_No,Room_Type,Bed_No,Floor_No,Available,Price,DiscountAmt,Cupon) VALUES('" + roomNameTextBox.Text+"','"+roomNoTextBox.Text+"','"+ roomTypeTexBox.SelectedItem.ToString() + "','"+bedTypeBox.SelectedItem.ToString()+"','"+floorNoTextBox.SelectedItem.ToString()+"','Yes','"+priceTextBox.Text+"','"+discountAmtTextBox.Text+"','"+cuponcodeTextBox.Text+"')";
            int result = DatabaseConnection.ExecuteQuery(query);
            DialogBox db = new DialogBox();


            if (result > 0)
            {
                db.setMessage("Succesfully Room Added!");
                db.Show();
            }
            else
            {
                db.setMessage("Something Wrong!");
                db.ChangeAnimationIcon(2);
                db.Show();
            }
        }


    }
}
