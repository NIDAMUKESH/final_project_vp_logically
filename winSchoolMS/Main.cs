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
    public partial class Main : Form
    {
        private int childFormNumber = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
     
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }


        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDashBoard obj = new frmDashBoard();
            obj.MdiParent = this;
            obj.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            frmDashBoard obj = new frmDashBoard();
            obj.MdiParent = this;
            obj.Show();
        }


        private void personalInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentPersonalDetails obj = new frmStudentPersonalDetails();
            obj.MdiParent = this;
            obj.Show();
        }

        private void educationalInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentEducationalDetails obj=new frmStudentEducationalDetails();
            obj.MdiParent = this;
            obj.Show();
        }

        private void studentsDetailViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentDetailsVeiw obj = new frmStudentDetailsVeiw();
            obj.MdiParent = this;
            obj.Show();
        }

        private void teacherDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeacherInformation obj = new frmTeacherInformation();
            obj.MdiParent = this;
            obj.Show();
        }

        private void teacherDetailsViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeacherDetailsView obj = new frmTeacherDetailsView();
            obj.MdiParent = this;
            obj.Show();
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmStudentAttendance obj = new frmStudentAttendance();
            obj.MdiParent = this;
            obj.Show();
        }

        private void teacherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTeacherAttendance obj = new frmTeacherAttendance();
            obj.MdiParent = this;
            obj.Show();
        }

        private void viewAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAttendenceVeiw obj = new frmAttendenceVeiw();
            obj.MdiParent = this;
            obj.Show();
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFeeDetail obj = new frmFeeDetail();
            obj.MdiParent = this;
            obj.Show();
        }

        private void defaulterStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDefultarstudent obj = new frmDefultarstudent();
            obj.MdiParent = this;
            obj.Show();
        }

        private void courseAllocateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCourseAllocate obj = new frmCourseAllocate();
            obj.MdiParent = this;
            obj.Show();
        }

        private void courseAllocateDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCourseAllocateDetail obj = new frmCourseAllocateDetail();
            obj.MdiParent = this;
            obj.Show();
        }

        private void examinationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmExamination obj = new frmExamination();
            obj.MdiParent = this;
            obj.Show();
        }

        private void examinationDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExaminationDetail obj = new FrmExaminationDetail();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
