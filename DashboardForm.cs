using System;
using System.Windows.Forms;

namespace KCAResultSlipManagementSystem
{
	public partial class DashboardForm : Form
	{
		public DashboardForm()
		{
			InitializeComponent();
		}
		private void DashboardForm_Load(object sender, EventArgs e)
		{
		}

		private void btnStudents_Click(object sender, EventArgs e)
		{
			StudentsForm form = new StudentsForm();
			form.ShowDialog();
		}

		private void btnUnits_Click(object sender, EventArgs e)
		{
			UnitsForm form = new UnitsForm();
			form.ShowDialog();
		}

		private void btnResults_Click(object sender, EventArgs e)
		{
			ResultsForm form = new ResultsForm();
			form.ShowDialog();
		}

		private void btnResultSlip_Click(object sender, EventArgs e)
		{
			ResultSlipForm form = new ResultSlipForm();
			form.ShowDialog();
		}
	}
}
