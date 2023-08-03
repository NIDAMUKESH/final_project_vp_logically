namespace winSchoolMS
{
    partial class frmTeacherInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacherInformation));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhoneno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtExperience = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.labal2 = new System.Windows.Forms.Label();
            this.txtQualification = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.grdTeacherInfo = new System.Windows.Forms.DataGridView();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtJoiningDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtfullName = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.Lable20 = new System.Windows.Forms.Label();
            this.maskedTextBoxNIC = new System.Windows.Forms.MaskedTextBox();
            this.txtTeacher_Id = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdTeacherInfo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(576, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Teacher Information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(513, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Full Name";
            // 
            // txtPhoneno
            // 
            this.txtPhoneno.Location = new System.Drawing.Point(916, 169);
            this.txtPhoneno.MaxLength = 11;
            this.txtPhoneno.Name = "txtPhoneno";
            this.txtPhoneno.Size = new System.Drawing.Size(174, 20);
            this.txtPhoneno.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(842, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone no";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(255, 211);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(174, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(184, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(513, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "NIC";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(255, 169);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(174, 20);
            this.txtAddress.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(184, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Address";
            // 
            // txtExperience
            // 
            this.txtExperience.Location = new System.Drawing.Point(916, 214);
            this.txtExperience.Name = "txtExperience";
            this.txtExperience.Size = new System.Drawing.Size(174, 20);
            this.txtExperience.TabIndex = 21;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label.Location = new System.Drawing.Point(842, 221);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(60, 13);
            this.label.TabIndex = 20;
            this.label.Text = "Experience";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(254, 255);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(175, 20);
            this.txtSalary.TabIndex = 19;
            // 
            // labal2
            // 
            this.labal2.AutoSize = true;
            this.labal2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labal2.Location = new System.Drawing.Point(184, 259);
            this.labal2.Name = "labal2";
            this.labal2.Size = new System.Drawing.Size(36, 13);
            this.labal2.TabIndex = 18;
            this.labal2.Text = "Salary";
            // 
            // txtQualification
            // 
            this.txtQualification.Location = new System.Drawing.Point(584, 211);
            this.txtQualification.Name = "txtQualification";
            this.txtQualification.Size = new System.Drawing.Size(174, 20);
            this.txtQualification.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(513, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Qualification";
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.BackColor = System.Drawing.Color.DodgerBlue;
            this.rdbMale.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdbMale.Location = new System.Drawing.Point(254, 306);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(48, 17);
            this.rdbMale.TabIndex = 24;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(184, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Gender";
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rdbFemale.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdbFemale.Location = new System.Drawing.Point(315, 306);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(59, 17);
            this.rdbFemale.TabIndex = 26;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = false;
            // 
            // grdTeacherInfo
            // 
            this.grdTeacherInfo.BackgroundColor = System.Drawing.Color.LightGray;
            this.grdTeacherInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTeacherInfo.Location = new System.Drawing.Point(31, 438);
            this.grdTeacherInfo.Name = "grdTeacherInfo";
            this.grdTeacherInfo.Size = new System.Drawing.Size(1313, 203);
            this.grdTeacherInfo.TabIndex = 29;
            this.grdTeacherInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTeacherInfo_CellClick);
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(584, 259);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(174, 20);
            this.txtDesignation.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(515, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Designation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(842, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Joining Date";
            // 
            // dtJoiningDate
            // 
            this.dtJoiningDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtJoiningDate.Location = new System.Drawing.Point(916, 262);
            this.dtJoiningDate.Name = "dtJoiningDate";
            this.dtJoiningDate.Size = new System.Drawing.Size(174, 20);
            this.dtJoiningDate.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1439, 65);
            this.panel1.TabIndex = 35;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.Window;
            this.btnInsert.Location = new System.Drawing.Point(423, 359);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 39);
            this.btnInsert.TabIndex = 43;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.Location = new System.Drawing.Point(627, 359);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 39);
            this.btnUpdate.TabIndex = 44;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDelete.Location = new System.Drawing.Point(814, 359);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 39);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtfullName
            // 
            this.txtfullName.Location = new System.Drawing.Point(584, 125);
            this.txtfullName.Name = "txtfullName";
            this.txtfullName.Size = new System.Drawing.Size(174, 20);
            this.txtfullName.TabIndex = 46;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::winSchoolMS.Properties.Resources.student_Dummy_pic_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(1148, 126);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(139, 142);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(916, 125);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(174, 20);
            this.txtFatherName.TabIndex = 49;
            // 
            // Lable20
            // 
            this.Lable20.AutoSize = true;
            this.Lable20.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Lable20.Location = new System.Drawing.Point(842, 128);
            this.Lable20.Name = "Lable20";
            this.Lable20.Size = new System.Drawing.Size(68, 13);
            this.Lable20.TabIndex = 48;
            this.Lable20.Text = "Father Name";
            // 
            // maskedTextBoxNIC
            // 
            this.maskedTextBoxNIC.Location = new System.Drawing.Point(584, 165);
            this.maskedTextBoxNIC.Mask = "00000-0000000-0";
            this.maskedTextBoxNIC.Name = "maskedTextBoxNIC";
            this.maskedTextBoxNIC.Size = new System.Drawing.Size(174, 20);
            this.maskedTextBoxNIC.TabIndex = 51;
            // 
            // txtTeacher_Id
            // 
            this.txtTeacher_Id.Location = new System.Drawing.Point(255, 126);
            this.txtTeacher_Id.Name = "txtTeacher_Id";
            this.txtTeacher_Id.Size = new System.Drawing.Size(174, 20);
            this.txtTeacher_Id.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(182, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 52;
            this.label12.Text = "Teacher id";
            // 
            // frmTeacherInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.txtTeacher_Id);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.maskedTextBoxNIC);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.Lable20);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtfullName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dtJoiningDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grdTeacherInfo);
            this.Controls.Add(this.rdbFemale);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rdbMale);
            this.Controls.Add(this.txtExperience);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.labal2);
            this.Controls.Add(this.txtQualification);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPhoneno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTeacherInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher Information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTeacherInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTeacherInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhoneno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtExperience;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label labal2;
        private System.Windows.Forms.TextBox txtQualification;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.DataGridView grdTeacherInfo;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtJoiningDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtfullName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label Lable20;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNIC;
        private System.Windows.Forms.TextBox txtTeacher_Id;
        private System.Windows.Forms.Label label12;
    }
}