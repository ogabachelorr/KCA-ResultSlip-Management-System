namespace KCAResultSlipManagementSystem
{
	partial class StudentsForm
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
			this.txtRegNo = new System.Windows.Forms.TextBox();
			this.txtFullName = new System.Windows.Forms.TextBox();
			this.cmbGender = new System.Windows.Forms.ComboBox();
			this.txtCourse = new System.Windows.Forms.TextBox();
			this.txtDepartment = new System.Windows.Forms.TextBox();
			this.txtSemester = new System.Windows.Forms.TextBox();
			this.txtAcademicYear = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.dgvStudents = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
			this.SuspendLayout();
			// 
			// txtRegNo
			// 
			this.txtRegNo.Location = new System.Drawing.Point(99, 20);
			this.txtRegNo.Name = "txtRegNo";
			this.txtRegNo.Size = new System.Drawing.Size(100, 20);
			this.txtRegNo.TabIndex = 0;
			// 
			// txtFullName
			// 
			this.txtFullName.Location = new System.Drawing.Point(99, 59);
			this.txtFullName.Name = "txtFullName";
			this.txtFullName.Size = new System.Drawing.Size(100, 20);
			this.txtFullName.TabIndex = 1;
			// 
			// cmbGender
			// 
			this.cmbGender.AllowDrop = true;
			this.cmbGender.FormattingEnabled = true;
			this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
			this.cmbGender.Location = new System.Drawing.Point(22, 95);
			this.cmbGender.Name = "cmbGender";
			this.cmbGender.Size = new System.Drawing.Size(121, 21);
			this.cmbGender.TabIndex = 2;
			this.cmbGender.Text = "Gender";
			this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.cmbGender_SelectedIndexChanged);
			// 
			// txtCourse
			// 
			this.txtCourse.Location = new System.Drawing.Point(99, 146);
			this.txtCourse.Name = "txtCourse";
			this.txtCourse.Size = new System.Drawing.Size(100, 20);
			this.txtCourse.TabIndex = 3;
			// 
			// txtDepartment
			// 
			this.txtDepartment.Location = new System.Drawing.Point(99, 202);
			this.txtDepartment.Name = "txtDepartment";
			this.txtDepartment.Size = new System.Drawing.Size(100, 20);
			this.txtDepartment.TabIndex = 4;
			// 
			// txtSemester
			// 
			this.txtSemester.Location = new System.Drawing.Point(99, 251);
			this.txtSemester.Name = "txtSemester";
			this.txtSemester.Size = new System.Drawing.Size(100, 20);
			this.txtSemester.TabIndex = 5;
			// 
			// txtAcademicYear
			// 
			this.txtAcademicYear.Location = new System.Drawing.Point(99, 297);
			this.txtAcademicYear.Name = "txtAcademicYear";
			this.txtAcademicYear.Size = new System.Drawing.Size(100, 20);
			this.txtAcademicYear.TabIndex = 6;
			// 
			// btnSave
			// 
			this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnSave.Location = new System.Drawing.Point(22, 335);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// dgvStudents
			// 
			this.dgvStudents.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStudents.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dgvStudents.Location = new System.Drawing.Point(22, 377);
			this.dgvStudents.Name = "dgvStudents";
			this.dgvStudents.Size = new System.Drawing.Size(293, 61);
			this.dgvStudents.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(19, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Reg No";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new System.Drawing.Point(22, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Full Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Location = new System.Drawing.Point(22, 153);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Course";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label4.Location = new System.Drawing.Point(22, 208);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Department";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label5.Location = new System.Drawing.Point(25, 257);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Semester";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label6.Location = new System.Drawing.Point(25, 303);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(79, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "Academic Year";
			// 
			// StudentsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvStudents);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtAcademicYear);
			this.Controls.Add(this.txtSemester);
			this.Controls.Add(this.txtDepartment);
			this.Controls.Add(this.txtCourse);
			this.Controls.Add(this.cmbGender);
			this.Controls.Add(this.txtFullName);
			this.Controls.Add(this.txtRegNo);
			this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.Name = "StudentsForm";
			this.Text = "StudentsForm";
			this.Click += new System.EventHandler(this.btnSave_Click);
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtRegNo;
		private System.Windows.Forms.TextBox txtFullName;
		private System.Windows.Forms.ComboBox cmbGender;
		private System.Windows.Forms.TextBox txtCourse;
		private System.Windows.Forms.TextBox txtDepartment;
		private System.Windows.Forms.TextBox txtSemester;
		private System.Windows.Forms.TextBox txtAcademicYear;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.DataGridView dgvStudents;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}