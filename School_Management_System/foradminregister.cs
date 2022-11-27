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
    public partial class foradminregister : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["bse"].ConnectionString;
             
        public foradminregister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string qr = "insert into login values (@username ,@password)";
            SqlCommand cmd = new SqlCommand(qr, con);
            cmd.Parameters.AddWithValue("@username", txtuserregister.Text);
            cmd.Parameters.AddWithValue("@password", txtpassregister.Text);
            con.Open();
            cmd.ExecuteReader();
            MessageBox.Show("Registered!");
        }

        private void txtuserregister_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
