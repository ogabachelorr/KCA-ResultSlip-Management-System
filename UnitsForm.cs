using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using KCAResultSlipManagementSystem.DataAccess;

namespace KCAResultSlipManagementSystem
{
	public partial class UnitsForm : Form
	{
		DbHelper db = new DbHelper();

		public UnitsForm()
		{
			InitializeComponent();
			LoadUnits();
		}

		private void UnitsForm_Load(object sender, EventArgs e)
		{
			LoadUnits();
		}

		private void btnSaveUnit_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(txtUnitCode.Text) ||
					string.IsNullOrWhiteSpace(txtUnitName.Text) ||
					string.IsNullOrWhiteSpace(txtCreditHours.Text))
				{
					MessageBox.Show("Please fill in all fields.");
					return;
				}

				if (!int.TryParse(txtCreditHours.Text.Trim(), out int creditHours))
				{
					MessageBox.Show("Credit hours must be a number.");
					return;
				}

				using (SqlConnection conn = db.GetConnection())
				{
					conn.Open();

					string checkQuery = "SELECT COUNT(*) FROM Units WHERE UnitCode = @code";
					SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
					checkCmd.Parameters.AddWithValue("@code", txtUnitCode.Text.Trim());

					int exists = (int)checkCmd.ExecuteScalar();

					if (exists > 0)
					{
						MessageBox.Show("This unit code already exists.");
						return;
					}

					string query = @"INSERT INTO Units(UnitCode, UnitName, CreditHours)
                                     VALUES(@code, @name, @credit)";

					SqlCommand cmd = new SqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@code", txtUnitCode.Text.Trim());
					cmd.Parameters.AddWithValue("@name", txtUnitName.Text.Trim());
					cmd.Parameters.AddWithValue("@credit", creditHours);

					cmd.ExecuteNonQuery();
					MessageBox.Show("Unit saved successfully.");
				}

				ClearFields();
				LoadUnits();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving unit: " + ex.Message);
			}
		}

		private void LoadUnits()
		{
			try
			{
				using (SqlConnection conn = db.GetConnection())
				{
					string query = "SELECT UnitID, UnitCode, UnitName, CreditHours FROM Units";
					SqlDataAdapter da = new SqlDataAdapter(query, conn);
					DataTable dt = new DataTable();
					da.Fill(dt);

					dgvUnits.DataSource = null;
					dgvUnits.DataSource = dt;
					dgvUnits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading units: " + ex.Message);
			}
		}

		private void ClearFields()
		{
			txtUnitCode.Clear();
			txtUnitName.Clear();
			txtCreditHours.Clear();
		}
	}
}