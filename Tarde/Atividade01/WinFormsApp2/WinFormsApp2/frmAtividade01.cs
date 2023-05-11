namespace WinFormsApp2
{
    public partial class frmAtividade01 : Form
    {
        public frmAtividade01()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtNome.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            txtNomeCopia.Text = txtNome.Text;
            btnLimpar.PerformClick();
        }

        private void frmAtividade01_Load(object sender, EventArgs e)
        {

        }
    }
}