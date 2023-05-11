namespace WinFormsApp1
{
    public partial class frmAtividade04 : Form
    {
        public frmAtividade04()
        {
            InitializeComponent();
        }

        //Vari�veis
        int n1;
        string mensagem;

        bool Verificador()
        {
            if((int.TryParse(txtN1.Text, out n1) == false) || txtN1.Text == "")
            {
                mensagem = "ERRO! Informe um valor num�rico para N1";
                txtN1.Text = "";
                txtN1.Focus();
                return false;
            }
            return true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            if (Verificador())
            {
                if (n1>50)
                {
                    txtResult.Text = "N1 � maior que 50";
                }
                else if (n1 < 50)
                {
                    txtResult.Text = "N1 � menor que 50";
                }
                else
                {
                    txtResult.Text = "N1 � igual a 50";
                }
            }
            else
            {
                MessageBox.Show(mensagem);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}