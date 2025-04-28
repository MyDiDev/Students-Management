using Azure.Core;
using Logic;
using Logiv;
using System;
using System.Windows.Forms;

namespace ManejoDetencionesEstudiantes.Detentions
{
    public partial class AddDetentionForm : Form
    {
        public AddDetentionForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(estudianteBox.Text) || string.IsNullOrEmpty(typeDetentionBox.Text) ||  string.IsNullOrEmpty(gradeBox.Text) || 
                string.IsNullOrEmpty(stateBox.Text) || string.IsNullOrEmpty(matriculaBox.Text) || string.IsNullOrEmpty(detentionReason.Text))
            {
                MessageBox.Show("Asegurese de Llenar todo el Formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Student student = new Student(estudianteBox.Text, matriculaBox.Text);
            int idStudent = student.GetId();
            Detention detention = new Detention(idStudent, detentionReason.Text, typeDetentionBox.Text, stateBox.Text, gradeBox.Text, (int)detentionAmount.Value, detentionDate.Value);
            
            detention.NewDetention();
            MessageBox.Show("Detencion Agregada Exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void estudianteBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student(estudianteBox.Text, matriculaBox.Text);
                foreach (string plate in student.GetPlates())
                {
                    matriculaBox.Items.Add(plate);
                }

                if (matriculaBox.Items.Count == 0)
                {
                    plateErrMsg.Text = "(Ingrese un Estudiante Registrado)";
                    return;
                }

                plateErrMsg.Text = "";
            }
            catch (Exception)
            {
                plateErrMsg.Text = "(Ingrese un Estudiante Registrado)";
                return;
            }
        }
    }
}
