namespace WinFormsApp1
{
    public partial class frmAtividade01 : Form
    {
        public frmAtividade01()
        {
            InitializeComponent();
        }

        //Variáveis
        float n1;
        float n2;
        float porc;
        float result;
        string mensagem;

        bool Verificador()
        {
            if((float.TryParse(txtN1.Text, out n1) == false) || (txtN1.Text == ""))
            {
                mensagem = "Erro!! Informe um valor válido para N1.";
                txtN1.Text = "";
                txtN1.Focus();
                return false;
            }
            if((float.TryParse(txtN2.Text, out n2) == false) || (txtN2.Text == ""))
            {
                mensagem = "Erro!! Informe um valor válido para N2.";
                txtN2.Text = "";
                txtN2.Focus();
                return false;
            }
            return true;
        }

        bool VerificadorPorc()
        {
            if ((float.TryParse(txtPorcentagem.Text, out porc) == false) || (txtPorcentagem.Text == ""))
            {
                mensagem = "Erro!! Informe um valor válido para a porcentagem.";
                txtPorcentagem.Text = "";
                txtPorcentagem.Focus();
                return false;
            }
            return true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
            txtN2.Text = "";
            txtPorcentagem.Text = "";
            lblResult.Text = "0";
            txtN1.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            lblResult.Text = "0";
            if (Verificador())
            {
                result = n1 + n2;

                lblResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show(mensagem);
            }

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            lblResult.Text = "0";
            if (Verificador())
            {
                result = n1 - n2;

                lblResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show(mensagem);
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            lblResult.Text = "0";
            if (Verificador())
            {
                result = n1 * n2;

                lblResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show(mensagem);
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            lblResult.Text = "0";
            if (Verificador())
            {
                if(n2 == 0)
                {
                    MessageBox.Show("Erro!! N2 não pode ser 0 na divisão.");
                    return;
                }
                result = n1 / n2;

                lblResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show(mensagem);
            }
        }

        private void btnJuros_Click(object sender, EventArgs e)
        {
            lblResult.Text = "0";
            if (Verificador() && VerificadorPorc())
            {
                result = n1 + n2;
                result = result * (1 + (porc / 100));

                lblResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show(mensagem);
            }
        }

        private void btnDesconto_Click(object sender, EventArgs e)
        {
            lblResult.Text = "0";
            if (Verificador() && VerificadorPorc())
            {
                result = n1 + n2;
                result = result * (1 - (porc / 100));

                lblResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show(mensagem);
            }
        }
    }
}