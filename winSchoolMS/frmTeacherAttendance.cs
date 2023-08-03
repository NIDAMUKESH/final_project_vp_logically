using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winproject
{
    public partial class frmTeacherAttendance : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-94G8VM9;Initial Catalog=dbSchoolMS;Integrated Security=True");
        SqlCommand cmd;
        private object dr;
        private string Teacher_Id;
        private string AttendanceStatus;

        public string AttendanceID { get; private set; }
        
        public frmTeacherAttendance()
        {
            InitializeComponent();
        }



        private void frmTeacherAttendance_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-94G8VM9;Initial Catalog=dbSchoolMS;Integrated Security=True");
            string QRY = "Select * from tblTeacherAttendance";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvTeacherAttendance.DataSource = dt;

           
        }

        private void txtTeacher_Id_TextChanged(object sender, EventArgs e)
        {
         
            string QRY = "SELECT * FROM tblTeacherInformationDetails WHERE Teacher_Id = @Teacher_id";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);

            // Add the parameter to the SqlDataAdapter
            da.SelectCommand.Parameters.AddWithValue("@Teacher_Id", txtTeacher_Id.Text);

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                txtFullName.Text = dt.Rows[0]["FullName"].ToString();
               
            }
            else
            {
                txtFullName.Text = string.Empty;
                            }

            txtFullName.Enabled = false;
                    }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string AttendanceStatus = string.Empty;
            if (rdbPresent.Checked)
            {
                AttendanceStatus = "Present";
            }
            if (rdbAbsent.Checked)
            {
                AttendanceStatus = "Absent";
            }
            if (rdbLeave.Checked)
            {
                AttendanceStatus = "Leave";
            }

            string QRY = "Insert into tblTeacherAttendance (Teacher_Id, FullName, Date, Time, AttendanceStatus)Values('" + txtTeacher_Id.Text + "','" + txtFullName.Text + "','" + dtpDate.Text + "','" + dtpTime.Text + "','" + AttendanceStatus + "')";
            SqlCommand cmd = new SqlCommand(QRY, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            txtTeacher_Id.Text = "";
            txtFullName.Text = "";
            dtpDate.Text = ""; 
            dtpTime.Text = "";


            SqlDataAdapter da = new SqlDataAdapter("Select Teacher_Id, FullName, Date, Time, AttendanceStatus from tblTeacherAttendance order by  AttendanceID desc", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvTeacherAttendance.DataSource = dt;

            txtFullName.Enabled = false;

            MessageBox.Show("Data Inserted Sucessfully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        private void gvTeacherAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            
                AttendanceID = gvTeacherAttendance.Rows[e.RowIndex].Cells[0].Value.ToString();
            string Teacher_ID = gvTeacherAttendance.Rows[e.RowIndex].Cells[1].Value.ToString();
            string FullName = gvTeacherAttendance.Rows[e.RowIndex].Cells[2].Value.ToString();
            string Date = gvTeacherAttendance.Rows[e.RowIndex].Cells[3].Value.ToString();
            string Time = gvTeacherAttendance.Rows[e.RowIndex].Cells[4].Value.ToString();
            string AttendanceStatus = gvTeacherAttendance.Rows[e.RowIndex].Cells[5].Value.ToString().Trim().ToLower();

           
            if (rdbPresent.Checked)
            {
                AttendanceStatus = "Present";
            }
            if (rdbAbsent.Checked)
            {
                AttendanceStatus = "Absent";
            }
            if (rdbLeave.Checked)
            {
                AttendanceStatus = "Leave";
            }
            txtTeacher_Id.Text = Teacher_ID;
            txtFullName.Text = FullName;
            dtpDate.Text = Date;
            dtpTime.Text = Time;
            }






        private void btnUpdate_Click(object sender, EventArgs e)
        {
                
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-94G8VM9;Initial Catalog=dbSchoolMS;Integrated Security=True");
            string AttendanceStatus = string.Empty;
            if (rdbPresent.Checked)
            {
                AttendanceStatus = "Present";
            }
            if (rdbAbsent.Checked)
            {
                AttendanceStatus = "Absent";
            }
            if (rdbLeave.Checked)
            {
                AttendanceStatus = "Leave";
            }

            string v = $"UPDATE tblTeacherAttendance SET Teacher_Id = '{txtTeacher_Id.Text}', FullName = '{txtFullName.Text}', Date = '{dtpDate.Text}', Time = '{dtpTime.Text}',AttendanceStatus = '{AttendanceStatus}' WHERE AttendanceID = {AttendanceID}";
            string QRY = v;
            SqlCommand cmd = new SqlCommand(QRY, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            txtTeacher_Id.Text = "";
            txtFullName.Text = "";
            dtpDate.Text = "";
            dtpTime.Text = "";
            rdbPresent.Checked = false;
            rdbAbsent.Checked = false;
            rdbLeave.Checked = false;

            SqlDataAdapter da = new SqlDataAdapter("Select * from tblTeacherAttendance order by AttendanceID desc", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvTeacherAttendance.DataSource = dt;


            MessageBox.Show("Data Update Sucessfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-94G8VM9;Initial Catalog=dbSchoolMS;Integrated Security=True");
            string AttendanceStatus = string.Empty;
            if (rdbPresent.Checked)
            {
                AttendanceStatus = "Present";
            }
            if (rdbAbsent.Checked)
            {
                AttendanceStatus = "Absent";
            }
            if (rdbLeave.Checked)
            {
                AttendanceStatus = "Leave";
            }

            string QRY = "Delete from tblTeacherAttendance where AttendanceID=" + @AttendanceID;
            SqlCommand cmd = new SqlCommand(QRY, con);
            con.Open();
            cmd.Parameters.AddWithValue("@AttendanceID", AttendanceID);

            cmd.ExecuteNonQuery();
            con.Close();

            SqlDataAdapter da = new SqlDataAdapter("Select * from tblTeacherAttendance order by AttendanceID desc", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvTeacherAttendance.DataSource = dt;
            btnInsert.Enabled = true;

            MessageBox.Show("Data Deleted Sucessfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);

            txtTeacher_Id.Text = "";
            txtFullName.Text = "";
            dtpDate.Text = "";
            dtpTime.Text = "";
            rdbPresent.Checked = false;
            rdbAbsent.Checked = false;
            rdbLeave.Checked = false;
        }
    }
    }

    






    

        
    

    

