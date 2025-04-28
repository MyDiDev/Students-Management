using Logiv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoDetencionesEstudiantes.Students
{
    public partial class UpdateStudentForm : Form
    {
        public UpdateStudentForm()
        {
            InitializeComponent();
        }

        public int id;
        public string studentName;
        public string studentPlate;
        public string studentPhone;
        public int Age;

        private void modBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameBox.Text) || string.IsNullOrEmpty(matriculaBox.Text) || string.IsNullOrEmpty(phoneBox.Text) || string.IsNullOrEmpty(edadBox.Text))
            {
                MessageBox.Show("Llene El Formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int age = 0;

            try
            {
                age = Convert.ToInt32(edadBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa Una Edad Valida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Student student = new Student(nameBox.Text, matriculaBox.Text, age, phoneBox.Text);
            student.ModifiyStudent(id);
            MessageBox.Show("Estudiante Actualizado Exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void UpdateStudentForm_Load(object sender, EventArgs e)
        {
            nameBox.Text = studentName;
            matriculaBox.Text = studentPlate;
            edadBox.Text = Age.ToString();
            phoneBox.Text = studentPhone;
        }
    }
}
