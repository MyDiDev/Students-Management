namespace ManejoDetencionesEstudiantes.Reports.StudentsDetentions
{
    partial class ReportDetentionStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetSchoolDB = new ManejoDetencionesEstudiantes.Reports.DataSetSchoolDB();
            this.eSTUDIANTESDETENCIONESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSTUDIANTES_DETENCIONESTableAdapter = new ManejoDetencionesEstudiantes.Reports.DataSetSchoolDBTableAdapters.ESTUDIANTES_DETENCIONESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSchoolDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTUDIANTESDETENCIONESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.eSTUDIANTESDETENCIONESBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ManejoDetencionesEstudiantes.Reports.ReportDetentionStudents.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(889, 576);
            this.reportViewer1.TabIndex = 1;
            // 
            // dataSetSchoolDB
            // 
            this.dataSetSchoolDB.DataSetName = "DataSetSchoolDB";
            this.dataSetSchoolDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eSTUDIANTESDETENCIONESBindingSource
            // 
            this.eSTUDIANTESDETENCIONESBindingSource.DataMember = "ESTUDIANTES_DETENCIONES";
            this.eSTUDIANTESDETENCIONESBindingSource.DataSource = this.dataSetSchoolDB;
            // 
            // eSTUDIANTES_DETENCIONESTableAdapter
            // 
            this.eSTUDIANTES_DETENCIONESTableAdapter.ClearBeforeFill = true;
            // 
            // ReportDetentionStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 576);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportDetentionStudent";
            this.Text = "ReportDetentionStudent";
            this.Load += new System.EventHandler(this.ReportDetentionStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSchoolDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTUDIANTESDETENCIONESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetSchoolDB dataSetSchoolDB;
        private System.Windows.Forms.BindingSource eSTUDIANTESDETENCIONESBindingSource;
        private DataSetSchoolDBTableAdapters.ESTUDIANTES_DETENCIONESTableAdapter eSTUDIANTES_DETENCIONESTableAdapter;
    }
}