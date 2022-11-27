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
    public partial class newadmission : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["bse"].ConnectionString;

        public newadmission()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string qr = "insert into admission values(@ad_name, @ad_fname, @ad_address, @ad_class, @ad_contact, @ad_date, @ad_afee, @ad_mfee, @ad_tfee)";
            SqlCommand cmd = new SqlCommand(qr, con);
            cmd.Parameters.AddWithValue("@ad_name", txtadname.Text);
            cmd.Parameters.AddWithValue("@ad_fname", txtadfname.Text);
            cmd.Parameters.AddWithValue("@ad_address", txtadaddress.Text);
            cmd.Parameters.AddWithValue("@ad_class", comboBox1.Text);
            cmd.Parameters.AddWithValue("@ad_contact", txtadcontact.Text);
            cmd.Parameters.AddWithValue("@ad_date", txtaddate.Text);
            cmd.Parameters.AddWithValue("@ad_afee", txtadafee.Text);
            cmd.Parameters.AddWithValue("@ad_mfee", txtadmfee.Text);
            cmd.Parameters.AddWithValue("@ad_tfee", txtadtfee.Text);
            con.Open();
            cmd.ExecuteReader();

            MessageBox.Show("Admission has beeen registered!");
        }   
    }
}
