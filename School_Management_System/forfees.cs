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
    public partial class forfees : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["bse"].ConnectionString;
        public forfees()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string qr = "insert into feesrecordd values(@adid, @ftype, @famount, @fdate, @frecievedby)";
            SqlCommand cmd = new SqlCommand(qr, con);
            cmd.Parameters.AddWithValue("@adid", txtadid.Text);
            cmd.Parameters.AddWithValue("@ftype", txtftype.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@famount", txtfamount.Text);
            cmd.Parameters.AddWithValue("@fdate", txtfdate.Text);
            cmd.Parameters.AddWithValue("@frecievedby", txtfby.Text);
            con.Open();

            cmd.ExecuteReader();

            MessageBox.Show("Fees record has been inserted!");

            
            txtftype.ResetText();
            txtfamount.Clear();
            txtfdate.Clear();
            txtfby.Clear();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(cs);
            string qr1 = "select ad_name, ad_class from admission where ad_id=@ad_id";
            
            SqlCommand cmd1 = new SqlCommand(qr1, con1);
            cmd1.Parameters.AddWithValue("@ad_id",txtadid.Text);
            con1.Open();
            SqlDataReader dr1 = cmd1.ExecuteReader();

            if (dr1.Read()){

                txtadnameforsearch.Text = dr1["ad_name"].ToString();
                txtadclassforupdat.Text = dr1["ad_class"].ToString();
            }
            else
            {
                MessageBox.Show("Invalid id!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(cs);
            string qr2 = "select ad_id, ad_class from admission where ad_name=@ad_name";
            SqlCommand cmd2 = new SqlCommand(qr2, con2);
            cmd2.Parameters.AddWithValue("@ad_name", txtadnameforsearch.Text);
            con2.Open();
            SqlDataReader dr2 = cmd2.ExecuteReader();

            if (dr2.Read())
            {
                txtadid.Text = dr2["ad_id"].ToString();
                txtadclassforupdat.Text = dr2["ad_class"].ToString();
            }
            else
            {
                MessageBox.Show("Invalid username! ");
            }
        }

        private void txtadnameforsearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con3 = new SqlConnection(cs);
            string qr3 = "select ad_name from admission where ad_name=@ad_name";
            SqlCommand cmd3 = new SqlCommand(qr3, con3);
            cmd3.Parameters.AddWithValue("@ad_name", txtadnameforsearch.Text);
            con3.Open();
            SqlDataReader dr3 = cmd3.ExecuteReader();
            AutoCompleteStringCollection mycol = new AutoCompleteStringCollection();

            while (dr3.Read())
            {
                mycol.Add(dr3.GetString(0));
            }
            txtadnameforsearch.AutoCompleteCustomSource = mycol;

        }
    }
}
