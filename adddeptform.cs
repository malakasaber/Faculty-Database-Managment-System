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
    public partial class adddeptform : Form
    {
        public adddeptform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-SEV5FUM;Initial Catalog=dbprojectt;Integrated Security=True;";
            SqlCommand cmd = new SqlCommand("INSERT into Department values ('"+ textBox1.Text + "'," + textBox2.Text + "," + textBox3.Text + ")", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Department Added Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            featureform form = new featureform();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.departmentTableAdapter.Fill(this.dbprojecttDataSet.Department);
        }

        private void adddeptform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbprojecttDataSet.Department' table. You can move, or remove it, as needed.
            

        }

        //private void button2_Click(object sender, EventArgs e)
        //{
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=DESKTOP-SEV5FUM;Initial Catalog=dbprojectt;Integrated Security=True;";
            //SqlCommand cmd = new SqlCommand("delete from [Assigned by] where DID="+textBox2.Text+"", con);
            //SqlCommand cmd2 = new SqlCommand("delete from Course where DID="+textBox2.Text+"", con);
            //SqlCommand cmd3 = new SqlCommand("delete from Dependents where Dnum="+textBox2.Text+"", con);
            //SqlCommand cmd4 = new SqlCommand("update Student set DID=0 where DID="+textBox2.Text+"", con);
            //SqlCommand cmd5 = new SqlCommand("delete from Department where DID="+textBox2.Text+"", con);
            //con.Open();
            //cmd.ExecuteNonQuery();
            //cmd2.ExecuteNonQuery();
            //cmd3.ExecuteNonQuery();
            //cmd4.ExecuteNonQuery();
            //cmd5.ExecuteNonQuery();
            //con.Close();
            //MessageBox.Show("Department Deleted Successfully, Students assigned to this department are not assigned to a department now!");

        //}

       
    }
}
