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
    public partial class deleteform : Form
    {
        public deleteform()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            welcomeform form = new welcomeform();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-SEV5FUM;Initial Catalog=dbprojectt;Integrated Security=True;";
            SqlCommand cmd = new SqlCommand("update [Assigned by] set AdminID=1111 where AdminID="+textBox1.Text+"", con);
            SqlCommand cmd2 = new SqlCommand("update Assigns set AdminID=1111 where AdminID="+textBox1.Text+"", con);
            SqlCommand cmd3 = new SqlCommand("update Creates set AdminID=1111 where AdminID="+textBox1.Text+"", con);
            SqlCommand cmd4 = new SqlCommand("update Department set AdminID=1111 where AdminID="+textBox1.Text+"", con);
            SqlCommand cmd5 = new SqlCommand("update [Enrolled by] set AdminID=1111 where AdminID="+textBox1.Text+"", con);
            SqlCommand cmd6 = new SqlCommand("update Enrolls set AdminID=1111 where AdminID="+textBox1.Text+"", con);
            SqlCommand cmd7 = new SqlCommand("update Phone_admin set AdminID=1111 where AdminID="+textBox1.Text+"", con);
            SqlCommand cmd8 = new SqlCommand("delete from Admin where AdminID="+textBox1.Text+"", con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            cmd4.ExecuteNonQuery();
            cmd5.ExecuteNonQuery();
            cmd6.ExecuteNonQuery();
            cmd7.ExecuteNonQuery();
            cmd8.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Admin Account deleted Successfully");
        }

        private void deleteform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbprojecttDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.dbprojecttDataSet.Staff);
            // TODO: This line of code loads data into the 'dbprojecttDataSet.Admin' table. You can move, or remove it, as needed.


        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.adminTableAdapter.Fill(this.dbprojecttDataSet.Admin);
            this.staffTableAdapter.Fill(this.dbprojecttDataSet.Staff);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-SEV5FUM;Initial Catalog=dbprojectt;Integrated Security=True;";
            SqlCommand cmd = new SqlCommand("update Assigns set StudID=1111 where StudID="+textBox1.Text+"", con);
            SqlCommand cmd2 = new SqlCommand("update Enrolls set StudID=1111 where StudID="+textBox1.Text+"", con);
            SqlCommand cmd3 = new SqlCommand("delete from [Enrolls in] where StudID="+textBox1.Text+"", con);
            SqlCommand cmd4 = new SqlCommand("delete from Phone_stud where StudID="+textBox1.Text+"", con);
            SqlCommand cmd5 = new SqlCommand("delete from Student where StudID="+textBox1.Text+"", con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            cmd4.ExecuteNonQuery();
            cmd5.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Account deleted Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-SEV5FUM;Initial Catalog=dbprojectt;Integrated Security=True;";
            SqlCommand cmd = new SqlCommand("update Dependents set StaffID=1111 where StaffID="+textBox1.Text+"", con);
            SqlCommand cmd2 = new SqlCommand("delete from Staff where StaffID="+textBox1.Text+"", con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Staff Account deleted Successfully");
        }
    }
}
