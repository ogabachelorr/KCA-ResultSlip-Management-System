namespace KCAResultSlipManagementSystem
{
	partial class UnitsForm
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
			this.txtUnitCode = new System.Windows.Forms.TextBox();
			this.txtUnitName = new System.Windows.Forms.TextBox();
			this.txtCreditHours = new System.Windows.Forms.TextBox();
			this.btnSaveUnit = new System.Windows.Forms.Button();
			this.dgvUnits = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).BeginInit();
			this.SuspendLayout();
			// 
			// txtUnitCode
			// 
			this.txtUnitCode.Location = new System.Drawing.Point(130, 30);
			this.txtUnitCode.Name = "txtUnitCode";
			this.txtUnitCode.Size = new System.Drawing.Size(100, 20);
			this.txtUnitCode.TabIndex = 0;
			// 
			// txtUnitName
			// 
			this.txtUnitName.Location = new System.Drawing.Point(130, 67);
			this.txtUnitName.Name = "txtUnitName";
			this.txtUnitName.Size = new System.Drawing.Size(100, 20);
			this.txtUnitName.TabIndex = 1;
			// 
			// txtCreditHours
			// 
			this.txtCreditHours.Location = new System.Drawing.Point(130, 104);
			this.txtCreditHours.Name = "txtCreditHours";
			this.txtCreditHours.Size = new System.Drawing.Size(100, 20);
			this.txtCreditHours.TabIndex = 2;
			// 
			// btnSaveUnit
			// 
			this.btnSaveUnit.Location = new System.Drawing.Point(63, 146);
			this.btnSaveUnit.Name = "btnSaveUnit";
			this.btnSaveUnit.Size = new System.Drawing.Size(75, 23);
			this.btnSaveUnit.TabIndex = 3;
			this.btnSaveUnit.Text = "Save Unit";
			this.btnSaveUnit.UseVisualStyleBackColor = true;
			this.btnSaveUnit.Click += new System.EventHandler(this.btnSaveUnit_Click);
			// 
			// dgvUnits
			// 
			this.dgvUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUnits.Location = new System.Drawing.Point(31, 184);
			this.dgvUnits.Name = "dgvUnits";
			this.dgvUnits.Size = new System.Drawing.Size(240, 150);
			this.dgvUnits.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Unit Code";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(31, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Unit Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(34, 110);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Credit Hours";
			// 
			// UnitsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvUnits);
			this.Controls.Add(this.btnSaveUnit);
			this.Controls.Add(this.txtCreditHours);
			this.Controls.Add(this.txtUnitName);
			this.Controls.Add(this.txtUnitCode);
			this.Name = "UnitsForm";
			this.Text = "UnitsForm";
			this.Load += new System.EventHandler(this.UnitsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtUnitCode;
		private System.Windows.Forms.TextBox txtUnitName;
		private System.Windows.Forms.TextBox txtCreditHours;
		private System.Windows.Forms.Button btnSaveUnit;
		private System.Windows.Forms.DataGridView dgvUnits;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}