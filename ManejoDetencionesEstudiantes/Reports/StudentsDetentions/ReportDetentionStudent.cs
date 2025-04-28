using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoDetencionesEstudiantes.Reports.StudentsDetentions
{
    public partial class ReportDetentionStudent : Form
    {
        public ReportDetentionStudent()
        {
            InitializeComponent();
        }

        private void ReportDetentionStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetSchoolDB.ESTUDIANTES_DETENCIONES' table. You can move, or remove it, as needed.
            this.eSTUDIANTES_DETENCIONESTableAdapter.Fill(this.dataSetSchoolDB.ESTUDIANTES_DETENCIONES);

            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.reportViewer1.RefreshReport();
        }
    }
}
