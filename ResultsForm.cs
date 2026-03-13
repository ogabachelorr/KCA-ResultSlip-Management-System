using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using KCAResultSlipManagementSystem.DataAccess;
using KCAResultSlipManagementSystem.Helpers;

namespace KCAResultSlipManagementSystem
{
	public partial class ResultsForm : Form
	{
		DbHelper db = new DbHelper();
		decimal total = 0;
		string grade = "";
		string remark = "";

		public ResultsForm()
		{
			InitializeComponent();
			LoadStudents();
			LoadUnits();
			LoadResults();
		}

		private void LoadStudents()
		{
			using (SqlConnection conn = db.GetConnection())
			{
				string query = "SELECT StudentID, FullName FROM Students";
				SqlDataAdapter da = new SqlDataAdapter(query, conn);
				DataTable dt = new DataTable();
				da.Fill(dt);

				cmbStudent.DataSource = dt;
				cmbStudent.DisplayMember = "FullName";
				cmbStudent.ValueMember = "StudentID";
			}
		}

		private void LoadUnits()
		{
			using (SqlConnection conn = db.GetConnection())
			{
				string query = "SELECT UnitID, UnitName FROM Units";
				SqlDataAdapter da = new SqlDataAdapter(query, conn);
				DataTable dt = new DataTable();
				da.Fill(dt);

				cmbUnit.DataSource = dt;
				cmbUnit.DisplayMember = "UnitName";
				cmbUnit.ValueMember = "UnitID";
			}
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(txtCAT.Text) || string.IsNullOrWhiteSpace(txtExam.Text))
				{
					MessageBox.Show("Please enter both CAT and Exam marks.");
					return;
				}

				if (!decimal.TryParse(txtCAT.Text.Trim(), out decimal cat))
				{
					MessageBox.Show("CAT must be a valid number.");
					return;
				}

				if (!decimal.TryParse(txtExam.Text.Trim(), out decimal exam))
				{
					MessageBox.Show("Exam must be a valid number.");
					return;
				}

				if (cat < 0 || cat > 30)
				{
					MessageBox.Show("CAT marks must be between 0 and 30.");
					return;
				}

				if (exam < 0 || exam > 70)
				{
					MessageBox.Show("Exam marks must be between 0 and 70.");
					return;
				}

				total = cat + exam;
				grade = GradeHelper.GetGrade(total);
				remark = GradeHelper.GetRemark(total);

				lblTotal.Text = total.ToString("0.00");
				lblGrade.Text = grade;
				lblRemark.Text = remark;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Calculation error: " + ex.Message);
			}
		}

		private void btnSaveResult_Click_1(object sender, EventArgs e)
		{
			try
			{
				if (cmbStudent.SelectedValue == null || cmbUnit.SelectedValue == null)
				{
					MessageBox.Show("Please select a student and a unit.");
					return;
				}

				if (string.IsNullOrWhiteSpace(txtCAT.Text) || string.IsNullOrWhiteSpace(txtExam.Text))
				{
					MessageBox.Show("Please enter both CAT and Exam marks.");
					return;
				}

				if (!decimal.TryParse(txtCAT.Text.Trim(), out decimal cat))
				{
					MessageBox.Show("CAT must be a valid number.");
					return;
				}

				if (!decimal.TryParse(txtExam.Text.Trim(), out decimal exam))
				{
					MessageBox.Show("Exam must be a valid number.");
					return;
				}

				if (cat < 0 || cat > 30)
				{
					MessageBox.Show("CAT marks must be between 0 and 30.");
					return;
				}

				if (exam < 0 || exam > 70)
				{
					MessageBox.Show("Exam marks must be between 0 and 70.");
					return;
				}

				decimal totalMarks = cat + exam;
				string gradeValue = GradeHelper.GetGrade(totalMarks);
				string remarkValue = GradeHelper.GetRemark(totalMarks);

				using (SqlConnection conn = db.GetConnection())
				{
					conn.Open();

					string query = @"INSERT INTO Results(StudentID, UnitID, CAT, Exam, Grade, Remarks)
                             VALUES(@studentId, @unitId, @cat, @exam, @grade, @remarks)";

					SqlCommand cmd = new SqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@studentId", cmbStudent.SelectedValue);
					cmd.Parameters.AddWithValue("@unitId", cmbUnit.SelectedValue);
					cmd.Parameters.AddWithValue("@cat", cat);
					cmd.Parameters.AddWithValue("@exam", exam);
					cmd.Parameters.AddWithValue("@grade", gradeValue);
					cmd.Parameters.AddWithValue("@remarks", remarkValue);

					cmd.ExecuteNonQuery();
					MessageBox.Show("Result saved successfully.");
				}

				lblTotal.Text = totalMarks.ToString("0.00");
				lblGrade.Text = gradeValue;
				lblRemark.Text = remarkValue;

				LoadResults();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving result: " + ex.Message);
			}
		}

		private void LoadResults()
		{
			using (SqlConnection conn = db.GetConnection())
			{
				string query = @"
                    SELECT r.ResultID, s.FullName, u.UnitName, r.CAT, r.Exam,
                           (r.CAT + r.Exam) AS Total, r.Grade, r.Remarks
                    FROM Results r
                    INNER JOIN Students s ON r.StudentID = s.StudentID
                    INNER JOIN Units u ON r.UnitID = u.UnitID";

				SqlDataAdapter da = new SqlDataAdapter(query, conn);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dgvResults.DataSource = dt;
			}
		}

		
	

	}
	
}