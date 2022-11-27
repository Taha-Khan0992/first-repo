using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace School_Management_System
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["bse"].ConnectionString;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


          


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void txtuserlogin_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Type your username here! ", txtuserlogin);
            
        }

        private void txtpasslogin_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Type your password here! ", txtpasslogin);
        }

        private void txtuserlogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string qr = "select * from login where username=@username and password=@password";
            SqlCommand cmd = new SqlCommand(qr, con);
            cmd.Parameters.AddWithValue("@username", txtuser.Text);
            cmd.Parameters.AddWithValue("@password", txtpass.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                MessageBox.Show("Login Successfully!");
                this.Hide();
                Menu obj = new Menu();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Login failed!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foradminregister obj = new foradminregister();
            obj.Show();
        }
    }
}
