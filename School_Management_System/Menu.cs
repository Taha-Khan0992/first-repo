using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnmenuadmission_Click(object sender, EventArgs e)
        {
            
            newadmission obj = new newadmission();
            obj.Show();
        }

        private void btnmenufees_Click(object sender, EventArgs e)
        {
            forfees obj = new forfees();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ledger obj = new ledger();
            obj.Show();
           
        }
    }
}
