using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hotel
{
    public partial class EmployeeRegistration : Form
    {
        int Empty=1, Id = 1000;
        string path;
        public EmployeeRegistration()
        {
            InitializeComponent();
        }



        private void registerBtn_Click(object sender, EventArgs e)
        {
            EmptyCheck();
            if (Empty == 1)
            {
                AddEmpOperation();
            }
            else
            {
                Empty = 1;
            }
        }

       
        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jepg; *.gif; *.png;)|*.jpg; *.jpeg; *.gif; *.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                path = open.FileName.ToString();
                pictureBox.ImageLocation = path;
            }
        }

        private void AddEmpOperation()
        {
            string query = "INSERT INTO [Employee] (ID,Name,Email,Password,Phone,Address,DOB,BG,JoiningDate,Salary,EmpType,Image) VALUES('" + Id + "','" + name.Text + "','" + email.Text + "','" + pass.Text + "','" + phone.Text + "','" + address.Text + "','" + dob.Value.ToString() + "','" + bg.SelectedItem.ToString() + "','" + joindate.Value.ToString() + "','" + salary.Text + "','" + usertype.SelectedItem.ToString() + "',@img) ";
            int result = DatabaseConnection.ExecuteQuery5(query, path);
            DialogBox db = new DialogBox();
            if (result > 0)
            {
                db.setMessage("Epmloyee Succesfully Registered");
                db.Show();
            }
            else
            {
                db.setMessage("Employee Registered Failed!");
                db.ChangeAnimationIcon(2);
                db.Show();
            }
        }

        private void EmptyCheck()
        {
            if (name.Text == ""|| email.Text==""|| phone.Text==""|| pass.Text==""|| address.Text==""||salary.Text==""||path==null|| dob.Value.ToString()==null||joindate.Value.ToString()==null||bg.SelectedItem.ToString()==null||usertype.SelectedItem.ToString()==null)
            {
                Empty = 0;
                DialogBox db = new DialogBox();
                db.setMessage("Please Fillup All Information !");
                db.ChangeAnimationIcon(2);
                db.Show();
            }
            

        }


    }
}

/*
private void AddroomOperation()
{
    try
    {
        byte[] img = null;
        FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
        BinaryReader br = new BinaryReader(fs);
        img = br.ReadBytes((int)fs.Length);
    }
    catch (Exception e)
    {
        MessageBox.Show(e.Message);
    }
    string query = "INSERT INTO [Employee](ID,Name,Email,Password,Phone,Address,DOB,BG,JoiningDate,Salary,EmpType,Image) VALUES('" + Id + "','" + name.Text + "','" + email.Text + "','" + pass.Text + "','" + phone.Text + "','" + address.Text + "','" + dob.Value.ToString() + "','" + bg.SelectedItem.ToString() + "','" + joindate.Value.ToString() + "','" + salary.Text + "','" + usertype.SelectedItem.ToString() + "',@img)";
    int result = DatabaseConnection.ExecuteQuery(query);
    DialogBox db = new DialogBox();


    if (result > 0)
    {
        db.setMessage("Epmloyee Succesfully Registered");
        db.Show();
    }
    else
    {
        db.setMessage("Employee Registered Failed!");
        db.ChangeAnimationIcon(2);
        db.Show();
    }
}
*/