namespace PracticaForms
{
    public partial class FormPrincipal : Form
    {
        List<Estudiantes> ListaEstudiantes;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            dgvListaEstudiantes.DataSource = null;
            dgvListaEstudiantes.DataSource = ListaEstudiantes;
        }
    }
}
