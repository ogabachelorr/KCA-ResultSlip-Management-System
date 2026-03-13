using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCAResultSlipManagementSystem.Helpers
{
	public static class GradeHelper
	{
		public static string GetGrade(decimal total)
		{
			if (total >= 70) return "A";
			if (total >= 60) return "B";
			if (total >= 50) return "C";
			if (total >= 40) return "D";
			return "E";
		}

		public static string GetRemark(decimal total)
		{
			return total >= 50 ? "Pass" : "Fail";
		}

		public static string GetOverallComment(decimal average)
		{
			if (average >= 70) return "Excellent Performance";
			if (average >= 60) return "Very Good Performance";
			if (average >= 50) return "Good Performance";
			if (average >= 40) return "Fair Performance";
			return "Poor Performance";
		}
	}
}
