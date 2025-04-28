using Logiv;
using ManejoDetencionesEstudiantes.Reports.DataSetSchoolDBTableAdapters;
using ManejoDetencionesEstudiantes.Students;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoDetencionesEstudiantes
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private Student student = new Student();

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddStudentForm f = new AddStudentForm();
            f.ShowDialog();
            ReloadDataSource();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (estudiantesDataGridView.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(estudiantesDataGridView.SelectedRows[0].Cells["id"].Value);
                UpdateStudentForm f = new UpdateStudentForm();
                
                f.id = id;
                f.studentName = estudiantesDataGridView.SelectedRows[0].Cells["nombre"].Value.ToString();
                f.studentPlate = estudiantesDataGridView.SelectedRows[0].Cells["matricula"].Value.ToString();
                f.Age = Convert.ToInt32(estudiantesDataGridView.SelectedRows[0].Cells["edad"].Value);
                f.studentPhone = estudiantesDataGridView.SelectedRows[0].Cells["telefono"].Value.ToString();

                f.ShowDialog();
                ReloadDataSource();
                return;
            }

            MessageBox.Show("Seleccione Un Registro para Actualizar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;

        }

        private void ReloadDataSource()
        {
            estudiantesDataGridView.DataSource = student.GetStudents();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            ReloadDataSource();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (estudiantesDataGridView.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(estudiantesDataGridView.SelectedRows[0].Cells["id"].Value);
                student.RemoveStudent(id);
                MessageBox.Show($"Registro Eliminado, N.O: {id}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ReloadDataSource();
                return;
            }

            MessageBox.Show("Seleccione Un Registro para Eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
    }
}
