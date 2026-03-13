using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using KCAResultSlipManagementSystem.DataAccess;
using KCAResultSlipManagementSystem.Helpers;

namespace KCAResultSlipManagementSystem
{
	public partial class ResultSlipForm : Form
	{
		DbHelper db = new DbHelper();

		public ResultSlipForm()
		{
			InitializeComponent();
		}

		private void ResultSlipForm_Load(object sender, EventArgs e)
		{
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			try
			{
				string regNo = txtSearchRegNo.Text.Trim();

				if (string.IsNullOrWhiteSpace(regNo))
				{
					MessageBox.Show("Please enter a registration number.");
					return;
				}

				LoadResultSlip(regNo);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Search error: " + ex.Message);
			}
		}

		private void LoadResultSlip(string regNo)
		{
			try
			{
				using (SqlConnection conn = db.GetConnection())
				{
					string query = @"
                        SELECT s.RegNo, s.FullName, s.Course, s.Semester, s.AcademicYear,
                               u.UnitCode, u.UnitName, r.CAT, r.Exam, (r.CAT + r.Exam) AS Total, r.Grade, r.Remarks
                        FROM Results r
                        INNER JOIN Students s ON r.StudentID = s.StudentID
                        INNER JOIN Units u ON r.UnitID = u.UnitID
                        WHERE s.RegNo = @RegNo";

					SqlCommand cmd = new SqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@RegNo", regNo);

					SqlDataAdapter da = new SqlDataAdapter(cmd);
					DataTable dt = new DataTable();
					da.Fill(dt);

					if (dt.Rows.Count > 0)
					{
						dgvSlip.DataSource = null;
						dgvSlip.DataSource = dt;
						dgvSlip.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

						lblRegNo.Text = dt.Rows[0]["RegNo"].ToString();
						lblName.Text = dt.Rows[0]["FullName"].ToString();
						lblCourse.Text = dt.Rows[0]["Course"].ToString();
						lblSemester.Text = dt.Rows[0]["Semester"].ToString();
						lblAcademicYear.Text = dt.Rows[0]["AcademicYear"].ToString();

						decimal average = CalculateAverage(regNo);
						lblAverage.Text = average.ToString("0.00");
						lblComment.Text = GradeHelper.GetOverallComment(average);
					}
					else
					{
						dgvSlip.DataSource = null;
						lblRegNo.Text = "";
						lblName.Text = "";
						lblCourse.Text = "";
						lblSemester.Text = "";
						lblAcademicYear.Text = "";
						lblAverage.Text = "";
						lblComment.Text = "";

						MessageBox.Show("No result slip found for this registration number.");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading result slip: " + ex.Message);
			}
		}

		private decimal CalculateAverage(string regNo)
		{
			using (SqlConnection conn = db.GetConnection())
			{
				string query = @"
                    SELECT AVG(CAST((r.CAT + r.Exam) AS DECIMAL(5,2)))
                    FROM Results r
                    INNER JOIN Students s ON r.StudentID = s.StudentID
                    WHERE s.RegNo = @RegNo";

				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@RegNo", regNo);

				conn.Open();
				object result = cmd.ExecuteScalar();

				return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
			}
		}
	}
}