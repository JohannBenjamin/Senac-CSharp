namespace WinFormsApp1
{
    public partial class frmAtividade03 : Form
    {
        public frmAtividade03()
        {
            InitializeComponent();
        }

        //variáveis
        float N1;
        float N2;
        float N3;
        float Result;

        public bool Verificador() //método que criei para verificar os valores (não ser vazios e letras)
        {
            if (txtN1.Text != "" == false && txtN2.Text != "" == false) // '&&' = operador "e". '||' =operador "ou"
            {
                MessageBox.Show("Erro!! Informe dois valores válidos.");
                txtN1.Text = "";
                txtN2.Text = "";
                txtN1.Focus();
                lblResult.Text = "0";
                return false;
            }
            if(float.TryParse(txtN1.Text, out N1) == false ) //tenta converter e armazena na variavel dps de "out".se não for possivel retorna false
            {
                MessageBox.Show("Erro!! Informe dois valores numéricos.");
                txtN1.Text = "";
                txtN1.Focus();
                lblResult.Text = "0";
                return false;
            }
            if(float.TryParse(txtN2.Text, out N2) == false)
            {
                MessageBox.Show("Erro!! Informe dois valores numéricos.");
                txtN2.Text = "";
                txtN2.Focus();
                lblResult.Text = "0";
                return false;
            }
            return true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
            txtN2.Text = "";
            lblResult.Text = "0";
            txtN1.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (Verificador()) //chama o método verificador
            {
                //N1 = float.Parse(txtN1.Text);
                //N2 = float.Parse(txtN2.Text);
                Result = N1 + N2;
                lblResult.Text = Result.ToString();
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (Verificador()) //chama o método verificador
            {
                Result = N1 - N2;
                lblResult.Text = Result.ToString();
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (Verificador()) //chama o método verificador
            {
                Result = N1 * N2;
                lblResult.Text = Result.ToString();
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (Verificador()) //chama o método verificador
            {
                if(N2 == 0) //verifica que não divida por 0
                {
                    MessageBox.Show("N2 não pode ser 0 na divisão");
                    txtN2.Text = "";
                    txtN2.Focus();
                    return;
                }

                Result = N1 / N2;
                lblResult.Text = Result.ToString();
            }
        }

        private void btnDesconto_Click(object sender, EventArgs e)
        {

            btnSomar.PerformClick(); //chama o metodo do botao somar

            if ((txtN3.Text != "" == false) || float.TryParse(txtN3.Text, out N3) == false)
            {
                MessageBox.Show("Erro!! Informe um valor válido para Descontos e Juros.");
                txtN3.Text = "";
                txtN3.Focus();
                return;
            }

            Result = Result * (1 - (N3 / 100));
            lblResult.Text = Result.ToString();
        }

        private void btnJuros_Click(object sender, EventArgs e)
        {
            btnSomar.PerformClick();

            if ((txtN3.Text != "" == false) || float.TryParse(txtN3.Text, out N3) == false)
            {
                MessageBox.Show("Erro!! Informe um valor válido para Descontos e Juros.");
                txtN3.Text = "";
                txtN3.Focus();
                return;
            }

            Result = Result * (1 + (N3 / 100));
            lblResult.Text = Result.ToString();
        }
    }
}