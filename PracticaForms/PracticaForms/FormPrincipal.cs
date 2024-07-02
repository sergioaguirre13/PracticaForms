namespace PracticaForms
{
    public partial class FormPrincipal : Form
    {
        List<Estudiantes> ListaEstudiantes;
        public FormPrincipal()
        {
            ListaEstudiantes = new List<Estudiantes>();
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CargarListaEstudiantes();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cargar formCargar = new Cargar();
            formCargar.ShowDialog();

            if (formCargar.DialogResult == DialogResult.OK)
            {
                ListaEstudiantes.Add(formCargar.NuevoEstudiante);
                CargarListaEstudiantes();
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ListaEstudiantes.RemoveAt(ListaEstudiantes.Count - 1);
            CargarListaEstudiantes();

        }


        private void CargarListaEstudiantes()
        {
            dgvListaEstudiantes.DataSource = null;
            dgvListaEstudiantes.DataSource = ListaEstudiantes;
        }

        
    }
}
