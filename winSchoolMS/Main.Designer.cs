namespace winSchoolMS
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.personalInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.educationalInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsDetailViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaulterStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseAllocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseAllocateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseAllocateDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examinationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.examinationDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miscellinousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherDetailsViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 599);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1370, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.teacherToolStripMenuItem,
            this.attendanceToolStripMenuItem,
            this.accountsToolStripMenuItem,
            this.courseAllocationToolStripMenuItem,
            this.examinationToolStripMenuItem,
            this.miscellinousToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalInformationToolStripMenuItem,
            this.educationalInformationToolStripMenuItem,
            this.studentsDetailViewToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem1.Text = "Student";
            // 
            // personalInformationToolStripMenuItem
            // 
            this.personalInformationToolStripMenuItem.Name = "personalInformationToolStripMenuItem";
            this.personalInformationToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.personalInformationToolStripMenuItem.Text = "Personal Information";
            this.personalInformationToolStripMenuItem.Click += new System.EventHandler(this.personalInformationToolStripMenuItem_Click);
            // 
            // educationalInformationToolStripMenuItem
            // 
            this.educationalInformationToolStripMenuItem.Name = "educationalInformationToolStripMenuItem";
            this.educationalInformationToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.educationalInformationToolStripMenuItem.Text = "Educational Information";
            this.educationalInformationToolStripMenuItem.Click += new System.EventHandler(this.educationalInformationToolStripMenuItem_Click);
            // 
            // studentsDetailViewToolStripMenuItem
            // 
            this.studentsDetailViewToolStripMenuItem.Name = "studentsDetailViewToolStripMenuItem";
            this.studentsDetailViewToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.studentsDetailViewToolStripMenuItem.Text = "Students Detail View";
            this.studentsDetailViewToolStripMenuItem.Click += new System.EventHandler(this.studentsDetailViewToolStripMenuItem_Click);
            // 
            // teacherToolStripMenuItem
            // 
            this.teacherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teacherDetailsToolStripMenuItem,
            this.teacherDetailsViewToolStripMenuItem});
            this.teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            this.teacherToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.teacherToolStripMenuItem.Text = "Teacher";
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem1,
            this.teacherToolStripMenuItem1,
            this.viewAttendanceToolStripMenuItem});
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            // 
            // studentToolStripMenuItem1
            // 
            this.studentToolStripMenuItem1.Name = "studentToolStripMenuItem1";
            this.studentToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.studentToolStripMenuItem1.Text = "Student";
            this.studentToolStripMenuItem1.Click += new System.EventHandler(this.studentToolStripMenuItem1_Click);
            // 
            // teacherToolStripMenuItem1
            // 
            this.teacherToolStripMenuItem1.Name = "teacherToolStripMenuItem1";
            this.teacherToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.teacherToolStripMenuItem1.Text = "Teacher";
            this.teacherToolStripMenuItem1.Click += new System.EventHandler(this.teacherToolStripMenuItem1_Click);
            // 
            // viewAttendanceToolStripMenuItem
            // 
            this.viewAttendanceToolStripMenuItem.Name = "viewAttendanceToolStripMenuItem";
            this.viewAttendanceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewAttendanceToolStripMenuItem.Text = "View Attendance";
            this.viewAttendanceToolStripMenuItem.Click += new System.EventHandler(this.viewAttendanceToolStripMenuItem_Click);
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.feesToolStripMenuItem,
            this.defaulterStudentToolStripMenuItem});
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.accountsToolStripMenuItem.Text = "Accounts";
            // 
            // feesToolStripMenuItem
            // 
            this.feesToolStripMenuItem.Name = "feesToolStripMenuItem";
            this.feesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.feesToolStripMenuItem.Text = "Fees";
            this.feesToolStripMenuItem.Click += new System.EventHandler(this.feesToolStripMenuItem_Click);
            // 
            // defaulterStudentToolStripMenuItem
            // 
            this.defaulterStudentToolStripMenuItem.Name = "defaulterStudentToolStripMenuItem";
            this.defaulterStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.defaulterStudentToolStripMenuItem.Text = "Defaulter Student";
            this.defaulterStudentToolStripMenuItem.Click += new System.EventHandler(this.defaulterStudentToolStripMenuItem_Click);
            // 
            // courseAllocationToolStripMenuItem
            // 
            this.courseAllocationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.courseAllocateToolStripMenuItem,
            this.courseAllocateDetailToolStripMenuItem});
            this.courseAllocationToolStripMenuItem.Name = "courseAllocationToolStripMenuItem";
            this.courseAllocationToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.courseAllocationToolStripMenuItem.Text = "Course Allocation";
            // 
            // courseAllocateToolStripMenuItem
            // 
            this.courseAllocateToolStripMenuItem.Name = "courseAllocateToolStripMenuItem";
            this.courseAllocateToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.courseAllocateToolStripMenuItem.Text = "Course Allocate";
            this.courseAllocateToolStripMenuItem.Click += new System.EventHandler(this.courseAllocateToolStripMenuItem_Click);
            // 
            // courseAllocateDetailToolStripMenuItem
            // 
            this.courseAllocateDetailToolStripMenuItem.Name = "courseAllocateDetailToolStripMenuItem";
            this.courseAllocateDetailToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.courseAllocateDetailToolStripMenuItem.Text = "Course Allocate Detail";
            this.courseAllocateDetailToolStripMenuItem.Click += new System.EventHandler(this.courseAllocateDetailToolStripMenuItem_Click);
            // 
            // examinationToolStripMenuItem
            // 
            this.examinationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.examinationToolStripMenuItem1,
            this.examinationDetailToolStripMenuItem});
            this.examinationToolStripMenuItem.Name = "examinationToolStripMenuItem";
            this.examinationToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.examinationToolStripMenuItem.Text = "Examination";
            // 
            // examinationToolStripMenuItem1
            // 
            this.examinationToolStripMenuItem1.Name = "examinationToolStripMenuItem1";
            this.examinationToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.examinationToolStripMenuItem1.Text = "Examination";
            this.examinationToolStripMenuItem1.Click += new System.EventHandler(this.examinationToolStripMenuItem1_Click);
            // 
            // examinationDetailToolStripMenuItem
            // 
            this.examinationDetailToolStripMenuItem.Name = "examinationDetailToolStripMenuItem";
            this.examinationDetailToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.examinationDetailToolStripMenuItem.Text = "Examination Detail";
            this.examinationDetailToolStripMenuItem.Click += new System.EventHandler(this.examinationDetailToolStripMenuItem_Click);
            // 
            // miscellinousToolStripMenuItem
            // 
            this.miscellinousToolStripMenuItem.Name = "miscellinousToolStripMenuItem";
            this.miscellinousToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.miscellinousToolStripMenuItem.Text = "Miscellinous";
            // 
            // teacherDetailsToolStripMenuItem
            // 
            this.teacherDetailsToolStripMenuItem.Name = "teacherDetailsToolStripMenuItem";
            this.teacherDetailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.teacherDetailsToolStripMenuItem.Text = "Teacher Information";
            this.teacherDetailsToolStripMenuItem.Click += new System.EventHandler(this.teacherDetailsToolStripMenuItem_Click);
            // 
            // teacherDetailsViewToolStripMenuItem
            // 
            this.teacherDetailsViewToolStripMenuItem.Name = "teacherDetailsViewToolStripMenuItem";
            this.teacherDetailsViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.teacherDetailsViewToolStripMenuItem.Text = "Teacher Details View";
            this.teacherDetailsViewToolStripMenuItem.Click += new System.EventHandler(this.teacherDetailsViewToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 621);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personalInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem educationalInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsDetailViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaulterStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseAllocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseAllocateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseAllocateDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examinationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examinationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem examinationDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miscellinousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherDetailsViewToolStripMenuItem;
    }
}



