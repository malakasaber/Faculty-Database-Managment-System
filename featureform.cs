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
    public partial class featureform : Form
    {
        public featureform()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            enrollform form = new enrollform();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createcourseform form = new createcourseform();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adddeptform form = new adddeptform();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            assignform form = new assignform();
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loginform form = new loginform();
            form.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            updelseladmin form = new updelseladmin();
            form.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            selectdataform form = new selectdataform();
            form.Show();
            this.Hide();
        }
    }
}
