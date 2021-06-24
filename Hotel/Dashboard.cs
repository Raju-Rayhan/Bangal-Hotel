using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Bunifu.UI;
using System.IO;

namespace Hotel
{
    public partial class Dashboard : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private Panel subMenuPanel;
        private int defaultPopUpX, defaultPopUpY;
        private int defaultNotiFicX, defaultNotiFicY;

        public static string email, pass;
        string user;
        public Dashboard()
        {
            InitializeComponent();
            setInfo();
            hideSubMenu();
            panelNotification.Visible = false;
            panelPopUp.Visible = false;
            //PopUp Panel Loaction
            defaultPopUpX = panelPopUp.Location.X;
            defaultPopUpY = panelPopUp.Location.Y;
            defaultNotiFicX = panelNotification.Location.X;
            defaultNotiFicY = panelNotification.Location.Y;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActiveButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child From
                iconCurrentChilldrenForm.IconChar = currentBtn.IconChar;
                iconCurrentChilldrenForm.IconColor = color;
            }

        }
        private void ActiveSubButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Icon Current Child From
                iconCurrentChilldrenForm.IconChar = currentBtn.IconChar;
                iconCurrentChilldrenForm.IconColor = color;
            }

        }


        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        //Sub Menu Panel
        private void hideSubMenu()
        {
            guestSubPanel.Visible = false;
            hotelConfSubMenu.Visible = false;
            empSubPanel.Visible = false;
        }
        private void showSubMenu(Panel submenu)
        {
            subMenuPanel = submenu;
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else if (submenu.Visible == true)
            {
                submenu.Visible = false;
            }
            
        }

        //All Menu 
        private void iconDash_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            Reset();
        }

        private void iconHome_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
        private void iconHotelconf_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
            showSubMenu(hotelConfSubMenu);
        }
        private void iconGuest_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color6);
            showSubMenu(guestSubPanel);
        }
        private void iconEmp_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color5);
            showSubMenu(empSubPanel);
        }

        private void iconAddRoom_Click(object sender, EventArgs e)
        {
            ActiveSubButton(sender, RGBColors.color4);
            hideSubMenu();
            OpenChildForm(new AddRoomForm());
        }

        private void iconDeleteRoom_Click(object sender, EventArgs e)
        {
           ActiveSubButton(sender, RGBColors.color5);
            hideSubMenu();
            OpenChildForm(new DeleteRoom());
        }

        private void iconNewGuest_Click(object sender, EventArgs e)
        {
            ActiveSubButton(sender, RGBColors.color1);
            OpenChildForm(new AddGuest());
            hideSubMenu();
        }

        private void iconGuestCheckIn_Click(object sender, EventArgs e)
        {
            ActiveSubButton(sender, RGBColors.color2);
            OpenChildForm(new CheckIn());
            hideSubMenu();
        }

        private void iconGuestCheckOut_Click(object sender, EventArgs e)
        {
            ActiveSubButton(sender, RGBColors.color3);
            OpenChildForm(new CheckOut());
            hideSubMenu();
            
        }

        private void iconDeleteGuest_Click(object sender, EventArgs e)
        {
            ActiveSubButton(sender, RGBColors.color4);
            if (user== "Recipsonist    ")
            {
                msgcount = "1";
                notice = "Not available for you to Delete Operation.";
            }
            else
            {
                OpenChildForm(new RemoveGuest());
            }
            hideSubMenu();
        }

        private void iconAllEmp_Click(object sender, EventArgs e)
        {
            ActiveSubButton(sender, RGBColors.color2);
            if (user == "Recipsonist    ")
            {
                msgcount = "1";
                notice = "Not available for you to Employee Operation.";
            }
            else
            {
                OpenChildForm(new RemoveGuest());
            }
            hideSubMenu();
        }

        private void iconNewEmp_Click(object sender, EventArgs e)
        {
            ActiveSubButton(sender, RGBColors.color3);
            if (user == "Recipsonist    ")
            {
                msgcount = "1";
                notice = "Not available for you to Employee Operation.";
            }
            else
            {
                OpenChildForm(new EmployeeRegistration());
            }
            OpenChildForm(new EmployeeRegistration());
            hideSubMenu();
        }

        private void iconDeleteEmp_Click(object sender, EventArgs e)
        {
            ActiveSubButton(sender, RGBColors.color4);
            if (user == "Recipsonist    "|| user == "Manager        ")
            {
                msgcount = "1";
                notice = "Not available for you to Employee Delete Operation.";
            }
            else
            {
                OpenChildForm(new DeleteEmployee());
            }
            hideSubMenu();
            
        }


        //Log Out Button
        private void iconLogout_MouseHover(object sender, EventArgs e)
        {
            iconLogout.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconLogout.IconColor = Color.FromArgb(24, 161, 251);
            iconLogout.ForeColor = Color.FromArgb(24, 161, 251);
            iconLogout.TextAlign = ContentAlignment.MiddleCenter;
            iconLogout.ImageAlign = ContentAlignment.MiddleRight;
        }
        private void iconLogout_Mouseleave(object sender, EventArgs e)
        {
            iconLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconLogout.IconColor = Color.Gainsboro;
            iconLogout.ForeColor = Color.Gainsboro;
            iconLogout.TextAlign = ContentAlignment.MiddleLeft;
            iconLogout.ImageAlign = ContentAlignment.MiddleLeft;
        }
        private void iconLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        //Reset Method
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChilldrenForm.IconChar = IconChar.Home;
            iconCurrentChilldrenForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }

        //Drag From
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Close Button
        private void iconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void iconExit_MouseHover(object sender, EventArgs e)
        {
            iconExit.IconColor = Color.Red;
        }

        private void iconExit_MouseLeave(object sender, EventArgs e)
        {
            iconExit.IconColor = Color.Gainsboro;
        }

        //Maximize button 
        private void iconMaximie_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = System.Windows.Forms.FormWindowState.Maximized;
                panelPopUp.Location = new Point(panel3.Location.X,panel3.Location.Y);
                panelNotification.Location = new Point(panel3.Location.X, panel3.Location.Y);
            }
            else
            {
                WindowState = System.Windows.Forms.FormWindowState.Normal;
                panelPopUp.Location = new Point(defaultPopUpX, defaultPopUpY);
                panelNotification.Location = new Point(defaultNotiFicX, defaultNotiFicY);

            }
        }
        private void iconMaximize_MouseHover(object sender, EventArgs e)
        {
            iconMaximize.IconColor = Color.DarkGray;
        }
        private void iconMaximize_MouseLeave(object sender, EventArgs e)
        {
            iconMaximize.IconColor = Color.Gainsboro;
        }


        //Minimize Button
        private void iconMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void iconMinimize_MouseHover(object sender, EventArgs e)
        {
            iconMinimize.IconColor = Color.DarkGray;
        }
        
        private void iconMinimize_MouseLeave(object sender, EventArgs e)
        {
            iconMinimize.IconColor = Color.Gainsboro;
        }

        
        //Dashboard_Load
        private void Dashboard_Load(object sender, EventArgs e)
        {
            UserInformation();
        }



        //Notification Panel
        public static string msgcount = "0";
        public static string notice = "No longer notice !";
        private void iconNotification_Click(object sender, EventArgs e)
        {
            if (panelNotification.Visible == false)
            {
                msgcount = "0";
                notifycount.Text = msgcount;
                noticeText.Text = notice;
                panelNotification.Visible = true;
                panelNotification.BringToFront();  
            }
            else
            {
                panelNotification.Visible = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(panelNotification.Visible == true)
            {
                panelNotification.Visible = false;
            }
            
        }
        private void notifycount_Paint(object sender, PaintEventArgs e)
        {
            if (panelNotification.Visible == true)
            {
                msgcount = "0";
            }
            notifycount.Text = msgcount;
        }

        


        //PopUp Menu Tooggle
        private void iconDownMenu_Click(object sender, EventArgs e)
        {
            if (panelPopUp.Visible == false)
            {
                panelPopUp.Visible = true;
                panelPopUp.BringToFront();
            }
            else
            {
                panelPopUp.Visible = false;
            }
        }

        private void setInfo()
        {
            string query = "select [Employee] where Email='" + email + "' and Password='" + pass + "'";
            DatabaseConnection.ExecuteQuery4(query);
            user = DatabaseConnection.Type;
        }
        private void UserInformation()
        {
            popupprofileName.Text = DatabaseConnection.Name;
            emailLbl.Text = DatabaseConnection.Email;
            lblBloodGroup.Text = DatabaseConnection.BG;
            lblDob.Text = DatabaseConnection.DOB;
            lblJoinDate.Text = DatabaseConnection.JoinDate;
            if (DatabaseConnection.ProfileImage == null)
            {
                //profileImage.ImageLocation = Image.FromFile(C:/Users/rajur/source/repos/Hotel/Hotel/Icon/user.png);
            }
            else
            {
                profileImage.Image = ConvertBinaryToImage(DatabaseConnection.ProfileImage);
            }
            
            labelType.Text = DatabaseConnection.Type;
            typelbl.Text = DatabaseConnection.Type;



        }
        private Image ConvertBinaryToImage(byte[] data)
        {
            using(MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            } 
        }

    }

}
