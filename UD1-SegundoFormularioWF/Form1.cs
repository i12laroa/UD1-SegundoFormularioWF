using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UD1_EjemploEnlaceDatos;

namespace UD1_SegundoFormularioWF
{
    public partial class Form1 : Form
    {
        private Form student, teacher, family;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbAlumnos.Checked)
                {
                /* fue cerrado y destruido (IsDisposed == true)
                 * o nunca se ha creado (student == null)
                 */
                if (student == null || student.IsDisposed)
                {
                    student = new FormAlumno();
                    student.Show();
                }
                else
                {
                    student.BringToFront();
                }
            }
            else if (rbProfes.Checked)
            {
                if (teacher == null || teacher.IsDisposed)
                {
                    teacher = new FormProfes();
                    teacher.Show();
                }
                else
                {
                    teacher.BringToFront();
                }
            }
            else if (rbFamilia.Checked)
            {
                if (family == null || family.IsDisposed)
                {
                    family = new UD1_EjemploEnlaceDatos.Form1();
                    family.Show();
                }
                else
                {
                    family.BringToFront();
                }
            }
        }
    }
}
