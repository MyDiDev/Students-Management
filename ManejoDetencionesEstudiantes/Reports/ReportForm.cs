using ManejoDetencionesEstudiantes.Reports.StudentsDetentions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoDetencionesEstudiantes.Reports
{
    public partial class ReportForm : Form
    {
        public ReportForm()
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            ReportTopDetentionsForm f = new ReportTopDetentionsForm();
            OpenForm(f);
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            ReportDetentionStudent f = new ReportDetentionStudent();
            OpenForm(f);
        }
    }
}
