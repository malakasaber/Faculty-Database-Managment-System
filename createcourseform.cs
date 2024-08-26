﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbproject
{
    public partial class createcourseform : Form
    {
        public createcourseform()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-SEV5FUM;Initial Catalog=dbprojectt;Integrated Security=True;";
            SqlCommand cmd = new SqlCommand("INSERT into Course values ('"+ textBox1.Text + "',"+ textBox2.Text + ",'"+ textBox3.Text + "',"+ textBox4.Text + ")", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Course Added Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            featureform form = new featureform();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.courseTableAdapter.Fill(this.dbprojecttDataSet.Course);
        }

        private void createcourseform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbprojecttDataSet.Course' table. You can move, or remove it, as needed.
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-SEV5FUM;Initial Catalog=dbprojectt;Integrated Security=True;";
            SqlCommand cmd = new SqlCommand("delete from Creates where Ccode='"+textBox1.Text+"'", con);
            SqlCommand cmd2 = new SqlCommand("delete from [Enrolled by] where Ccode='"+textBox1.Text+"'", con);
            SqlCommand cmd3 = new SqlCommand("delete from [Enrolls in] where Ccode='"+textBox1.Text+"'", con);
            SqlCommand cmd4 = new SqlCommand("delete from Requires where Ccode='"+textBox1.Text+"'", con);
            SqlCommand cmd5 = new SqlCommand("delete from Teaches where Ccode='"+textBox1.Text+"'", con);
            SqlCommand cmd6 = new SqlCommand("delete from Course where Ccode='"+textBox1.Text+"'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            cmd4.ExecuteNonQuery();
            cmd5.ExecuteNonQuery();
            cmd6.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Course Deleted Successfully");
        }
    }
}
