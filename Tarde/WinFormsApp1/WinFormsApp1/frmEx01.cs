namespace WinFormsApp1
{
    public partial class frmEx01 : Form
    {
        public frmEx01()
        {
            InitializeComponent();
        }

        private void frmEx01_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //é o botão de sair btnSair
        {
            Application.Exit(); // sai da aplicação
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e) //botão limpar
        {
            txtNome.Text = ""; //deixa o campo txtNome em branco
            txtNome.Focus(); //deixa o focus no txtNome
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //é o campo txtNome
        {

        }

        private void btnOK_Click(object sender, EventArgs e) //é o método do botão do OK
        {
            MessageBox.Show("O nome da pessoa é: " + txtNome.Text); //mostra uma mensagem do campo txtNome
            btnLimpar.PerformClick(); //executa o código do botão btnLimpar
        }
    }
}