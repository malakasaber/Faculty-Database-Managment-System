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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dbproject
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-SEV5FUM;Initial Catalog=dbprojectt;Integrated Security=True;";
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Admin WHERE AdminID ="+textBox1.Text+" ", con);
            try
            {
                con.Open();
                int adminCount = Convert.ToInt32(cmd.ExecuteScalar());

                if (adminCount > 0)
                {
                    // User is authorized, proceed to features form
                    featureform form = new featureform();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    // User is not authorized, show message
                    MessageBox.Show("You are not authorized.", "Unauthorized Access", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-SEV5FUM;Initial Catalog=dbprojectt;Integrated Security=True;";
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Student WHERE StudID =" + textBox1.Text + " ", con);
            try
            {
                con.Open();
                int Count = Convert.ToInt32(cmd.ExecuteScalar());

                if (Count > 0)
                {
                    // User is authorized, proceed to features form
                    MessageBox.Show("Logged In successfully");
                    updelsel form = new updelsel();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    // User is not authorized, show message
                    MessageBox.Show("You are not authorized.", "Unauthorized Access", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-SEV5FUM;Initial Catalog=dbprojectt;Integrated Security=True;";
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Staff WHERE StaffID =" + textBox1.Text + " ", con);
            try
            {
                con.Open();
                int Count = Convert.ToInt32(cmd.ExecuteScalar());

                if (Count > 0)
                {
                    // User is authorized, proceed to features form
                    MessageBox.Show("Logged In successfully");
                    updelsel form = new updelsel();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    // User is not authorized, show message
                    MessageBox.Show("You are not authorized.", "Unauthorized Access", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            welcomeform form = new welcomeform();
            form.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
