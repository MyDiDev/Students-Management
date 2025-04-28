namespace ManejoDetencionesEstudiantes.Reports.StudentsDetentions
{
    partial class ReportTopDetentionsForm
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
            this.formPanel = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetSchoolDB = new ManejoDetencionesEstudiantes.Reports.DataSetSchoolDB();
            this.tOPDETENTIONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tOP_DETENTIONSTableAdapter = new ManejoDetencionesEstudiantes.Reports.DataSetSchoolDBTableAdapters.TOP_DETENTIONSTableAdapter();
            this.formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSchoolDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOPDETENTIONSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.formPanel.Controls.Add(this.reportViewer1);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.Location = new System.Drawing.Point(0, 0);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(889, 576);
            this.formPanel.TabIndex = 7;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tOPDETENTIONSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ManejoDetencionesEstudiantes.Reports.ReportTopStudents.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(889, 576);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetSchoolDB
            // 
            this.dataSetSchoolDB.DataSetName = "DataSetSchoolDB";
            this.dataSetSchoolDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tOPDETENTIONSBindingSource
            // 
            this.tOPDETENTIONSBindingSource.DataMember = "TOP_DETENTIONS";
            this.tOPDETENTIONSBindingSource.DataSource = this.dataSetSchoolDB;
            // 
            // tOP_DETENTIONSTableAdapter
            // 
            this.tOP_DETENTIONSTableAdapter.ClearBeforeFill = true;
            // 
            // ReportTopDetentionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 576);
            this.Controls.Add(this.formPanel);
            this.Name = "ReportTopDetentionsForm";
            this.Text = "ReportDetentionsForm";
            this.Load += new System.EventHandler(this.ReportDetentionsForm_Load);
            this.formPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSchoolDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOPDETENTIONSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formPanel;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetSchoolDB dataSetSchoolDB;
        private System.Windows.Forms.BindingSource tOPDETENTIONSBindingSource;
        private DataSetSchoolDBTableAdapters.TOP_DETENTIONSTableAdapter tOP_DETENTIONSTableAdapter;
    }
}