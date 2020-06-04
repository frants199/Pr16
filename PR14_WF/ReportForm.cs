using System;
using System.Windows.Forms;

namespace PR14_WF
{
	public partial class ReportForm : Form
	{
		public ReportForm()
		{
			InitializeComponent();
		}

		private void ReportForm_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "StudentsDataSet.students". При необходимости она может быть перемещена или удалена.
			this.studentsTableAdapter.Fill(this.StudentsDataSet.students);
			this.reportViewer1.RefreshReport();
		}
	}
}
