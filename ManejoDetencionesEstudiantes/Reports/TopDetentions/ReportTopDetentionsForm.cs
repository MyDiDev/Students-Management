using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace ManejoDetencionesEstudiantes.Reports.StudentsDetentions
{
    public partial class ReportTopDetentionsForm : Form
    {
        public ReportTopDetentionsForm()
        {
            InitializeComponent();
        }

        private void ReportDetentionsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetSchoolDB.TOP_DETENTIONS' table. You can move, or remove it, as needed.
            this.tOP_DETENTIONSTableAdapter.Fill(this.dataSetSchoolDB.TOP_DETENTIONS);

            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.PageWidth;
            this.reportViewer1.RefreshReport();
        }
    }
}
