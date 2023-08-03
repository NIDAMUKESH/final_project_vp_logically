using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winSchoolMS
{
    public partial class frmTeacherInformation : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-F36B86I;Initial Catalog=dbSchoolMS;Integrated Security=True");

        private string TeacherID;
        //private string con;

        public frmTeacherInformation()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string gender = string.Empty;
            if (rdbMale.Checked)
            {
                gender = "Male";
            }
            if (rdbFemale.Checked)
            {
                gender = "Female";
            }

            string QRY = "Insert into tblTeacherInformationDetails ( Teacher_Id ,FullName, FatherName, Address, NIC, PhoneNO, Email, Qualification, Experience, Salary, Designation,JoiningDate,Gender) Values( '" + txtTeacher_Id.Text + "','" + txtfullName.Text + "','" + txtFatherName.Text + "','" + txtAddress.Text + "','" + maskedTextBoxNIC.Text + "','" + txtPhoneno.Text + "','" + txtEmail.Text + "','" + txtQualification.Text + "','" + txtExperience.Text + "','" + txtSalary.Text + "','" + txtDesignation.Text + "','" + dtJoiningDate.Text + "','" + gender + "')";
            SqlCommand cmd = new SqlCommand(QRY, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            txtTeacher_Id.Text = "";
            txtfullName.Text = "";
            txtFatherName.Text = "";
            txtAddress.Text = "";
            maskedTextBoxNIC.Text = "";
            txtAddress.Text = "";
            txtPhoneno.Text = "";
            txtEmail.Text = "";
            txtQualification.Text = "";
            txtExperience.Text = "";
            txtSalary.Text = "";
            txtDesignation.Text = "";
            dtJoiningDate.Text = "";
            rdbMale.Checked = false;
            rdbFemale.Checked = false;

            MessageBox.Show("Data Inserted Sucessfully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);


            SqlDataAdapter da = new SqlDataAdapter("Select * from tblTeacherInformationDetails order by TeacherID desc", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grdTeacherInfo.DataSource = dt;


        }
            
            private void frmTeacherInformation_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblTeacherInformationDetails order by TeacherID desc", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grdTeacherInfo.DataSource = dt;

            
        }

        private void grdTeacherInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TeacherID = grdTeacherInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
            string Teacher_ID = grdTeacherInfo.Rows[e.RowIndex].Cells[1].Value.ToString();
            string FullName = grdTeacherInfo.Rows[e.RowIndex].Cells[2].Value.ToString();
            string FatherName = grdTeacherInfo.Rows[e.RowIndex].Cells[3].Value.ToString();
            string Address = grdTeacherInfo.Rows[e.RowIndex].Cells[4].Value.ToString();
            string NIC = grdTeacherInfo.Rows[e.RowIndex].Cells[5].Value.ToString();
            string PhoneNo = grdTeacherInfo.Rows[e.RowIndex].Cells[6].Value.ToString();
            string Email = grdTeacherInfo.Rows[e.RowIndex].Cells[7].Value.ToString();
            string Qualification = grdTeacherInfo.Rows[e.RowIndex].Cells[8].Value.ToString();
            string Experience = grdTeacherInfo.Rows[e.RowIndex].Cells[9].Value.ToString();
            string Salary = grdTeacherInfo.Rows[e.RowIndex].Cells[10].Value.ToString();
            string Designation = grdTeacherInfo.Rows[e.RowIndex].Cells[11].Value.ToString();
            string JoiningDate = grdTeacherInfo.Rows[e.RowIndex].Cells[12].Value.ToString();
            string Gender = grdTeacherInfo.Rows[e.RowIndex].Cells[13].Value.ToString().Trim().ToLower();



            if (Gender == "male")
            {
                rdbMale.Checked = true;
                rdbFemale.Checked = false;
            }
            else if (Gender == "female")
            {
                rdbFemale.Checked = true;
                rdbMale.Checked = false;
            }
            else
            {
                MessageBox.Show("not defined");
            }
           
            txtTeacher_Id.Text = Teacher_ID;
            txtfullName.Text = FullName;
            txtFatherName.Text = FatherName;
            txtAddress.Text = Address;
            maskedTextBoxNIC.Text = NIC;
            txtPhoneno.Text = PhoneNo;
            txtEmail.Text = Email;
            txtQualification.Text = Qualification;
            txtExperience.Text = Experience;
            txtSalary.Text = Salary;
            txtDesignation.Text = Designation;
            dtJoiningDate.Text = JoiningDate;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string gender = string.Empty;
            if (rdbMale.Checked)
            {
                gender = "Male";
            }
            if (rdbFemale.Checked)
            {
                gender = "Female";
            }

            string v = $"UPDATE tblTeacherInformationDetails SET Teacher_Id = '{txtTeacher_Id.Text}',  FullName = '{txtfullName.Text}', FatherName = '{txtFatherName.Text}', Address = '{txtAddress.Text}', NIC = '{maskedTextBoxNIC.Text}', Phoneno = '{txtPhoneno.Text}', Email = '{txtEmail.Text}', Qualification = '{txtQualification.Text}', Experience = '{txtExperience.Text}', Salary = '{txtSalary.Text}', Designation = '{txtDesignation.Text}', JoiningDate = '{dtJoiningDate.Text}', Gender = '{gender}' WHERE TeacherID = {TeacherID}";
            string QRY = v;
                SqlCommand cmd = new SqlCommand(QRY, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                txtTeacher_Id.Text = "";
                txtfullName.Text = "";
                txtFatherName.Text = "";
                txtAddress.Text = "";
                maskedTextBoxNIC.Text = "";
                txtPhoneno.Text = "";
                txtEmail.Text = "";
                txtQualification.Text = "";
                txtExperience.Text = "";
                txtSalary.Text = "";
                txtDesignation.Text = "";
                dtJoiningDate.Text = "";
                rdbMale.Checked = false;
                rdbFemale.Checked = false;
            
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblTeacherInformationDetails order by TeacherID desc", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grdTeacherInfo.DataSource = dt;
            

            MessageBox.Show("Data Update Sucessfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string gender = string.Empty;
            if (rdbMale.Checked)
            {
                gender = "Male";
            }
            if (rdbFemale.Checked)
            {
                gender = "Female";
            }



            string QRY = "Delete from tblTeacherInformationDetails where TeacherID=" + @TeacherID; 
            SqlCommand cmd = new SqlCommand (QRY, con);
            con.Open();
            cmd.Parameters.AddWithValue("@TeacherID", TeacherID);
           
            cmd.ExecuteNonQuery();
            con.Close();

            SqlDataAdapter da = new SqlDataAdapter("Select * from tblTeacherInformationDetails order by TeacherID desc", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grdTeacherInfo.DataSource = dt;
            btnInsert.Enabled = true;

            MessageBox.Show("Data Deleted Sucessfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);

            txtTeacher_Id.Text = "";
            txtfullName.Text = "";
            txtFatherName.Text = "";
            txtAddress.Text = "";
            maskedTextBoxNIC.Text = "";
            txtPhoneno.Text = "";
            txtEmail.Text = "";
            txtQualification.Text = "";
            txtExperience.Text = "";
            txtSalary.Text = "";
            txtDesignation.Text = "";
            dtJoiningDate.Text = "";
            rdbMale.Checked = false;
            rdbFemale.Checked = false;
        }

    }
    }
    

