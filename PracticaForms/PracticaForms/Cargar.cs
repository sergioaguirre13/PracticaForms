using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaForms
{
    public partial class Cargar : Form
    {
        Estudiantes nuevoEstudiante;

        public Estudiantes NuevoEstudiante { get => nuevoEstudiante;}

        public Cargar()
        {
            InitializeComponent();
        }
        private void Cargar_Load(object sender, EventArgs e)
        {
            cbxCarrera.DataSource = new List<string>() { "Programador", "Data Entry", "Security Source", "Beta Tester" };
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txbNombre.Text;
            string apellido = txbApellido.Text;
            string carrera = cbxCarrera.Text;
            string turno = string.Empty;
            List<string> materias = new List<string>();

            foreach (RadioButton radio in gbxTurno.Controls)
            {
                if (radio.Checked)
                {
                    turno = radio.Text;
                    break;
                }
            }

            foreach (CheckBox box in gbxMaterias.Controls)
            {
                if (box.Checked)
                {
                    materias.Add(box.Text);
                }
            }

            if (string.IsNullOrEmpty(txbNombre.Text) || (string.IsNullOrEmpty(txbApellido.Text)))
            {
                MessageBox.Show("Te falto cargar el nombre o el apellido.");
            }

            else if (!materias.Any())
            {
                MessageBox.Show("Debe seleccionar algúna materia");
            }
            else if (!turno.Any())
            {
                MessageBox.Show("Debe seleccionar algúno de los turnos para inscribirse");
            }
            else
            {
                nuevoEstudiante = new Estudiantes(nombre, apellido, carrera, turno, materias);
                DialogResult = DialogResult.OK;
            }


          

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
