using Logic;
using Logiv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoDetencionesEstudiantes.Detentions
{
    public partial class UpdateDetentionForm : Form
    {
        public UpdateDetentionForm()
        {
            InitializeComponent();
        }

        private Student student;

        public int id;
        public int id_student;
        public string reason;
        public string typeDetention;
        public string state;
        public string grade;
        public int numDetention;
        public DateTime date;

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(estudianteBox.Text) || string.IsNullOrEmpty(typeDetentionBox.Text) || string.IsNullOrEmpty(gradeBox.Text) ||
                string.IsNullOrEmpty(stateBox.Text) || string.IsNullOrEmpty(matriculaBox.Text) || string.IsNullOrEmpty(detentionReason.Text))
            {
                MessageBox.Show("Asegurese de Llenar todo el Formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Detention detention = new Detention(id_student, detentionReason.Text, typeDetentionBox.Text, stateBox.Text, gradeBox.Text, (int)detentionAmount.Value, detentionDate.Value);

            detention.ModifyDetencion(id);
            MessageBox.Show("Detencion Actualizada Exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void estudianteBox_TextChanged(object sender, EventArgs e)
        {
            Student student = new Student(estudianteBox.Text);

            try
            {
                foreach (string plate in student.GetPlates())
                {
                    matriculaBox.Items.Add(plate);
                }

                if (matriculaBox.Items.Count == 0)
                {
                    return;
                }
            }catch (Exception)
            {
                return;
            }
        }

        private void UpdateDetentionForm_Load(object sender, EventArgs e)
        {
            Student student = new Student(estudianteBox.Text);

            estudianteBox.Text = student.getName(id_student);
            typeDetentionBox.Text = typeDetention;
            gradeBox.Text = grade;
            stateBox.Text = state;
            detentionAmount.Value = numDetention;
            detentionReason.Text = reason;
            detentionDate.Value = date;

            foreach (string plate in student.GetPlates())
            {
                matriculaBox.Items.Add(plate);
            }

        }
    }
}
