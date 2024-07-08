namespace PracticaTruchaParc
{
    public partial class FormPrincipal : Form
    {
        List<Computadora> computadoraList;
        public FormPrincipal()
        {
            InitializeComponent();
            computadoraList = new List<Computadora>();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAlta alta = new FormAlta();
            alta.ShowDialog();


        }

        private void ActualizarLista()
        {
            dtgListaComputadora.DataSource = null;
            dtgListaComputadora.DataSource = computadoraList;

        }
    }
}
