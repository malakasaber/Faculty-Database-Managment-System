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
    public partial class filterform : Form
    {
        public filterform()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectcriteriaEY form = new selectcriteriaEY();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectcriteria form = new selectcriteria();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectcriteriaGPA form = new selectcriteriaGPA();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectdataform form = new selectdataform();
            form.Show();
            this.Hide();
        }
    }
}
