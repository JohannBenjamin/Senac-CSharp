namespace WinFormsApp2
{
    public partial class frmAtividade05 : Form
    {
        public frmAtividade05()
        {
            InitializeComponent();
        }

        //variáveis
        float n1;
        float n2;
        float n3;
        float n4;
        float result;
        string mensagem = ""; // deixo nulo para não aparecer o aviso chato


        bool Verificador()
        {
            if((float.TryParse(txtN1.Text, out n1)== false))
            {
                mensagem = "ERRO!! Informe um valor válido para N1";
                txtN1.Text = "";
                txtN1.Focus();
                return false;
            }
            else
            {
                if (n1 < 0 || n1 > 10)
                {
                    mensagem = "ERRO!! Informe uma nota válida para N1";
                    txtN1.Text = "";
                    txtN1.Focus();
                    return false;
                }
            }
            if ((float.TryParse(txtN2.Text, out n2) == false))
            {
                mensagem = "ERRO!! Informe um valor válido para N2";
                txtN2.Text = "";
                txtN2.Focus();
                return false;
            }
            else
            {
                if (n2 < 0 || n2 > 10)
                {
                    mensagem = "ERRO!! Informe uma nota válida para N2";
                    txtN2.Text = "";
                    txtN2.Focus();
                    return false;
                }
            }
            if ((float.TryParse(txtN3.Text, out n3) == false))
            {
                mensagem = "ERRO!! Informe um valor válido para N3";
                txtN3.Text = "";
                txtN3.Focus();
                return false;
            }
            else
            {
                if (n3 < 0 || n3 > 10)
                {
                    mensagem = "ERRO!! Informe uma nota válida para N3";
                    txtN3.Text = "";
                    txtN3.Focus();
                    return false;
                }
            }
            if ((float.TryParse(txtN4.Text, out n4) == false))
            {
                mensagem = "ERRO!! Informe um valor válido para N4";
                txtN4.Text = "";
                txtN4.Focus();
                return false;
            }
            else
            {
                if (n4 < 0 || n4 > 10)
                {
                    mensagem = "ERRO!! Informe uma nota válida para N4";
                    txtN4.Text = "";
                    txtN4.Focus();
                    return false;
                }
            }
            return true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(Verificador()) //verifica se não é letra, se não ta vazio e se não é maior que 10 e menor que 0
            {
                result = (n1 + n2 + n3 + n4)/4;
                lblResult.Text = result.ToString();

                if(result < 5)
                {
                    lblSituacao.Text = "Reprovado";
                    lblResult.BackColor = Color.LightCoral; //.BackColor muda a cor do fundo
                    lblSituacao.BackColor = Color.LightCoral; 
                    lblSituacao.ForeColor = Color.Red; //.ForeColor muda a cor da letra
                }
                else if(result < 8)
                {
                    lblSituacao.Text = "Exame";
                    lblResult.BackColor = Color.Khaki;
                    lblSituacao.BackColor = Color.Khaki;
                }
                else
                {
                    lblSituacao.Text = "Aprovado";
                    lblResult.BackColor = Color.LightGreen;
                    lblSituacao.BackColor = Color.LightGreen;
                    lblSituacao.ForeColor = Color.Green;
                }
            }
            else
            {
                MessageBox.Show(mensagem);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
            txtN2.Text = "";
            txtN3.Text = "";
            txtN4.Text = "";

            lblResult.Text = "0";
            lblResult.BackColor = Color.Silver;
            lblResult.ForeColor = Color.Black;

            lblSituacao.Text = "Situação";
            lblSituacao.BackColor= Color.Silver;
            lblSituacao.ForeColor = Color.Black;

            txtN1.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}