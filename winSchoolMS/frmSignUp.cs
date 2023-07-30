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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            frmLogin obj = new frmLogin();
            obj.Show();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (CheckIfEmailExists(email))
            {
                
                txtEmail.Text = "";


                MessageBox.Show("Email already exists in the database. Please use a different email address.",
                        "Account Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
              
                
            }

            string connectionString = "Data Source=DESKTOP-F36B86I;Initial Catalog=dbSchoolMS;Integrated Security=True";
            string query = "INSERT INTO tblSignin (FirstName, LastName, Email, Password) VALUES (@FirstName, @LastName, @Email, @Password)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    cmd.ExecuteNonQuery();
                }
            }

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            MessageBox.Show("Account Created Successfully", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool CheckIfEmailExists(string email)
        {
            string connectionString = "Data Source=DESKTOP-F36B86I;Initial Catalog=dbSchoolMS;Integrated Security=True";
            string query = "SELECT COUNT(*) FROM tblSignin WHERE Email = @Email";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    int count = (int)cmd.ExecuteScalar();

                    // If count is greater than 0, the email already exists in the database.
                    return count > 0;
                }
            }
        }

        private void btnLoginAfter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            frmLogin obj = new frmLogin();
            obj.FormClosed += Main_FormClosed; // Attach the event handler
            obj.Show();
            this.Hide();
        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close(); // Close the login page when the Main form is closed
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
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

        private void txtLastName_Validating(object sender, CancelEventArgs e)
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

        private void txtPassword_Validating(object sender, CancelEventArgs e)
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
