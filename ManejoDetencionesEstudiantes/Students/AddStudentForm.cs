using Logiv;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoDetencionesEstudiantes
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private Student student;

        private void addBtn_Click(object sender, EventArgs e)
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
                if (age >= 18 || age <= 13)
                {
                    MessageBox.Show("Ingresa Una Edad Valida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }catch (FormatException)
            {
                MessageBox.Show("Ingresa Una Edad Valida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            student = new Student(nameBox.Text, matriculaBox.Text, age, phoneBox.Text);
            student.AddStudent();
            MessageBox.Show("Estudiante Registrado Exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            foreach (var control in this.Controls)
            {
                if (control is TextBox textbox)
                {
                    textbox.Clear();
                }
            }
        }
    }
}
