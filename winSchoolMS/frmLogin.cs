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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-F36B86I;Initial Catalog=dbSchoolMS;Integrated Security=True");

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close(); // Close the login page when the Main form is closed
        }
        private void FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close(); // Close the login page when the Main form is closed
        }
        private void lblCreateanAccount_Click(object sender, EventArgs e)
        {
            frmSignUp obj = new frmSignUp();
            obj.FormClosed += FormClosed;
            obj.Show();
            this.Hide();
        }
      

        private void label4_Click_1(object sender, EventArgs e)
        {
            FrmForgetpassword obj = new FrmForgetpassword();
            obj.Show();            
            obj.FormClosed += Main_FormClosed; // Attach the event handler
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string QRY = "SELECT * FROM tblSignin where Email= '" + txtEmail.Text + "' AND Password = '" + txtPassward.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string user_name, user_password;

            user_name = txtEmail.Text;
            user_password = txtPassward.Text;

            if (dt.Rows.Count > 0)
            {


                user_name = txtEmail.Text;
                user_password = txtPassward.Text;
                txtEmail.Text = "";
                txtPassward.Text = "";
                //page that needed to be load next
                Main obj = new Main();
                obj.FormClosed += Main_FormClosed; // Attach the event handler
                obj.Show();
                this.Hide();
            }
            else
            {
                // Unsuccessful login
                bool isEmailCorrect = false;
                bool isPasswordCorrect = false;

                // Check if email is incorrect
                QRY = "SELECT COUNT(*) FROM tblSignin where Email= '" + txtEmail.Text + "'";
                da = new SqlDataAdapter(QRY, con);
                dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0 && dt.Rows[0][0].ToString() == "1")
                {
                    isEmailCorrect = true;
                }

                // Check if password is incorrect
                QRY = "SELECT COUNT(*) FROM tblSignin where Email= '" + txtEmail.Text + "' AND Password = '" + txtPassward.Text + "'";
                da = new SqlDataAdapter(QRY, con);
                dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0 && dt.Rows[0][0].ToString() == "1")
                {
                    isPasswordCorrect = true;
                }

                // Show appropriate error message
                if (!isEmailCorrect) 
                {
                    txtEmail.Text = "";
                    MessageBox.Show("Email is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
                else if (!isPasswordCorrect)
                {
                    txtPassward.Text = "";
                    MessageBox.Show("Password is incorrect.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else if (!isEmailCorrect && !isPasswordCorrect) 
                {
                    txtEmail.Text = "";
                    txtPassward.Text = "";
                    MessageBox.Show("Email and password are incorrect.", "Invalid login.", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
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

        private void txtPassward_Validating(object sender, CancelEventArgs e)
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
