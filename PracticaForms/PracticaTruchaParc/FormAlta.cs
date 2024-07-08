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
            
        }
    }
}
