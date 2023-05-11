namespace Multi_Formularios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string login = "johann";
            string pass = "123456";

            if(string.IsNullOrEmpty(txtLogin.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("ERRO!! Login e/ou senha devem ser preenchidos.");
                txtLogin.Text = "";
                txtSenha.Text = "";
                txtLogin.Focus();
                return;
            }

            if (txtLogin.Text == login && txtSenha.Text == pass)
            {
                MessageBox.Show("Seja bem-vindo!!");
                MDI_Principal frm = new MDI_Principal();
                frm.Show();
                //this.Close();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ERRO!! Usuário ou senha inválidos.");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}