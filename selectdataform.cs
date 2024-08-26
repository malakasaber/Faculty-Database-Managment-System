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
    public partial class selectdataform : Form
    {
        public selectdataform()
        {
            InitializeComponent();
        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbprojecttDataSet);

        }

        private void selectdataform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbprojecttDataSet.Student' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'dbprojecttDataSet.Department' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'dbprojecttDataSet.Course' table. You can move, or remove it, as needed.
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-SEV5FUM;Initial Catalog=dbprojectt;Integrated Security=True;";
            SqlCommand cmd = new SqlCommand("select count(*) from [Enrolls in] where Ccode = "+ccodeTextBox.Text+"", con);
            try
            {
                con.Open();
                int studentCount = (int)cmd.ExecuteScalar();

                // Show the count in a MessageBox
                MessageBox.Show($"Total number of students in the Course: {studentCount}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            con.Close();
            selectdataform form = new selectdataform();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-SEV5FUM;Initial Catalog=dbprojectt;Integrated Security=True;";
            SqlCommand cmd = new SqlCommand("select count(*) from Student where DID="+ dIDTextBox.Text + "", con);
            try
            {
                con.Open();
                int studentCount = (int)cmd.ExecuteScalar();

                // Show the count in a MessageBox
                MessageBox.Show($"Total number of students in the department: {studentCount}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            con.Close();
            selectdataform form = new selectdataform();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.studentTableAdapter.Fill(this.dbprojecttDataSet.Student);
            this.departmentTableAdapter.Fill(this.dbprojecttDataSet.Department);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.courseTableAdapter.Fill(this.dbprojecttDataSet.Course);
            this.departmentTableAdapter.Fill(this.dbprojecttDataSet.Department);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-SEV5FUM;Initial Catalog=dbprojectt;Integrated Security=True;";
            SqlCommand cmd = new SqlCommand("select * from Student where StudID="+ studIDTextBox.Text + "", con);
            con.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    
                    string studentID = reader["StudID"].ToString();
                    string studentDID = reader["DID"].ToString();
                    string studentFName = reader["Fname"].ToString();
                    string studentLName = reader["Lname"].ToString();
                    string studentGPA = reader["GPA"].ToString();
                    string studentEmail = reader["Email"].ToString();
                    string studentStreet = reader["Street"].ToString();
                    string studentCity = reader["City"].ToString();
                    string studentGender = reader["Gender"].ToString();
                    string studentEY = reader["EnrollmentYear"].ToString();

                    
                    MessageBox.Show($"ID: {studentID}\nDID: {studentDID}\nFirstName: {studentFName}\nLastName: {studentLName}\nGPA: {studentGPA}\nEmail: {studentEmail}\nStreet: {studentStreet}\nCity: {studentCity}\nGender: {studentGender}\nEnrollment Year: {studentEY}", "Student Data");
                }
                else
                {
                    MessageBox.Show("No student found with the given ID.");
                }
            }
            cmd.ExecuteNonQuery();
            con.Close();
            selectdataform form = new selectdataform();
            form.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            featureform form = new featureform();
            form.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            studandcourseform form = new studandcourseform();
            form.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            filterform form = new filterform();
            form.Show();
            this.Hide();
        }
    }
}
