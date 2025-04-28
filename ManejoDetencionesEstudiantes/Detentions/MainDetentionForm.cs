using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoDetencionesEstudiantes.Detentions
{
    public partial class MainDetentionForm : Form
    {
        public MainDetentionForm()
        {
            InitializeComponent();
        }

        private Detention detention = new Detention();

        private void RefreshDataSource() {
            detentionDataGridView.DataSource = detention.ConsultDetentions();
        }

        private void MainDetentionForm_Load(object sender, EventArgs e)
        {
            RefreshDataSource();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddDetentionForm f = new AddDetentionForm();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateDetentionForm f = new UpdateDetentionForm();
            f.ShowDialog();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (detentionDataGridView.SelectedRows.Count > 0)
            {
                int id  = Convert.ToInt32(detentionDataGridView.SelectedRows[0].Cells["id"].Value);
                detention.RemoveDetention(id);
                MessageBox.Show("Detencion Eliminada Exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDataSource();
                return;
            }

            MessageBox.Show("Seleccione Un Registro a Eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (detentionDataGridView.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(detentionDataGridView.SelectedRows[0].Cells["id"].Value);
                
                UpdateDetentionForm f = new UpdateDetentionForm();

                f.id = id;
                f.id_student = Convert.ToInt32(detentionDataGridView.SelectedRows[0].Cells["id_estudiante"].Value);
                f.reason = detentionDataGridView.SelectedRows[0].Cells["motivo"].Value.ToString();
                f.typeDetention = detentionDataGridView.SelectedRows[0].Cells["tipo_detencion"].Value.ToString();
                f.state = detentionDataGridView.SelectedRows[0].Cells["estado"].Value.ToString();
                f.grade = detentionDataGridView.SelectedRows[0].Cells["curso_estudiante"].Value.ToString();
                f.numDetention = Convert.ToInt32(detentionDataGridView.SelectedRows[0].Cells["numero_detenciones"].Value);
                f.date = Convert.ToDateTime(detentionDataGridView.SelectedRows[0].Cells["fecha"].Value);

                f.ShowDialog();
                RefreshDataSource();
                return;
            }

            MessageBox.Show("Seleccione Un Registro a Eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }
}
