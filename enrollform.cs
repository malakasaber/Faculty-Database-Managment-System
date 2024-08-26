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
    public partial class enrollform : Form
    {
        public enrollform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-SEV5FUM;Initial Catalog=dbprojectt;Integrated Security=True;";
            SqlCommand cmd = new SqlCommand("INSERT into [Enrolls in] values ("+ textBox1.Text+",'"+textBox2.Text+"',4)", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student Enrolled Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            featureform form = new featureform();
            form.Show();
            this.Hide();
        }

        private void enrollform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbprojecttDataSet.Enrolls_in' table. You can move, or remove it, as needed.
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.enrolls_inTableAdapter.Fill(this.dbprojecttDataSet.Enrolls_in);
        }
    }
}
