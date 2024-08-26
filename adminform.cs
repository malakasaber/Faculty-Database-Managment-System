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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dbproject
{
    public partial class adminform : Form
    {
        public adminform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=DESKTOP-SEV5FUM;Initial Catalog=dbprojectt;Integrated Security=True;";
            //SqlCommand cmd = new SqlCommand("INSERT into Admin values ("+textBox1.Text+",'"+textBox2.Text +"', '"+ textBox3.Text + "',1,'"+ textBox4.Text + "')", con);
            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();
            //MessageBox.Show("Signed up successfully");
            //featureform form = new featureform();
            //form.Show();
            //this.Hide();

            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
        string.IsNullOrWhiteSpace(textBox2.Text) ||
        string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("All fields must be filled out."); return;
            }
            string connectionString = "Data Source=DESKTOP-SEV5FUM;Initial Catalog=dbprojectt;Integrated Security=True;";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"        INSERT INTO Admin (AdminID , Fname, Lname,GPA,Street)
        VALUES (@AdminID,@Fname, @Lname,1, @Street)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AdminID", textBox1.Text); command.Parameters.AddWithValue("@Fname", textBox2.Text);
                        command.Parameters.AddWithValue("@Lname", textBox3.Text); command.Parameters.AddWithValue("@Street", textBox4.Text);
                        connection.Open();
                        command.ExecuteNonQuery(); MessageBox.Show("Signed up successfully as admin.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            welcomeform form = new welcomeform();
            form.Show();
            this.Hide();
        }

    }
}
