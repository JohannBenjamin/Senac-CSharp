namespace WinFormsApp2
{
    public partial class frmAtividade02 : Form
    {
        public frmAtividade02()
        {
            InitializeComponent();
        }

        //variáveis
        String Mensagem;
        float teste;

        bool Verificador()
        {
            if(txtNome.Text == "" || float.TryParse(txtNome.Text, out teste))
            {
                txtNome.Focus();
                Mensagem = "Informe um Nome válido!!";
                return false;
            }
            if(txtSobrenome.Text == "" || float.TryParse(txtSobrenome.Text, out teste))
            {
                txtSobrenome.Focus();
                Mensagem = "Informe um Sobrenome válido!!";
                return false;
            }
            return true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            txtCompleto.Text = "";

            if(Verificador())
            {
                txtCompleto.Text = txtNome.Text + " " + txtSobrenome.Text;
            }
            else
            {
                MessageBox.Show(Mensagem);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtCompleto.Text = "";
            txtNome.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}