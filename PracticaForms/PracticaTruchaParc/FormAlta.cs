using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaTruchaParc
{
    public partial class FormAlta : Form
    {
        Computadora nuevaComputadora;

        public Computadora NuevaComputadora { get => nuevaComputadora; }
        public FormAlta()
        {
            InitializeComponent();
            cbxProcesador.DataSource = Computadora.ListadoDeProcesadores();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string procesador = cbxProcesador.Text;
            int memoriaRam = (int)numericRam.Value;
            int capacidadDisco = (int)numericDisco.Value;
            string sistemaOperativo = string.Empty;

            foreach (RadioButton radio in gbxSistemaOperativo.Controls)
            {
                if (radio.Checked)
                {
                    sistemaOperativo = radio.Text;
                    break;
                }
            }

            nuevaComputadora = new Computadora(capacidadDisco, memoriaRam, procesador, sistemaOperativo);
            foreach (CheckBox box in gbxProgramas.Controls)
            {
                if (box.Checked)
                {
                    nuevaComputadora.SetPrograma(box.Text);
                }
            }
            DialogResult = DialogResult.OK;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
