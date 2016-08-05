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
    public partial class frmEditMisc : Form
    {
        public int id;

        public frmEditMisc(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void frmEditMisc_Load(object sender, EventArgs e)
        {
            string stmt = "SELECT * FROM Misc WHERE ID = '" + id + "'"; 
            string connString = @"Data Source=RSWKLAKLSJDF234\SQLEXPRESS;Initial Catalog=Contacts;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(stmt, conn);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    txtCategory.Text = rdr[1].ToString();
                    txtStatus.Text = rdr[2].ToString();
                    txtLastContact.Text = rdr[3].ToString();
                    txtNextContact.Text = rdr[4].ToString();
                    txtCompany.Text = rdr[5].ToString();
                    txtCompanyTitle.Text = rdr[6].ToString();
                    txtWebsite.Text = rdr[7].ToString();
                    txtTitle.Text = rdr[8].ToString();
                    txtFName.Text = rdr[9].ToString();
                    txtLName.Text = rdr[10].ToString();
                    txtAddress.Text = rdr[11].ToString();
                    txtCity.Text = rdr[12].ToString();
                    txtState.Text = rdr[13].ToString();
                    txtZip.Text = rdr[14].ToString();
                    txtEmail.Text = rdr[15].ToString();
                    txtMobile.Text = rdr[16].ToString();
                    txtPhone2.Text = rdr[17].ToString();
                    txtPhone3.Text = rdr[18].ToString();
                    txtNamePicture.Text = rdr[19].ToString();
                    txtNotes.Text = rdr[20].ToString();
                }

                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            this.Text = txtFName.Text + " " + txtLName.Text;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

            string stmt = "UPDATE Misc SET Lead_Category = @Lead_Category, Status = @Status, Last_Contact = @Last_Contact, Next_Contact = @Next_Contact, Company = @Company, Company_Title = @Company_Title, Website = @Website, Title = @Title, First_Name = @First_Name, Last_Name = @Last_Name, Address = @Address, City = @City, State = @State, Zip = @Zip, Email = @Email, Mobile = @Mobile, Phone2 = @Phone2, Phone3 = @Phone3, Picture = @Picture, Notes = @Notes WHERE ID = @ID"; //works
            string connString = @"Data Source=RSWKLAKLSJDF234\SQLEXPRESS;Initial Catalog=Contacts;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(stmt, conn);

                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters.Add("@Lead_Category", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@Status", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@Last_Contact", SqlDbType.DateTime);
                cmd.Parameters.Add("@Next_Contact", SqlDbType.DateTime);
                cmd.Parameters.Add("@Company", SqlDbType.NVarChar, 500);
                cmd.Parameters.Add("@Company_Title", SqlDbType.NVarChar, 150);
                cmd.Parameters.Add("@Website", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@Title", SqlDbType.NVarChar, 50);
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

                cmd.Parameters["@ID"].Value = id;
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

        private void txtNotes_Click(object sender, EventArgs e)
        {
            if (chkNotes.Checked == true)
                txtNotes.AppendText(Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine);
        }
    }
}
