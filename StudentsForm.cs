using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using KCAResultSlipManagementSystem.DataAccess;

namespace KCAResultSlipManagementSystem
{
	public partial class StudentsForm : Form
	{
		DbHelper db = new DbHelper();

		public StudentsForm()
		{
			InitializeComponent();
			LoadStudents();
		}
		private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
		{
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtRegNo.Text) ||
				string.IsNullOrWhiteSpace(txtFullName.Text) ||
				string.IsNullOrWhiteSpace(cmbGender.Text) ||
				string.IsNullOrWhiteSpace(txtCourse.Text) ||
				string.IsNullOrWhiteSpace(txtDepartment.Text) ||
				string.IsNullOrWhiteSpace(txtSemester.Text) ||
				string.IsNullOrWhiteSpace(txtAcademicYear.Text))
			{
				MessageBox.Show("Please fill in all fields.");
				return;
			}

			using (SqlConnection conn = db.GetConnection())
			{
				conn.Open();

				string checkQuery = "SELECT COUNT(*) FROM Students WHERE RegNo = @RegNo";
				SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
				checkCmd.Parameters.AddWithValue("@RegNo", txtRegNo.Text.Trim());

				int exists = (int)checkCmd.ExecuteScalar();

				if (exists > 0)
				{
					MessageBox.Show("This registration number already exists. Use a different RegNo.");
					return;
				}

				string query = @"INSERT INTO Students
                        (RegNo, FullName, Gender, Course, Department, Semester, AcademicYear)
                        VALUES
                        (@RegNo, @FullName, @Gender, @Course, @Department, @Semester, @AcademicYear)";

				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@RegNo", txtRegNo.Text.Trim());
				cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim());
				cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
				cmd.Parameters.AddWithValue("@Course", txtCourse.Text.Trim());
				cmd.Parameters.AddWithValue("@Department", txtDepartment.Text.Trim());
				cmd.Parameters.AddWithValue("@Semester", txtSemester.Text.Trim());
				cmd.Parameters.AddWithValue("@AcademicYear", txtAcademicYear.Text.Trim());

				cmd.ExecuteNonQuery();
				MessageBox.Show("Student saved successfully.");
			}

			ClearFields();
			LoadStudents();
		}

		private void LoadStudents()
		{
			try
			{
				using (SqlConnection conn = db.GetConnection())
				{
					string query = "SELECT StudentID, RegNo, FullName, Gender, Course, Department, Semester, AcademicYear FROM Students";
					SqlDataAdapter da = new SqlDataAdapter(query, conn);
					DataTable dt = new DataTable();
					da.Fill(dt);

					dgvStudents.DataSource = null;
					dgvStudents.DataSource = dt;
					dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading students: " + ex.Message);
			}
		}
		private void ClearFields()
		{
			txtRegNo.Clear();
			txtFullName.Clear();
			cmbGender.SelectedIndex = -1;
			txtCourse.Clear();
			txtDepartment.Clear();
			txtSemester.Clear();
			txtAcademicYear.Clear();
		}
	}
}