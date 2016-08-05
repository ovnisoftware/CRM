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
    public partial class frmAddMisc : Form
    {
        public frmAddMisc()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtZip.Text != "")
                    int.Parse(txtZip.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a numeric zip code with no hypens");
                return;
            }

            try
            {
                if (txtLastContact.Text != "")
                    DateTime.Parse(txtLastContact.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid date for Last Contact");
                return;
            }

            try
            {
                if (txtNextContact.Text != "")
                    DateTime.Parse(txtNextContact.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid date for Next Contact");
                return;
            }

            string stmt = "INSERT INTO Misc(Lead_Category, Status, Last_Contact, Next_Contact, Company, Company_Title, Website, Title, First_Name, Last_Name, Address, City, State, Zip, Email, Mobile, Phone2, Phone3, Picture, Notes) VALUES(@Lead_Category, @Status, @Last_Contact, @Next_Contact, @Company, @Company_Title, @Website, @Title, @First_Name, @Last_Name, @Address, @City, @State, @Zip, @Email, @Mobile, @Phone2, @Phone3, @Picture, @Notes)";
            string connString = @"Data Source=RSWKLAKLSJDF234\SQLEXPRESS;Initial Catalog=Contacts;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(stmt, conn);
                cmd.Parameters.Add("@Lead_Category", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@Status", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@Last_Contact", SqlDbType.DateTime);
                cmd.Parameters.Add("@Next_Contact", SqlDbType.DateTime);
                cmd.Parameters.Add("@Company", SqlDbType.NVarChar, 500);
                cmd.Parameters.Add("@Company_Title", SqlDbType.NVarChar, 150);
                cmd.Parameters.Add("@Website", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@Title", SqlDbType.NVarChar, 150);
                cmd.Parameters.Add("@First_Name", SqlDbType.NVarChar, 500);
                cmd.Parameters.Add("@Last_Name", SqlDbType.NVarChar, 500);
                cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@City", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@State", SqlDbType.NVarChar, 200);
                cmd.Parameters.Add("@Zip", SqlDbType.Int);
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@Mobile", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@Phone2", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@Phone3", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@Picture", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@Notes", SqlDbType.Text);

                cmd.Parameters["@Lead_Category"].Value = txtCategory.Text;
                cmd.Parameters["@Status"].Value = txtStatus.Text;

                if (txtLastContact.Text == "")
                    cmd.Parameters["@Last_Contact"].Value = DBNull.Value;
                else
                    cmd.Parameters["@Last_Contact"].Value = txtLastContact.Text;
                if (txtNextContact.Text == "")
                    cmd.Parameters["@Next_Contact"].Value = DBNull.Value;
                else
                    cmd.Parameters["@Next_Contact"].Value = txtNextContact.Text;

                cmd.Parameters["@Company"].Value = txtCompany.Text;
                cmd.Parameters["@Company_Title"].Value = txtCompanyTitle.Text;
                cmd.Parameters["@Website"].Value = txtWebsite.Text;
                cmd.Parameters["@Title"].Value = txtTitle.Text;
                cmd.Parameters["@First_Name"].Value = txtFName.Text;
                cmd.Parameters["@Last_Name"].Value = txtLName.Text;
                cmd.Parameters["@Address"].Value = txtAddress.Text;
                cmd.Parameters["@City"].Value = txtCity.Text;
                cmd.Parameters["@State"].Value = txtState.Text;

                if (txtZip.Text == "")
                    cmd.Parameters["@Zip"].Value = DBNull.Value;
                else
                    cmd.Parameters["@Zip"].Value = txtZip.Text;

                cmd.Parameters["@Email"].Value = txtEmail.Text;
                cmd.Parameters["@Mobile"].Value = txtMobile.Text;
                cmd.Parameters["@Phone2"].Value = txtPhone2.Text;
                cmd.Parameters["@Phone3"].Value = txtPhone3.Text;
                cmd.Parameters["@Picture"].Value = txtNamePicture.Text;
                cmd.Parameters["@Notes"].Value = txtNotes.Text;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNotes_Click(object sender, EventArgs e)
        {
            if (chkNotes.Checked == true)
                txtNotes.AppendText(Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine);
        }
    }
}