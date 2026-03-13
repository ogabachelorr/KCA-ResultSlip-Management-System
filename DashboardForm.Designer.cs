namespace KCAResultSlipManagementSystem
{
	partial class DashboardForm
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
			this.btnStudents = new System.Windows.Forms.Button();
			this.btnUnits = new System.Windows.Forms.Button();
			this.btnResults = new System.Windows.Forms.Button();
			this.btnResultSlip = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnStudents
			// 
			this.btnStudents.Location = new System.Drawing.Point(13, 28);
			this.btnStudents.Name = "btnStudents";
			this.btnStudents.Size = new System.Drawing.Size(75, 23);
			this.btnStudents.TabIndex = 0;
			this.btnStudents.Text = "Students";
			this.btnStudents.UseVisualStyleBackColor = true;
			this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
			// 
			// btnUnits
			// 
			this.btnUnits.Location = new System.Drawing.Point(13, 58);
			this.btnUnits.Name = "btnUnits";
			this.btnUnits.Size = new System.Drawing.Size(75, 23);
			this.btnUnits.TabIndex = 1;
			this.btnUnits.Text = "Units";
			this.btnUnits.UseVisualStyleBackColor = true;
			this.btnUnits.Click += new System.EventHandler(this.btnUnits_Click);
			// 
			// btnResults
			// 
			this.btnResults.Location = new System.Drawing.Point(13, 88);
			this.btnResults.Name = "btnResults";
			this.btnResults.Size = new System.Drawing.Size(75, 23);
			this.btnResults.TabIndex = 2;
			this.btnResults.Text = "Results";
			this.btnResults.UseVisualStyleBackColor = true;
			this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
			// 
			// btnResultSlip
			// 
			this.btnResultSlip.Location = new System.Drawing.Point(13, 118);
			this.btnResultSlip.Name = "btnResultSlip";
			this.btnResultSlip.Size = new System.Drawing.Size(75, 23);
			this.btnResultSlip.TabIndex = 3;
			this.btnResultSlip.Text = "Result Slip";
			this.btnResultSlip.UseVisualStyleBackColor = true;
			this.btnResultSlip.Click += new System.EventHandler(this.btnResultSlip_Click);
			// 
			// DashboardForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnResultSlip);
			this.Controls.Add(this.btnResults);
			this.Controls.Add(this.btnUnits);
			this.Controls.Add(this.btnStudents);
			this.Name = "DashboardForm";
			this.Text = "DashboardForm";
			this.Load += new System.EventHandler(this.DashboardForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnStudents;
		private System.Windows.Forms.Button btnUnits;
		private System.Windows.Forms.Button btnResults;
		private System.Windows.Forms.Button btnResultSlip;
	}
}