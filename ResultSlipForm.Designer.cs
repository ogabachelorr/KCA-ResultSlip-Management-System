namespace KCAResultSlipManagementSystem
{
	partial class ResultSlipForm
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
			this.txtSearchRegNo = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.lblRegNo = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblCourse = new System.Windows.Forms.Label();
			this.lblSemester = new System.Windows.Forms.Label();
			this.lblAcademicYear = new System.Windows.Forms.Label();
			this.lblAverage = new System.Windows.Forms.Label();
			this.lblComment = new System.Windows.Forms.Label();
			this.dgvSlip = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvSlip)).BeginInit();
			this.SuspendLayout();
			// 
			// txtSearchRegNo
			// 
			this.txtSearchRegNo.Location = new System.Drawing.Point(25, 28);
			this.txtSearchRegNo.Name = "txtSearchRegNo";
			this.txtSearchRegNo.Size = new System.Drawing.Size(100, 20);
			this.txtSearchRegNo.TabIndex = 0;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(25, 63);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 1;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// lblRegNo
			// 
			this.lblRegNo.AutoSize = true;
			this.lblRegNo.Location = new System.Drawing.Point(22, 105);
			this.lblRegNo.Name = "lblRegNo";
			this.lblRegNo.Size = new System.Drawing.Size(0, 13);
			this.lblRegNo.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(39, 105);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 13);
			this.label1.TabIndex = 3;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(25, 165);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(35, 13);
			this.lblName.TabIndex = 4;
			this.lblName.Text = "Name";
			// 
			// lblCourse
			// 
			this.lblCourse.AutoSize = true;
			this.lblCourse.Location = new System.Drawing.Point(22, 192);
			this.lblCourse.Name = "lblCourse";
			this.lblCourse.Size = new System.Drawing.Size(40, 13);
			this.lblCourse.TabIndex = 5;
			this.lblCourse.Text = "Course";
			// 
			// lblSemester
			// 
			this.lblSemester.AutoSize = true;
			this.lblSemester.Location = new System.Drawing.Point(22, 219);
			this.lblSemester.Name = "lblSemester";
			this.lblSemester.Size = new System.Drawing.Size(51, 13);
			this.lblSemester.TabIndex = 6;
			this.lblSemester.Text = "Semester";
			// 
			// lblAcademicYear
			// 
			this.lblAcademicYear.AutoSize = true;
			this.lblAcademicYear.Location = new System.Drawing.Point(25, 242);
			this.lblAcademicYear.Name = "lblAcademicYear";
			this.lblAcademicYear.Size = new System.Drawing.Size(79, 13);
			this.lblAcademicYear.TabIndex = 7;
			this.lblAcademicYear.Text = "Academic Year";
			// 
			// lblAverage
			// 
			this.lblAverage.AutoSize = true;
			this.lblAverage.Location = new System.Drawing.Point(25, 270);
			this.lblAverage.Name = "lblAverage";
			this.lblAverage.Size = new System.Drawing.Size(47, 13);
			this.lblAverage.TabIndex = 8;
			this.lblAverage.Text = "Average";
			// 
			// lblComment
			// 
			this.lblComment.AutoSize = true;
			this.lblComment.Location = new System.Drawing.Point(28, 301);
			this.lblComment.Name = "lblComment";
			this.lblComment.Size = new System.Drawing.Size(51, 13);
			this.lblComment.TabIndex = 9;
			this.lblComment.Text = "Comment";
			// 
			// dgvSlip
			// 
			this.dgvSlip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSlip.Location = new System.Drawing.Point(28, 339);
			this.dgvSlip.Name = "dgvSlip";
			this.dgvSlip.Size = new System.Drawing.Size(240, 150);
			this.dgvSlip.TabIndex = 10;
			// 
			// ResultSlipForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgvSlip);
			this.Controls.Add(this.lblComment);
			this.Controls.Add(this.lblAverage);
			this.Controls.Add(this.lblAcademicYear);
			this.Controls.Add(this.lblSemester);
			this.Controls.Add(this.lblCourse);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblRegNo);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtSearchRegNo);
			this.Name = "ResultSlipForm";
			this.Text = "ResultSlipForm";
			this.Load += new System.EventHandler(this.ResultSlipForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvSlip)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtSearchRegNo;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label lblRegNo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblCourse;
		private System.Windows.Forms.Label lblSemester;
		private System.Windows.Forms.Label lblAcademicYear;
		private System.Windows.Forms.Label lblAverage;
		private System.Windows.Forms.Label lblComment;
		private System.Windows.Forms.DataGridView dgvSlip;
	}
}