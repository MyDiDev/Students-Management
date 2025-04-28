using ManejoDetencionesEstudiantes.Detentions;
using ManejoDetencionesEstudiantes.Reports;
using System;
using System.Windows.Forms;

namespace ManejoDetencionesEstudiantes
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Form openForm = null;
        private void OpenForm(Form form)
        {
            if (!(openForm is null))
            {
                formPanel.Controls.Remove(openForm);
                formPanel.Controls.Clear();
            }

            openForm = form;
            form.TopLevel = false;
            form.Tag = formPanel.Tag;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Size = formPanel.Size;
            form.Dock = DockStyle.Fill;
            formPanel.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void estudiantesBtn_Click(object sender, EventArgs e)
        {
            StudentForm f = new StudentForm();
            OpenForm(f);
        }

        private void detencionesBtn_Click(object sender, EventArgs e)
        {
            MainDetentionForm f = new MainDetentionForm();
            OpenForm(f);
        }

        private void reportesBtn_Click(object sender, EventArgs e)
        {
            ReportForm f = new ReportForm();
            OpenForm(f);
        }
    }
}
