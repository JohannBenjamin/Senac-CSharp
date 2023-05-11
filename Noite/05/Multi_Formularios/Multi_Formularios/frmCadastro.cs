namespace Multi_Formularios
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        //Variáveis
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
            //Código
            if (!int.TryParse(txtCodigo.Text, out codigo))
            {
                mensagem = "ERRO!! Informe um código numérico";
                txtCodigo.Text = "";
                txtCodigo.Focus();
                return false;
            }

            //Nome
            /*if(txtNome.Text.Trim() == "")    //TRIM = Ignora os espaços em branco na verificação
            {
                
            }*/
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                mensagem = "ERRO!! Informe um nome válido";
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
                    //Verifica se o combobox sexo não seja uma opção que não esteja dentro da lista
            }*/
            if (txtSexo.Text == "Selecionar...")
            {
                mensagem = "ERRO!! Informe um sexo válido";
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
                mensagem = "ERRO!! Informe uma data de nascimento válida";
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
                mensagem = "ERRO!! Informe um logradouro válido";
                txtLogradouro.Focus();
                return false;
            }
            else
            {
                logradouro = txtLogradouro.Text;
            }

            //Número
            if (!int.TryParse(txtNumero.Text, out numero))
            {
                mensagem = "ERRO!! Informe um número residencial válido";
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
                mensagem = "ERRO!! Informe um CEP válido";
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
                mensagem = "ERRO!! Informe uma Cidade válida";
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
                mensagem = "ERRO!! Informe uma UF válida";
                return false;
            }
            else
            {
                uf = txtUf.Text;
            }
            

            //Salário
            if (!float.TryParse(txtSalario.Text, out salario))
            {
                mensagem = "ERRO!! Informe um salário válido";
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
                mensagem = "ERRO!! Informe um Telefone válido";
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
                mensagem = "ERRO!! Informe um Email válido";
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
                lblResult.Text = "Código: " + codigo + "\n"+
                                    "Nome: " + nome + "\n" +
                                    "Sexo: "+sexo + "\n" +
                                    "Data de Nascimento: " + nascimento + "\n" +
                                    "Logradouro: " + logradouro + "\n" +
                                    "Número: " + numero + "\n" +
                                    "Complemento: " + complemento + "\n" +
                                    "CEP: " + cep + "\n" +
                                    "Cidade: " + cidade + "\n" +
                                    "UF: " + uf + "\n" +
                                    "Salário: " + salario.ToString("C") + "\n" +
                                    "Telefone: " + telefone + "\n" +
                                    "Email: " + email + "\n" +
                                    "Observação: " + obs;
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
            this.Close(); //fecha a form sem fechar a aplicação toda
        }
    }
}