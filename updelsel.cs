using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbproject
{
    public partial class updelsel : Form
    {
        public updelsel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteform form = new deleteform();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateform form = new updateform();
            form.Show();
            this.Hide();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            loginform form = new loginform();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Attendance taken SUCCESSFULLY, GOOD JOB :) ");
        }
    }
}
