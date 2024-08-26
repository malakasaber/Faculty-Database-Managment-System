using System;
using System.Collections;
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
    public partial class studandcourseform : Form
    {
        public studandcourseform()
        {
            InitializeComponent();
        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbprojecttDataSet);

        }

        private void studandcourseform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbprojecttDataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.dbprojecttDataSet.Course);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectdataform form = new selectdataform();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve user input (course name)
            string courseName = typeTextBox.Text.Trim();

            // SQL query to retrieve StudID from Enrolls in based on the course name
            string connectionString = "Data Source=DESKTOP-SEV5FUM;Initial Catalog=dbprojectt;Integrated Security=True;";
            string query = "SELECT [Enrolls in].StudID " +
                           "FROM [Enrolls in] " +
                           "INNER JOIN Course ON [Enrolls in].Ccode = Course.Ccode " +
                           "WHERE Course.Type = @CourseName";

            // Create and fill DataTable with data from the database
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("StudID", typeof(int)); // Define column structure

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CourseName", courseName);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable); // Fill the DataTable with data from the database
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = dataTable;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Example: Handle the cell content click event
            // This event occurs when the user clicks on a cell's content
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                MessageBox.Show($"You clicked cell value: {cell.Value}");
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Example: Handle the selection changed event
            // This event occurs when the user changes the selection in the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int studID = Convert.ToInt32(selectedRow.Cells["StudID"].Value);
                MessageBox.Show($"Selected StudID: {studID}");
            }
        }
    }
}
