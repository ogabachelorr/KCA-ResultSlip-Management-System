using System.Configuration;
using System.Data.SqlClient;

namespace KCAResultSlipManagementSystem.DataAccess
{
	public class DbHelper
	{
		private readonly string connectionString;

		public DbHelper()
		{
			connectionString = ConfigurationManager.ConnectionStrings["KCAResultSlipDB"].ConnectionString;
		}

		public SqlConnection GetConnection()
		{
			return new SqlConnection(connectionString);
		}
	}
}
