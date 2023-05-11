namespace Multi_Formularios
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        //Vari�veis
        int codigo;
        string nome;
        string sexo;
        DateOnly nascimento;
        string logradouro;
        int numero;
        string complemento;
        string cep;
        string cidade;
        string uf;
        float salario;
        string telefone;
        string email;
        string obs;
        string mensagem;

        bool Validacao()
        {
            //C�digo
            if (!int.TryParse(txtCodigo.Text, out codigo))
            {
                mensagem = "ERRO!! Informe um c�digo num�rico";
                txtCodigo.Text = "";
                txtCodigo.Focus();
                return false;
            }

            //Nome
            /*if(txtNome.Text.Trim() == "")    //TRIM = Ignora os espa�os em branco na verifica��o
            {
                
            }*/
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                mensagem = "ERRO!! Informe um nome v�lido";
                txtNome.Focus();
                return false;
            }
            else
            {
                nome = txtNome.Text;
            }

            //Sexo
            /*if (txtSexo.SelectedIndex == -1)
            {
                    //Verifica se o combobox sexo n�o seja uma op��o que n�o esteja dentro da lista
            }*/
            if (txtSexo.Text == "Selecionar...")
            {
                mensagem = "ERRO!! Informe um sexo v�lido";
                return false;
            }
            else
            {
                sexo = txtSexo.Text;
            }

            //Data Nascimento
            /*if (txtNascimento.MaskFull == false) // MaskFull = Verifica se a mascara da data esta corretamente preenchida
            {

            }*/
            if (!DateOnly.TryParse(txtNascimento.Text, out nascimento))
            {
                mensagem = "ERRO!! Informe uma data de nascimento v�lida";
                txtNascimento.Text = "";
                txtNascimento.Focus();
                return false;
            }

            //Logradouro
            /*if(txtLogradouro.Text.Trim() == "")
            {
                
            }*/
            if (string.IsNullOrEmpty(txtLogradouro.Text))
            {
                mensagem = "ERRO!! Informe um logradouro v�lido";
                txtLogradouro.Focus();
                return false;
            }
            else
            {
                logradouro = txtLogradouro.Text;
            }

            //N�mero
            if (!int.TryParse(txtNumero.Text, out numero))
            {
                mensagem = "ERRO!! Informe um n�mero residencial v�lido";
                txtNumero.Text = "";
                txtNumero.Focus();
                return false;
            }

            //CEP
            /*if (txtCep.MaskFull == false)
            {

            }*/
            if (txtCep.Text.Contains(" "))
            {
                mensagem = "ERRO!! Informe um CEP v�lido";
                txtCep.Text = "";
                txtCep.Focus();
                return false;
            }
            else
            {
                cep = txtCep.Text;
            }

            //Cidade
            /*if(txtCidade.Text.Trim() == "")
            {
                
            }*/
            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                mensagem = "ERRO!! Informe uma Cidade v�lida";
                txtCidade.Focus();
                return false;
            }
            else
            {
                cidade = txtCidade.Text;
            }

            //UF
            /*if (txtUf.SelectedIndex == -1)
            {
                    
            }*/
            if (string.IsNullOrEmpty(txtUf.Text))
            {
                mensagem = "ERRO!! Informe uma UF v�lida";
                return false;
            }
            else
            {
                uf = txtUf.Text;
            }
            

            //Sal�rio
            if (!float.TryParse(txtSalario.Text, out salario))
            {
                mensagem = "ERRO!! Informe um sal�rio v�lido";
                txtSalario.Text = "";
                txtSalario.Focus();
                return false;
            }

            //Telefone
            /*if (txtCep.MaskFull == false)
            {

            }*/
            if (txtTelefone.Text.Contains(" "))
            {
                mensagem = "ERRO!! Informe um Telefone v�lido";
                txtTelefone.Text = "";
                txtTelefone.Focus();
                return false;
            }
            else
            {
                telefone = txtTelefone.Text;
            }

            //Email
            /*if(txtCidade.Text.Trim() == "")
            {
                
            }*/
            if (!(txtEmail.Text.Contains("@") && txtEmail.Text.Contains(".com")))
            {
                mensagem = "ERRO!! Informe um Email v�lido";
                txtEmail.Text = "";
                txtEmail.Focus();
                return false;
            }
            else
            {
                email = txtEmail.Text;
            }
            return true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtComplemento.Text))
            {
                complemento = txtComplemento.Text;
            }
            if (!string.IsNullOrEmpty(txtObservacao.Text))
            {
                obs = txtObservacao.Text;
            }
            if (Validacao())
            {
                lblResult.Text = "C�digo: " + codigo + "\n"+
                                    "Nome: " + nome + "\n" +
                                    "Sexo: "+sexo + "\n" +
                                    "Data de Nascimento: " + nascimento + "\n" +
                                    "Logradouro: " + logradouro + "\n" +
                                    "N�mero: " + numero + "\n" +
                                    "Complemento: " + complemento + "\n" +
                                    "CEP: " + cep + "\n" +
                                    "Cidade: " + cidade + "\n" +
                                    "UF: " + uf + "\n" +
                                    "Sal�rio: " + salario.ToString("C") + "\n" +
                                    "Telefone: " + telefone + "\n" +
                                    "Email: " + email + "\n" +
                                    "Observa��o: " + obs;
            }
            else
            {
                MessageBox.Show(mensagem);
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!("ABCDEFGHIJKLMNOPQRSTUVWXYZ ".Contains(e.KeyChar.ToString().ToUpper())))
            {
                e.Handled = true;
            }
        }

        private void txtLogradouro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!("ABCDEFGHIJKLMNOPQRSTUVWXYZ ".Contains(e.KeyChar.ToString().ToUpper())))
            {
                e.Handled = true;
            }
        }

        private void txtSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!("".Contains(e.KeyChar.ToString().ToUpper())))
            {
                e.Handled = true;
            }
        }

        private void txtUf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!("".Contains(e.KeyChar.ToString().ToUpper())))
            {
                e.Handled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtSexo.SelectedIndex = -1;
            txtNascimento.Text = "";
            txtLogradouro.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtCep.Text = "";
            txtCidade.Text = "";
            txtUf.SelectedIndex = -1;
            txtSalario.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            txtObservacao.Text = "";
            lblResult.Text = "";
            txtCodigo.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close(); //fecha a form sem fechar a aplica��o toda
        }
    }
}