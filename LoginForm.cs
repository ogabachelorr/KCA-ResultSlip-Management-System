using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using KCAResultSlipManagementSystem.DataAccess;

namespace KCAResultSlipManagementSystem
{
	public partial class LoginForm : Form
	{
		DbHelper db = new DbHelper();

		public LoginForm()
		{
			InitializeComponent();
			txtPassword.UseSystemPasswordChar = true;
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			try
			{
				using (SqlConnection conn = db.GetConnection())
				{
					string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND PasswordHash = @password";

					SqlCommand cmd = new SqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
					cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());

					conn.Open();
					int count = (int)cmd.ExecuteScalar();

					if (count > 0)
					{
						MessageBox.Show("Login successful.");

						DashboardForm dashboard = new DashboardForm();
						dashboard.Show();
						this.Hide();
					}
					else
					{
						MessageBox.Show("Invalid username or password.");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Login error: " + ex.Message);
			}
		}
	}
}
