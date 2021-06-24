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

namespace Hotel
{
    public partial class DialogBox : Form
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


        private Form newForm;

        string msg;
        public void setMessage(string message)
        {
            this.msg = message;
        }
        public DialogBox()
        {
            InitializeComponent();
            iconAnimation.Visible = false;
            messageBox.Visible = false;
            
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            
        }
        private void DialogBox_Load(object sender, EventArgs e)
        {
            messageBox.Text = msg;
        }

        private void xbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            iconAnimation.Visible = true;
            messageBox.Visible = true;
        }

        public void ChangeAnimationIcon(int flag)
        {
            if (flag == 1)
            {
                iconAnimation.ForeColor = Color.OrangeRed;
                iconAnimation.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
                messageBox.ForeColor = Color.OrangeRed;
            }
            else if (flag == 2)
            {
                iconAnimation.ForeColor = Color.Red;
                iconAnimation.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
                messageBox.ForeColor = Color.Red;
            }

        }

        private void iconExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void iconExitBtn_MouseHover(object sender, EventArgs e)
        {
            iconExitBtn.IconColor = Color.Red;
        }

        private void iconExitBtn_MouseLeave(object sender, EventArgs e)
        {
            iconExitBtn.IconColor = Color.DarkGray;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (newForm == null)
            {
                this.Hide();
            }
            else if (newForm != null)
            {
                newForm.Show();
                this.Hide();
            }
        }

        public void okButtonOperation(Form showForm)
        {
            newForm = showForm;
        }
    }
}
