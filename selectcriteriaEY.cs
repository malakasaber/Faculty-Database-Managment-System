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
    public partial class selectcriteriaEY : Form
    {
        public selectcriteriaEY()
        {
            InitializeComponent();
        }

        private void selectcriteriaEY_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbprojecttDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.dbprojecttDataSet.Student);

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentTableAdapter.FillBy2(this.dbprojecttDataSet.Student, ((int)(System.Convert.ChangeType(enrollmentYearToolStripTextBox.Text, typeof(int)))));
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
