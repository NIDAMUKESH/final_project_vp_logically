using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winproject;

namespace winSchoolMS
{
    public partial class frmDashBoard : Form
    {
        public frmDashBoard()
        {
            InitializeComponent();
        }

        private void personalInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentPersonalDetails obj = new frmStudentPersonalDetails();
            obj.Show();
        }

        private void educationalInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmStudentEducationalDetails obj = new frmStudentEducationalDetails();
            obj.Show();
        }

        private void studentsDetailViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentDetailsVeiw obj = new frmStudentDetailsVeiw();
            obj.Show();
        }

        private void teacherInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeacherDetailsView obj = new frmTeacherDetailsView();
            obj.Show();
        }

        private void newTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeacherInformation obj = new frmTeacherInformation();
            obj.Show();
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmStudentAttendance obj = new frmStudentAttendance();
            obj.Show();
        }

        private void teacherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTeacherAttendance obj = new frmTeacherAttendance();
            obj.Show();
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFeeDetail obj = new frmFeeDetail();
            obj.Show();
        }

        private void defaulterStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDefultarstudent obj = new frmDefultarstudent();
            obj.Show();
        }

        private void courseAllocateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCourseAllocate obj = new frmCourseAllocate();
            obj.Show();
        }

        private void courseAllocateDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCourseAllocateDetail obj = new frmCourseAllocateDetail();
            obj.Show();
        }

        private void examinationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmExamination obj = new frmExamination();
            obj.Show();

        }

        private void examinationDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExaminationDetail obj = new FrmExaminationDetail();
            obj.Show();
        }

        private void viewAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAttendenceVeiw obj = new frmAttendenceVeiw();
            obj.Show();
        }
    }
}
