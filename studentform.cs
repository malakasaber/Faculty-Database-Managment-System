using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace dbproject
{
    public partial class studentform : Form
    {
        public studentform()
        {
            InitializeComponent();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=DESKTOP-SEV5FUM;Initial Catalog=dbprojectt;Integrated Security=True;";
            //SqlCommand cmd = new SqlCommand("Insert into Student values("+textBox1.Text+","+textBox2.Text+",'"+textBox3.Text+"','"+textBox4.Text+"',"+textBox9.Text+",'"+ textBox8.Text + "','"+textBox7.Text+"','"+textBox6.Text+"','"+ textBox5.Text + "',"+textBox10.Text+")", con);
            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();
            //MessageBox.Show("Signed up successfully");

            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
       string.IsNullOrWhiteSpace(textBox2.Text) ||
       string.IsNullOrWhiteSpace(textBox3.Text) ||
       string.IsNullOrWhiteSpace(textBox4.Text) ||
       string.IsNullOrWhiteSpace(textBox5.Text) ||
       string.IsNullOrWhiteSpace(textBox6.Text) ||
       string.IsNullOrWhiteSpace(textBox7.Text) ||
       string.IsNullOrWhiteSpace(textBox8.Text) ||
       string.IsNullOrWhiteSpace(textBox9.Text) ||
       string.IsNullOrWhiteSpace(textBox10.Text))
            {
                MessageBox.Show("All fields must be filled out.");
                return;
            }

            int did;
            if (!int.TryParse(textBox1.Text, out did) || did == 0 ||
                !decimal.TryParse(textBox9.Text, out decimal gpa) ||
                !int.TryParse(textBox10.Text, out int enrollmentYear))
            {
                MessageBox.Show("Please enter valid numeric values for DID, GPA, and Enrollment Year.");
                return;
            }

            string connectionString = "Data Source=DESKTOP-SEV5FUM;Initial Catalog=dbprojectt;Integrated Security=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                INSERT INTO Student (StudID, DID, Fname, Lname, GPA, Email, Street, City, Gender, EnrollmentYear)
                VALUES (@StudID, @DID, @Fname, @Lname, @GPA, @Email, @Street, @City, @Gender, @EnrollmentYear)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudID", textBox1.Text);

                        command.Parameters.AddWithValue("@DID", textBox2.Text);
                        command.Parameters.AddWithValue("@Fname", textBox3.Text);
                        command.Parameters.AddWithValue("@Lname", textBox4.Text);
                        command.Parameters.AddWithValue("@GPA", gpa);
                        command.Parameters.AddWithValue("@Email", textBox8.Text);
                        command.Parameters.AddWithValue("@Street", textBox7.Text);
                        command.Parameters.AddWithValue("@City", textBox6.Text);
                        command.Parameters.AddWithValue("@Gender", textBox5.Text);
                        command.Parameters.AddWithValue("@EnrollmentYear", enrollmentYear);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Signed up successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        

    }
                private void button3_Click(object sender, EventArgs e)
        {
            welcomeform form = new welcomeform();
            form.Show();
            this.Hide();
        }
    }
}
