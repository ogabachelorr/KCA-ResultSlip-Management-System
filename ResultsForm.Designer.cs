namespace KCAResultSlipManagementSystem
{
	partial class ResultsForm
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
			this.cmbStudent = new System.Windows.Forms.ComboBox();
			this.cmbUnit = new System.Windows.Forms.ComboBox();
			this.txtCAT = new System.Windows.Forms.TextBox();
			this.txtExam = new System.Windows.Forms.TextBox();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lblGrade = new System.Windows.Forms.Label();
			this.lblRemark = new System.Windows.Forms.Label();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.btnSaveResult = new System.Windows.Forms.Button();
			this.dgvResults = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbStudent
			// 
			this.cmbStudent.FormattingEnabled = true;
			this.cmbStudent.Location = new System.Drawing.Point(13, 13);
			this.cmbStudent.Name = "cmbStudent";
			this.cmbStudent.Size = new System.Drawing.Size(121, 21);
			this.cmbStudent.TabIndex = 0;
			this.cmbStudent.Text = "Student";
			// 
			// cmbUnit
			// 
			this.cmbUnit.FormattingEnabled = true;
			this.cmbUnit.Location = new System.Drawing.Point(13, 55);
			this.cmbUnit.Name = "cmbUnit";
			this.cmbUnit.Size = new System.Drawing.Size(121, 21);
			this.cmbUnit.TabIndex = 1;
			this.cmbUnit.Text = "Unit";
			// 
			// txtCAT
			// 
			this.txtCAT.Location = new System.Drawing.Point(143, 107);
			this.txtCAT.Name = "txtCAT";
			this.txtCAT.Size = new System.Drawing.Size(100, 20);
			this.txtCAT.TabIndex = 2;
			// 
			// txtExam
			// 
			this.txtExam.Location = new System.Drawing.Point(143, 148);
			this.txtExam.Name = "txtExam";
			this.txtExam.Size = new System.Drawing.Size(100, 20);
			this.txtExam.TabIndex = 3;
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(13, 187);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(31, 13);
			this.lblTotal.TabIndex = 4;
			this.lblTotal.Text = "Total";
			// 
			// lblGrade
			// 
			this.lblGrade.AutoSize = true;
			this.lblGrade.Location = new System.Drawing.Point(13, 220);
			this.lblGrade.Name = "lblGrade";
			this.lblGrade.Size = new System.Drawing.Size(36, 13);
			this.lblGrade.TabIndex = 5;
			this.lblGrade.Text = "Grade";
			// 
			// lblRemark
			// 
			this.lblRemark.AutoSize = true;
			this.lblRemark.Location = new System.Drawing.Point(13, 250);
			this.lblRemark.Name = "lblRemark";
			this.lblRemark.Size = new System.Drawing.Size(44, 13);
			this.lblRemark.TabIndex = 6;
			this.lblRemark.Text = "Remark";
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(3, 277);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(75, 23);
			this.btnCalculate.TabIndex = 7;
			this.btnCalculate.Text = "Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// btnSaveResult
			// 
			this.btnSaveResult.Location = new System.Drawing.Point(3, 315);
			this.btnSaveResult.Name = "btnSaveResult";
			this.btnSaveResult.Size = new System.Drawing.Size(75, 23);
			this.btnSaveResult.TabIndex = 8;
			this.btnSaveResult.Text = "Save Result";
			this.btnSaveResult.UseVisualStyleBackColor = true;
			this.btnSaveResult.Click += new System.EventHandler(this.btnSaveResult_Click_1);
			// 
			// dgvResults
			// 
			this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvResults.Location = new System.Drawing.Point(3, 366);
			this.dgvResults.Name = "dgvResults";
			this.dgvResults.Size = new System.Drawing.Size(240, 150);
			this.dgvResults.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 113);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(28, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "CAT";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 154);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Result Form";
			// 
			// ResultsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvResults);
			this.Controls.Add(this.btnSaveResult);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.lblRemark);
			this.Controls.Add(this.lblGrade);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.txtExam);
			this.Controls.Add(this.txtCAT);
			this.Controls.Add(this.cmbUnit);
			this.Controls.Add(this.cmbStudent);
			this.Name = "ResultsForm";
			((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbStudent;
		private System.Windows.Forms.ComboBox cmbUnit;
		private System.Windows.Forms.TextBox txtCAT;
		private System.Windows.Forms.TextBox txtExam;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblGrade;
		private System.Windows.Forms.Label lblRemark;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Button btnSaveResult;
		private System.Windows.Forms.DataGridView dgvResults;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}