using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;
using System.Drawing;
using System.Windows;

namespace Hotel
{
    class DatabaseConnection
    {
        private static string _connectionString =
            @"Data Source=DESKTOP-F85GVB8;Initial Catalog=BangalHotel;Integrated Security=True";
        public static DataTable LoadData(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection(_connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];
                con.Close();
                return dt;

            }
            catch (Exception)
            {
                return new DataTable();
            }
        }

        public static int ExecuteQuery(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection(_connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                int result = cmd.ExecuteNonQuery();
                con.Close();
                return result;

            }
            catch (Exception)
            {
                return -1;
            }
        }
        public static int ExecuteQuery1(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection(_connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                int row = cmd.ExecuteNonQuery();
                con.Close();
                return row;
            }
            catch (Exception)
            {
                return -1;
            }

        }


        public static DataTable ExecuteQuery2(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection(_connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                con.Close();
                return dt;

            }
            catch (Exception)
            {
                return new DataTable();
            }
        }
        public static int Id { get; set; }
        public static string Name { get; set; }
        public static string Email { get; set; }
        public static string Phone { get; set; }
        public static string Address { get; set; }
        public static string DOB { get; set; }
        public static string BG { get; set; }
        public static string JoinDate { get; set; }
        public static string Type { get; set; }
        public static byte[] ProfileImage{ get; set; }

        public static void ExecuteQuery4(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection(_connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Id = (int)reader["ID"];
                    Name = reader["Name"].ToString();
                    Email = reader["Email"].ToString();
                    Phone = reader["Phone"].ToString();
                    Address = reader["Address"].ToString();
                    DOB = reader["DOB"].ToString();
                    BG = reader["BG"].ToString();
                    JoinDate = reader["JoiningDate"].ToString();
                    Type = reader["EmpType"].ToString();
                    ProfileImage = (byte[])reader["Image"];
                }
                con.Close();
            }
            catch (Exception)
            {
            }

        }

        public static int ExecuteQuery5(string query, string filepath)
        {
            
            try
            {
                byte[] image = null;
                FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                image = br.ReadBytes((int)fs.Length);

                SqlConnection con = new SqlConnection(_connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@img", image));
                int result = cmd.ExecuteNonQuery();
                con.Close();
                return result;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }
        }
        public static string Price { get; set; }
        public static string DiscountAmt { get; set; }
        
        public static void ExecuteQuery6(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection(_connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DiscountAmt = reader["DiscountAmt"].ToString();
                    Price = reader["Price"].ToString();
                    
                }
                con.Close();
            }
            catch (Exception)
            {
            }
        }



        public static string BookedRoom { get; set; }

        public static void ExecuteQuery7(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection(_connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    BookedRoom = reader["Available"].ToString();

                }
                con.Close();
            }
            catch (Exception)
            {
            }
        }
        public static string isCheckin { get; set; }
        
        public static void ExecuteQuery8(string query)
        {
            try
            {
                isCheckin = "";
                SqlConnection con = new SqlConnection(_connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    isCheckin = reader["CheckInDate"].ToString();

                }
                con.Close();
            }
            catch (Exception)
            {
                
            }
        }

        public static string isCheckout { get; set; }
        public static string Room_No { get; set; }
        public static void ExecuteQuery9(string query)
        {
            try
            {
                isCheckout = "";
                SqlConnection con = new SqlConnection(_connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    isCheckout = reader["CheckOutDate"].ToString();
                    Room_No = reader["BookedRoom"].ToString();

                }
                con.Close();
            }
            catch (Exception)
            {
                isCheckout = "";
            }
        }

        public static string userType { get; set; }

        public static void ExecuteQuery10(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection(_connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    userType = reader["EmpType"].ToString();

                }
                con.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
