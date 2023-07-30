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

namespace winSchoolMS
{
    public partial class FrmForgetpassword : Form
    {
        public FrmForgetpassword()
        {
            InitializeComponent();
        }


        private void btnCancle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            frmLogin obj = new frmLogin();
      
            obj.FormClosed += Main_FormClosed; // Attach the event handler
            obj.Show();
            this.Hide();
        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close(); // Close the login page when the Main form is closed
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-F36B86I;Initial Catalog=dbSchoolMS;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string email = txtEmail.Text;
                string newPassword = txtNewPassword.Text;
                string confirmNewPassword = txtConfirmPassword.Text;

                // Check if the entered password matches the confirmed password
                if (newPassword == confirmNewPassword)
                {
                    // Check if the email exists in the database
                    string selectQuery = "SELECT COUNT(*) FROM tblSignin WHERE Email = @Email";
                    SqlCommand selectCommand = new SqlCommand(selectQuery, con);
                    selectCommand.Parameters.AddWithValue("@Email", email);

                    con.Open();
                    int emailCount = (int)selectCommand.ExecuteScalar();
                    con.Close();

                    if (emailCount == 1) // Email exists in the database
                    {
                        // Update the password
                        string updateQuery = "UPDATE tblSignin SET Password = @Password WHERE Email = @Email";
                        SqlCommand updateCommand = new SqlCommand(updateQuery, con);
                        updateCommand.Parameters.AddWithValue("@Password", newPassword);
                        updateCommand.Parameters.AddWithValue("@Email", email);

                        con.Open();
                        int rowsAffected = updateCommand.ExecuteNonQuery();
                        con.Close();

                        if (rowsAffected > 0)
                        {
                            // Password updated successfully
                            txtEmail.Text = "";
                            txtNewPassword.Text = "";
                            txtConfirmPassword.Text = "";
                            MessageBox.Show("Password saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            txtConfirmPassword.Text = "";
                            MessageBox.Show("Failed to update password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        txtEmail.Text = "";
                        MessageBox.Show("Incorrect email. Email not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    txtConfirmPassword.Text = "";
                    MessageBox.Show("Password does not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmForgetpassword_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                // Initialize an instance of ErrorProvider
                ErrorProvider errorProvider = new ErrorProvider();
                errorProvider.SetError(txtEmail, "Please enter email");
            }
            else
            {
                ErrorProvider errorProvider = new ErrorProvider();
                e.Cancel = false; // If the input is not empty, there's no validation error.
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                // Initialize an instance of ErrorProvider
                ErrorProvider errorProvider = new ErrorProvider();
                errorProvider.SetError(txtEmail, "Please enter email");
            }
            else
            {
                ErrorProvider errorProvider = new ErrorProvider();
                e.Cancel = false; // If the input is not empty, there's no validation error.
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                // Initialize an instance of ErrorProvider
                ErrorProvider errorProvider = new ErrorProvider();
                errorProvider.SetError(txtEmail, "Please enter email");
            }
            else
            {
                ErrorProvider errorProvider = new ErrorProvider();
                e.Cancel = false; // If the input is not empty, there's no validation error.
                errorProvider.SetError(txtEmail, null);
            }
        }
    }
}
