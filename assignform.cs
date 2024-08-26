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
    public partial class assignform : Form
    {
        public assignform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-SEV5FUM;Initial Catalog=dbprojectt;Integrated Security=True;";
            SqlCommand cmd = new SqlCommand("update Student set DID= "+ textBox2.Text+ " where StudID = " + textBox1.Text + "", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Assigned Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            featureform form = new featureform();
            form.Show();
            this.Hide();
        }

        private void assignform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbprojecttDataSet.Student' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'dbprojecttDataSet.Assigns' table. You can move, or remove it, as needed.


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.studentTableAdapter.Fill(this.dbprojecttDataSet.Student);
        }
    }
}
