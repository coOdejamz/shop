using Guna.UI2.WinForms;
using last_na_talaga_toh_pramis.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace last_na_talaga_toh_pramis
{
  
    public partial class admin : Form
    {
        private bool isCollapsed;

        private const string ConnectionString = "Data Source=JAMZ;Initial Catalog=aubrey;Integrated Security=True";
        public admin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=JAMZ;Initial Catalog=aubrey;Integrated Security=True");


        private void admin_Load(object sender, EventArgs e)
        {
            BindData();
            LoadPendingRegistrations();

        }



        private void LoadPendingRegistrations()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string selectPendingUsersQuery = @"
SELECT U.UserID, U.Username, U.Email
FROM aubreyy AS U
LEFT JOIN Adminn AS A ON A.UserID = U.UserID
WHERE U.isApprove = 0 OR U.UserID IS NULL";
                SqlDataAdapter adapter = new SqlDataAdapter(selectPendingUsersQuery, connection);
                DataTable pendingUsersTable = new DataTable();
                adapter.Fill(pendingUsersTable);
                dataGridViewPendingRegistrations.DataSource = pendingUsersTable;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aub3 frm = new aub3();
            this.Hide();
            frm.Show();

        }

        private void dataGridViewPendingRegistrations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void staff_Click(object sender, EventArgs e)
        {
            dataGridViewPendingRegistrations.Show();
            panelmenu.Hide();
            panel1.Hide();
        }

      

   

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewPendingRegistrations.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewPendingRegistrations.SelectedRows[0].Index;
                int selectedUserID = Convert.ToInt32(dataGridViewPendingRegistrations.SelectedRows[0].Cells["UserID"].Value);

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string updateApprovalQuery = "UPDATE [aubreyy] SET isApprove = 1 WHERE UserID = @UserID";
                    SqlCommand updateApprovalCommand = new SqlCommand(updateApprovalQuery, connection);
                    updateApprovalCommand.Parameters.AddWithValue("@UserID", selectedUserID);
                    updateApprovalCommand.ExecuteNonQuery();
                }
                dataGridViewPendingRegistrations.Rows.RemoveAt(dataGridViewPendingRegistrations.SelectedRows[0].Index);


                MessageBox.Show("Account Successfuly Approved.");
                // Refresh the pending registrations list
                LoadPendingRegistrations();
            }

            else
            {

                MessageBox.Show("Please select a user to Approve.");

            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            if (dataGridViewPendingRegistrations.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewPendingRegistrations.SelectedRows[0].Index;
                int selectedUserID = Convert.ToInt32(dataGridViewPendingRegistrations.SelectedRows[0].Cells["UserID"].Value);

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string updateApprovalQuery = "UPDATE [aubreyy] SET isApprove = 1 WHERE UserID = @UserID";
                    SqlCommand updateApprovalCommand = new SqlCommand(updateApprovalQuery, connection);
                    updateApprovalCommand.Parameters.AddWithValue("@UserID", selectedUserID);
                    updateApprovalCommand.ExecuteNonQuery();
                }
                dataGridViewPendingRegistrations.Rows.RemoveAt(dataGridViewPendingRegistrations.SelectedRows[0].Index);


                MessageBox.Show("Account Successfuly Approved.");
                // Refresh the pending registrations list
                LoadPendingRegistrations();
            }

            else
            {

                MessageBox.Show("Please select a user to Approve.");

            }

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

       

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

     

       

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            panel1.Show();
            panelmenu.Hide();
            dataGridViewPendingRegistrations.Hide();
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            panelmenu.Show();
            dataGridViewPendingRegistrations.Hide();
            panel1.Hide();
        }

       
        void BindData()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM edit", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)

                dataGridView1.CurrentRow.Selected = true;
            txtItemname.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
            Category.Text = dataGridView1.Rows[e.RowIndex].Cells["Category"].FormattedValue.ToString();
            txtprice.Text = dataGridView1.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                guna2Button1.Image = Resources.arrowup1;
                guna2Panel1.Height += 10;
                if (guna2Panel1.Size == guna2Panel1.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                guna2Button1.Image = Resources.arrowndowm1;
                guna2Panel1.Height -= 10;
                if (guna2Panel1.Size == guna2Panel1.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=JAMZ;Initial Catalog=aubrey;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO edit(Name,  Price, Category ) VALUES (@Name, @Price,  @Category)", con);


            cmd.Parameters.AddWithValue("@Name", (txtItemname.Text));
            cmd.Parameters.AddWithValue("@Price", (txtprice.Text));
            cmd.Parameters.AddWithValue("@Category", (Category.Text));
            cmd.ExecuteNonQuery();


            txtItemname.Text = "";
            txtprice.Text = "";
            Category.Text = "";




            MessageBox.Show("Successfully Added");
            con.Close();
            BindData();

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=JAMZ;Initial Catalog=aubrey;Integrated Security=True");
            con.Open();


            SqlCommand cmd = new SqlCommand("UPDATE edit SET Name=@Name, Price=@Price, Category=@Category", con);

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Name", (txtItemname.Text));
            cmd.Parameters.AddWithValue("@Price", (txtprice.Text));
            cmd.Parameters.AddWithValue("@Category", (Category.Text));
            cmd.ExecuteNonQuery();


            txtItemname.Text = "";
            txtprice.Text = "";
            Category.Text = "";



            MessageBox.Show("Successfully updated");
            con.Close();
            BindData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewPendingRegistrations.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewPendingRegistrations.SelectedRows[0].Index;
                int selectedUserID = Convert.ToInt32(dataGridViewPendingRegistrations.SelectedRows[0].Cells["UserID"].Value);

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string updateApprovalQuery = "UPDATE [aubreyy] SET isApprove = 1 WHERE UserID = @UserID";
                    SqlCommand updateApprovalCommand = new SqlCommand(updateApprovalQuery, connection);
                    updateApprovalCommand.Parameters.AddWithValue("@UserID", selectedUserID);
                    updateApprovalCommand.ExecuteNonQuery();
                }
                dataGridViewPendingRegistrations.Rows.RemoveAt(dataGridViewPendingRegistrations.SelectedRows[0].Index);


                MessageBox.Show("Account Successfuly Approved.");
                // Refresh the pending registrations list
                LoadPendingRegistrations();
            }

            else
            {

                MessageBox.Show("Please select a user to Approve.");

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewPendingRegistrations.SelectedRows.Count > 0)
            {
                int selectedUserID = Convert.ToInt32(dataGridViewPendingRegistrations.SelectedRows[0].Cells["UserID"].Value);

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Delete the user record from the Users table
                    string deleteQuery = "DELETE FROM [aubreyy] WHERE UserID = @UserID";
                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                    deleteCommand.Parameters.AddWithValue("@UserID", selectedUserID);
                    deleteCommand.ExecuteNonQuery();

                    // Delete the associated record from the AdminApproval table
                    string deleteAdminApprovalQuery = "DELETE FROM Adminn WHERE UserID = @UserID";
                    SqlCommand deleteAdminApprovalCommand = new SqlCommand(deleteAdminApprovalQuery, connection);
                    deleteAdminApprovalCommand.Parameters.AddWithValue("@UserID", selectedUserID);
                    deleteAdminApprovalCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Account Successfully Rejected.");

                LoadPendingRegistrations();
            }
            else
            {

                MessageBox.Show("Please select a user to Reject.");

            }

        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            aub3 frm = new aub3();
            this.Hide();
            frm.Show();
        }

        private void lblback_Click(object sender, EventArgs e)
        {
            aub3 frm1 = new aub3();
            this.Close();
            frm1.Show();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            aub3 frm = new aub3();
            this.Hide();
            frm.Show();
        }
    }
}
       

