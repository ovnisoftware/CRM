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

namespace CRM2
{
    public partial class Misc_Contacts : Form
    {
        string connString = @"Data Source=RSWKLAKLSJDF234\SQLEXPRESS;Initial Catalog=Contacts;Integrated Security=True";
        SqlDataAdapter dataAdapter;
        SqlCommandBuilder commandBuilder;
        DataTable table;

        private void GetData(string selectCommand)
        {
            try
            {
                // Create a new data adapter based on the specified query.
                dataAdapter = new SqlDataAdapter(selectCommand, connString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. These are used to
                // update the database.
                commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                miscBindingSource.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                dataGridView1.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the connectionString variable with a connection string that is valid for your system.");
            }
        }

        public Misc_Contacts()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboSearch.SelectedIndex = 0;
            dataGridView1.DataSource = miscBindingSource;
            GetData("Select * FROM Misc");
            DisableButtons();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = miscBindingSource;
            if (cboSearch.Text == "First Name")
                GetData("Select * FROM Misc WHERE First_Name LIKE " + "\'" + txtSearch.Text + "%\'");
            else if (cboSearch.Text == "Last Name")
                GetData("Select * FROM Misc WHERE Last_Name LIKE " + "\'" + txtSearch.Text + "%\'");
            else if (cboSearch.Text == "Company")
                GetData("Select * FROM Misc WHERE Company LIKE " + "\'" + txtSearch.Text + "%\'");
            else
                MessageBox.Show(txtNotes.Text);
        }

        private void DisableButtons()
        {
            dataGridView1.ReadOnly = true;
            txtCategory.ReadOnly = true;
            txtStatus.ReadOnly = true;
            txtTitle.ReadOnly = true;
            txtFName.ReadOnly = true;
            txtLName.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtCity.ReadOnly = true;
            txtState.ReadOnly = true;
            txtZip.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtLastContact.ReadOnly = true;
            txtNextContact.ReadOnly = true;
            txtCompany.ReadOnly = true;
            txtCompanyTitle.ReadOnly = true;
            txtWebsite.ReadOnly = true;
            txtMobile.ReadOnly = true;
            txtPhone2.ReadOnly = true;
            txtPhone3.ReadOnly = true;
            txtNamePicture.ReadOnly = true;
            txtNotes.ReadOnly = true;
            txtNotes.ReadOnly = true;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddMisc frm = new frmAddMisc();
            frm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;
            string value = row.Cells["ID"].Value.ToString();
            frmEditMisc frm = new frmEditMisc(Convert.ToInt32(value));
            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;
            string value = row.Cells["ID"].Value.ToString();
            string fname = row.Cells["First_Name"].Value.ToString();
            string lname = row.Cells["Last_Name"].Value.ToString();

            if (MessageBox.Show("Do you want to really want to delete " + fname + " " + lname + ", record " + value + "?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string stmt = "DELETE FROM Misc WHERE Id = '" + value + "'";
                string connString = @"Data Source=RSWKLAKLSJDF234\SQLEXPRESS;Initial Catalog=Contacts;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(stmt, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}