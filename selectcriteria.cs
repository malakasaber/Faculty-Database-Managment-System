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
    public partial class selectcriteria : Form
    {
        public selectcriteria()
        {
            InitializeComponent();
        }

        private void selectcriteria_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbprojecttDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.dbprojecttDataSet.Department);
            // TODO: This line of code loads data into the 'dbprojecttDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.dbprojecttDataSet.Student);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentTableAdapter.FillBy(this.dbprojecttDataSet.Student, ((decimal)(System.Convert.ChangeType(dIDToolStripTextBox.Text, typeof(decimal)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            filterform form = new filterform();
            form.Show();
            this.Hide();
        }
    }
}
