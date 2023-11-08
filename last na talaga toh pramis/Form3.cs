using last_na_talaga_toh_pramis.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;

namespace last_na_talaga_toh_pramis
{
    public partial class Form3 : Form
    {
     
        
        public Form3()
        {
            InitializeComponent();
           
        }

        public void total_price()
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);

            }
            lbl_totalAmount.Text = "PHP: " + sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            aub3 frm = new aub3();
             frm.Show();

        }

        private void btn_espresso_Click(object sender, EventArgs e)
        {
            //int a = 100;
            //decimal b = numb.Value;

            //decimal price;
            //price = a*b;
            //dataGridView1.Rows.Add(b, "Espresso", price);
            //total_price();

            var index = this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows[index].Cells[0].Value = "1";
            this.dataGridView1.Rows[index].Cells[1].Value = "Espresso";
            this.dataGridView1.Rows[index].Cells[2].Value = "100";

            total_price();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        


        private void clear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            lbl_totalAmount.Text = string.Empty;
        }

        private void btn_doppio_Click(object sender, EventArgs e)
        {
            int a = 120;
            

            decimal price;
            price = a;
            dataGridView1.Rows.Add( "Doppio", price);
            total_price();
        }

        private void btn_Americano_Click(object sender, EventArgs e)
        {
            int a = 165;
            

            decimal price;
            price = a;
            dataGridView1.Rows.Add( "Americo", price);
            total_price();
        }

        private void btn_esMacchiato_Click(object sender, EventArgs e)
        {
            int a = 190;
            

            decimal price;
            price = a;
            dataGridView1.Rows.Add( "esMacchiato", price);
            total_price();
        }

        private void btn_latte_Click(object sender, EventArgs e)
        {
            int a = 140;
            

            decimal price;
            price = a;
            dataGridView1.Rows.Add( "Latte", price);
            total_price();
        }

        private void btn_cuppoccino_Click(object sender, EventArgs e)
        {
            int a = 170;
            

            decimal price;
            price = a;
            dataGridView1.Rows.Add( "Cuppoccino", price);
            total_price();
        }

        private void btn_irish_Click(object sender, EventArgs e)
        {
            int a = 185;
            

            decimal price;
            price = a;
            dataGridView1.Rows.Add( "Irish", price);
            total_price();
        }

        private void btn_mocha_Click(object sender, EventArgs e)
        {
            int a = 210;
            

            decimal price;
            price = a;
            dataGridView1.Rows.Add( "Mocha", price);
            total_price();
        }

        private void btn_caramel_Click(object sender, EventArgs e)
        {
            int a = 200;
            

            decimal price;
            price = a;
            dataGridView1.Rows.Add("Caramel", price);
            total_price();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            int a = 250;
           

            decimal price;
            price = a;
            dataGridView1.Rows.Add( "Bananacake", price);
            total_price();
        }

        private void lblback_Click(object sender, EventArgs e)
        {
            aub3 frm1 = new aub3();
            this.Close();
            frm1.Show();
        }

        private void clear_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            lbl_totalAmount.Text = string.Empty;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

       

        private void lbl_totalAmount_Click(object sender, EventArgs e)
        {

        }

        private void lbl_total_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }
            lbl_totalAmount.Text = sum.ToString();
        }

        private void panelmilktea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_coffee_Click_1(object sender, EventArgs e)
        {
            panel_order.Show();
            panpastries.Hide();
            panelmilktea.Hide();

        }

        private void btnmilktea_Click_1(object sender, EventArgs e)
        {
            panelmilktea.Show();
            panel_order.Hide();
            panpastries.Hide();
        }

        private void btn_patries_Click_1(object sender, EventArgs e)
        {
            panpastries.Show();
            panel_order.Hide();
            panelmilktea.Hide();
        }

        private void picBagel_Click_1(object sender, EventArgs e)
        {
            count fm = new count();
            fm.Show();
        }

        private void lbl_totalAmount_Click_1(object sender, EventArgs e)
        {

        }

        private void picwinter_Click(object sender, EventArgs e)
        {
            lbl_totalAmount.Text = "100";
        }

        private void pcibrownie_Click(object sender, EventArgs e)
        {
            lbl_totalAmount.Text = "100";
        }
    }
}
