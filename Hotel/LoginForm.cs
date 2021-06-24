using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Hotel
{
    public partial class LoginForm : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );

        public LoginForm()
        {
            InitializeComponent();
            iconPassEmpty.Visible = false;
            iconUsernaneEmpty.Visible = false;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        //Show Password Checkbox Perform
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                loginpass.UseSystemPasswordChar = false;
                bunifuLabel1.Text = "Hide password";
            }
            else if (!checkBox1.Checked)
            {
                loginpass.UseSystemPasswordChar = true;
                bunifuLabel1.Text = "Show password";
            }
        }
        //Show Password Checkbox End

        //Login Username Perform
        private void loginusername_TextChanged(object sender, EventArgs e)
        {
            if (loginusername.Text != "")
            {
                iconUsernaneEmpty.Visible = false;
            }
            else if (loginusername.Text == "")
            {
                iconUsernaneEmpty.Visible = true;
            }
        }
        //Login Username End


        //Login Password perform
        private void loginpass_TextChanged(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked)
            {
                loginpass.UseSystemPasswordChar = false;
            }
            else
            {
                loginpass.UseSystemPasswordChar = true;
            }

            if (loginpass.Text != "")
            {
                iconPassEmpty.Visible = false;
            }
            else if(loginpass.Text == "")
            {
                iconPassEmpty.Visible = true;
            }
        }
        //Login Password End

        private void iconExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Login Button Perform
        private void loginBtn_Click(object sender, EventArgs e)
        {
            DialogBox box = new DialogBox();

            if ((loginusername.Text == "") && (loginpass.Text == ""))
            {
                box.setMessage("Username and Password Required!");
                box.ChangeAnimationIcon(1);
                box.Show();
            }
            if (loginusername.Text == "")
            {
                box.setMessage("Username Required !");
                box.ChangeAnimationIcon(1);
                box.Show();
            }
            else if (loginpass.Text == "")
            {
                box.setMessage("Password Required !");
                box.ChangeAnimationIcon(1);
                box.Show();
            }
            else
            {
                LoginAuthontication();
                loginpass.Clear();
            }
        }

        private void iconExitBtn_MouseHover(object sender, EventArgs e)
        {
            iconExitBtn.IconColor = Color.Red;
        }

        private void iconExitBtn_MouseLeave(object sender, EventArgs e)
        {
            iconExitBtn.IconColor = Color.Gainsboro;
        }




        //Login Authontication
        private void LoginAuthontication()
        {
            string query = "select *from [BangalHotel].[dbo].[Employee] where Email = '" + loginusername.Text + "' and Password = '" + loginpass.Text + "'";
            DataTable table = DatabaseConnection.LoadData(query);
            DatabaseConnection.ExecuteQuery4(query);
            string Name = DatabaseConnection.Name;
            DialogBox dialogBox = new DialogBox();

            if (table.Rows.Count == 1)
            {
                Dashboard.email = "loginusername.Text";
                Dashboard.pass = "loginpass.Text";
                dialogBox.setMessage("" + Name + " ,Login Successfull !");
                Dashboard dashboard = new Dashboard();
                dialogBox.okButtonOperation(dashboard);
                dialogBox.Show();
                this.Hide();

            }
            else
            {
                dialogBox.setMessage("" + loginusername.Text + " ,Login Failed !");
                dialogBox.ChangeAnimationIcon(2);
                dialogBox.Show();
            }
        }


    }
}
