using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace last_na_talaga_toh_pramis
{
    public partial class sample : Form
    {
        public sample()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
        }
    }
}
