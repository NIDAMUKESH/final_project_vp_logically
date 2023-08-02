namespace winSchoolMS
{
    partial class frmCourseAllocate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCourseAllocate));
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTeacherID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gvCourseAllocate = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.chkSecA = new System.Windows.Forms.CheckBox();
            this.chkSecC = new System.Windows.Forms.CheckBox();
            this.chkSecB = new System.Windows.Forms.CheckBox();
            this.chkSecD = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCourseId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvCourseAllocate)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(798, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(927, 132);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(168, 20);
            this.txtFullName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(866, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Full Name";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(254, 129);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(168, 20);
            this.txtCourseName.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(180, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Course Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(543, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Class";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Highlight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(563, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 31);
            this.label8.TabIndex = 14;
            this.label8.Text = "Course Allocate";
            // 
            // txtTeacherID
            // 
            this.txtTeacherID.Location = new System.Drawing.Point(617, 129);
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.Size = new System.Drawing.Size(168, 20);
            this.txtTeacherID.TabIndex = 20;
            this.txtTeacherID.TextChanged += new System.EventHandler(this.txtTeacherID_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Window;
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(553, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Teacher ID";
            // 
            // gvCourseAllocate
            // 
            this.gvCourseAllocate.BackgroundColor = System.Drawing.Color.LightGray;
            this.gvCourseAllocate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCourseAllocate.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvCourseAllocate.Location = new System.Drawing.Point(134, 353);
            this.gvCourseAllocate.Name = "gvCourseAllocate";
            this.gvCourseAllocate.Size = new System.Drawing.Size(1104, 264);
            this.gvCourseAllocate.TabIndex = 24;
            this.gvCourseAllocate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCourseAllocate_CellClick);
            this.gvCourseAllocate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCourseAllocate_CellContentClick);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.Window;
            this.btnInsert.Location = new System.Drawing.Point(449, 283);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 41);
            this.btnInsert.TabIndex = 44;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.Location = new System.Drawing.Point(644, 283);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 41);
            this.btnUpdate.TabIndex = 45;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDelete.Location = new System.Drawing.Point(839, 283);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 41);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1371, 65);
            this.panel1.TabIndex = 47;
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Items.AddRange(new object[] {
            "Class 1st",
            "Class 2nd",
            "Class 3rd",
            "Class 4th",
            "Class 5th",
            "Class 6th",
            "Class 7th",
            "Class 8th",
            "Class 9th",
            "Matric"});
            this.cmbClass.Location = new System.Drawing.Point(617, 212);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(168, 21);
            this.cmbClass.TabIndex = 48;
            // 
            // chkSecA
            // 
            this.chkSecA.AutoSize = true;
            this.chkSecA.Location = new System.Drawing.Point(942, 194);
            this.chkSecA.Name = "chkSecA";
            this.chkSecA.Size = new System.Drawing.Size(55, 17);
            this.chkSecA.TabIndex = 49;
            this.chkSecA.Text = "Sec A";
            this.chkSecA.UseVisualStyleBackColor = true;
            // 
            // chkSecC
            // 
            this.chkSecC.AutoSize = true;
            this.chkSecC.Location = new System.Drawing.Point(942, 220);
            this.chkSecC.Name = "chkSecC";
            this.chkSecC.Size = new System.Drawing.Size(55, 17);
            this.chkSecC.TabIndex = 50;
            this.chkSecC.Text = "Sec C";
            this.chkSecC.UseVisualStyleBackColor = true;
            // 
            // chkSecB
            // 
            this.chkSecB.AutoSize = true;
            this.chkSecB.Location = new System.Drawing.Point(1030, 194);
            this.chkSecB.Name = "chkSecB";
            this.chkSecB.Size = new System.Drawing.Size(55, 17);
            this.chkSecB.TabIndex = 51;
            this.chkSecB.Text = "Sec B";
            this.chkSecB.UseVisualStyleBackColor = true;
            // 
            // chkSecD
            // 
            this.chkSecD.AutoSize = true;
            this.chkSecD.Location = new System.Drawing.Point(1030, 220);
            this.chkSecD.Name = "chkSecD";
            this.chkSecD.Size = new System.Drawing.Size(56, 17);
            this.chkSecD.TabIndex = 52;
            this.chkSecD.Text = "Sec D";
            this.chkSecD.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(866, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Section";
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(254, 213);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(168, 20);
            this.txtFatherName.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(182, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Father Name";
            // 
            // txtCourseId
            // 
            this.txtCourseId.Location = new System.Drawing.Point(109, 169);
            this.txtCourseId.Name = "txtCourseId";
            this.txtCourseId.Size = new System.Drawing.Size(168, 20);
            this.txtCourseId.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(35, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Course Name";
            // 
            // frmCourseAllocate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.txtCourseId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkSecD);
            this.Controls.Add(this.chkSecB);
            this.Controls.Add(this.chkSecC);
            this.Controls.Add(this.chkSecA);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.gvCourseAllocate);
            this.Controls.Add(this.txtTeacherID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCourseAllocate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Course Allocate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCourseAllocate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCourseAllocate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTeacherID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView gvCourseAllocate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.CheckBox chkSecA;
        private System.Windows.Forms.CheckBox chkSecC;
        private System.Windows.Forms.CheckBox chkSecB;
        private System.Windows.Forms.CheckBox chkSecD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCourseId;
        private System.Windows.Forms.Label label5;
    }
}