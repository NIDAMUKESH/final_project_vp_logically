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
    public partial class frmCourseAllocate : Form
    {
        string CourseId;

        public frmCourseAllocate()
        {
            InitializeComponent();
        }
       
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-F36B86I;Initial Catalog=dbSchoolMS;Integrated Security=True");
        private void txtTeacherID_TextChanged(object sender, EventArgs e)
        {
            string QRY = "SELECT * FROM tblTeacherInformationDetails WHERE Teacher_id = '" + txtTeacherID.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);

            // Add the parameter to the SqlDataAdapter
            da.SelectCommand.Parameters.AddWithValue("@Teacher_id", txtTeacherID.Text);

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                txtFullName.Text = dt.Rows[0]["FullName"].ToString();
                txtFatherName.Text = dt.Rows[0]["FatherName"].ToString();
            }

            else
            {
                txtFullName.Text = string.Empty;
                txtFatherName.Text = string.Empty;

            }
          
            txtFullName.Enabled = false;
            txtFatherName.Enabled = false;

        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string Section = string.Empty;
            if (chkSecA.Checked) Section += "A,";
            if (chkSecB.Checked) Section += "B,";
            if (chkSecC.Checked) Section += "C,";
            if (chkSecD.Checked) Section += "D,";
            if (!string.IsNullOrEmpty(Section))
                Section = Section.TrimEnd(',');
            string checkQRY = "SELECT COUNT(*) FROM tblCourseDetail WHERE CourseName = '" + txtCourseName.Text + "' AND Class = '" + cmbClass.Text + "' AND Section = '" + Section + Section+"'";
            SqlCommand checkCmd = new SqlCommand(checkQRY, con);
            con.Open();
            int count = (int)checkCmd.ExecuteScalar();
            con.Close();

            if (count > 0)
            {
                MessageBox.Show("This course is already assigned to another teacher.", "Course Already Assigned", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string QRY = "Insert into tblCourseDetail (CourseName, Teacher_id, FullName, FatherName, Class, Section) Values('" + txtCourseName.Text + "','" + txtTeacherID.Text + "','" + txtFullName.Text + "','" + txtFatherName.Text + "','" + cmbClass.Text + "','" + Section + "')";
            SqlCommand cmd = new SqlCommand(QRY, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

           
            txtTeacherID.Text = "";
            txtFullName.Text = "";
            txtFatherName.Text = "";
            txtCourseName.Text = "";
            cmbClass.Text = "";
            chkSecA.Checked = false;
            chkSecB.Checked = false;
            chkSecC.Checked = false;
            chkSecD.Checked = false;
            txtFullName.Enabled = false;
            txtFatherName.Enabled = false;
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from tblCourseDetail order by CourseId desc", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            gvCourseAllocate.DataSource = dt1;

            MessageBox.Show("Data Inserted Sucessfully");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Section = string.Empty;
            if (chkSecA.Checked)
            {
                Section = "A";
            }
            else if (chkSecB.Checked)
            {
                Section = "B";
            }
            else if (chkSecC.Checked)
            {
                Section = "C";
            }
            else if (chkSecD.Checked)
            {
                Section = "D";
            }

            string QRY = "UPDATE tblCourseDetail set CourseName = '" + txtCourseName.Text + "', Teacher_id = '" + txtTeacherID.Text + "',FullName='"+ txtFullName.Text + "',FatherName='"+ txtFatherName.Text + "', Class = '" + cmbClass.Text + "', Section='" + Section + "' WHERE CourseId = "+CourseId;

            SqlCommand cmd = new SqlCommand(QRY, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            txtTeacherID.Text = "";
            txtFullName.Text = "";
            txtFatherName.Text = "";
            txtCourseName.Text = "";
            //txtCourseId.Text = "";
            cmbClass.Text = "";
            chkSecA.Checked = false;
            chkSecB.Checked = false;
            chkSecC.Checked = false;
            chkSecD.Checked = false;
        
            txtFullName.Enabled = false;
            txtFatherName.Enabled = false;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblCourseDetail ORDER BY CourseId DESC", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvCourseAllocate.DataSource = dt;

            MessageBox.Show("Data Updated Successfully");
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            string QRY = "Delete from tblCourseDetail WHERE CourseId = " + CourseId;
            SqlCommand cmd = new SqlCommand(QRY, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            SqlDataAdapter da = new SqlDataAdapter("Select * from tblCourseDetail order by CourseId desc", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvCourseAllocate.DataSource = dt;

            txtFullName.Enabled = false;
            txtFatherName.Enabled = false;

            MessageBox.Show("Data Deleted Sucessfully");
        }

        private void frmCourseAllocate_Load(object sender, EventArgs e)
        {
            string QRY = "Select * from tblCourseDetail";
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvCourseAllocate.DataSource = dt;
        }

        private void gvCourseAllocate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             CourseId = gvCourseAllocate.Rows[e.RowIndex].Cells[0].Value.ToString();
            string Teacher_id = gvCourseAllocate.Rows[e.RowIndex].Cells[2].Value.ToString();
            string CourseName = gvCourseAllocate.Rows[e.RowIndex].Cells[1].Value.ToString();
            string FullName = gvCourseAllocate.Rows[e.RowIndex].Cells[3].Value.ToString();
            string FatherName = gvCourseAllocate.Rows[e.RowIndex].Cells[4].Value.ToString();
            string Class = gvCourseAllocate.Rows[e.RowIndex].Cells[5].Value.ToString();
            string Section = gvCourseAllocate.Rows[e.RowIndex].Cells[6].Value.ToString().Trim();

            chkSecA.Checked = false;
            chkSecB.Checked = false;
            chkSecC.Checked = false;
            chkSecD.Checked = false;

            string[] sections = Section.Split(',');
            foreach (string section in sections)
            {
                if (section == "A")
                {
                    chkSecA.Checked = true;
                }
                else if (section == "B")
                {
                    chkSecB.Checked = true;
                }
                else if (section == "C")
                {
                    chkSecC.Checked = true;
                }
                else if (section == "D")
                {
                    chkSecD.Checked = true;
                }
                else
                {
                    MessageBox.Show("Section not defined: " + section);
                }
            }

            txtTeacherID.Text = Teacher_id;
            txtFullName.Enabled = false;
            txtFatherName.Enabled = false;
            txtCourseName.Text = CourseName;
            txtFullName.Text = FullName;
            txtFatherName.Text = FatherName;
            cmbClass.Text = Class;
        }

        private void gvCourseAllocate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < gvCourseAllocate.Columns.Count)
            {
                DataGridViewCell cell = gvCourseAllocate.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Assuming the checkbox column index is 6 (change it to the actual column index of your checkbox column)
                if (e.ColumnIndex == 6 && cell is DataGridViewCheckBoxCell checkBoxCell)
                {
                    bool isChecked = (bool)checkBoxCell.Value;
                    string section = gvCourseAllocate.Rows[e.RowIndex].Cells[6].Value.ToString();                   
                }
                txtFullName.Enabled = false;
                txtFatherName.Enabled = false;
            }
        }

    }
}
    

