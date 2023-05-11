namespace WinFormsApp1
{
    public partial class frmAtividade02 : Form
    {
        public frmAtividade02()
        {
            InitializeComponent();
        }

        private void btnEsquerda_Click(object sender, EventArgs e)
        {
            if (txtNomeD1.Text != "" || txtNomeD2.Text != "" || txtNomeD3.Text != "" || txtNomeD4.Text != "" || txtNomeD5.Text != "")
            {
                MessageBox.Show("Remova o nome da direita!");
            }
            else
            {
                txtNomeD1.Text = lblNomeM1.Text;
                lblNomeM1.Text = "";
                txtNomeD2.Text = lblNomeM2.Text;
                lblNomeM2.Text = "";
                txtNomeD3.Text = lblNomeM3.Text;
                lblNomeM3.Text = "";
                txtNomeD4.Text = lblNomeM4.Text;
                lblNomeM4.Text = "";
                txtNomeD5.Text = lblNomeM5.Text;
                lblNomeM5.Text = "";

                lblNomeM1.Text = txtNomeE1.Text;
                txtNomeE1.Text = "";
                lblNomeM2.Text = txtNomeE2.Text;
                txtNomeE2.Text = "";
                lblNomeM3.Text = txtNomeE3.Text;
                txtNomeE3.Text = "";
                lblNomeM4.Text = txtNomeE4.Text;
                txtNomeE4.Text = "";
                lblNomeM5.Text = txtNomeE5.Text;
                txtNomeE5.Text = "";
            }
        }

        private void btnDireita_Click(object sender, EventArgs e)
        {
            if (txtNomeE1.Text != "" || txtNomeE2.Text != "" || txtNomeE3.Text != "" || txtNomeE4.Text != "" || txtNomeE5.Text != "")
            {
                MessageBox.Show("Remova o nome da esquerda!");
            }
            else
            {
                txtNomeE1.Text = lblNomeM1.Text;
                lblNomeM1.Text = "";
                txtNomeE2.Text = lblNomeM2.Text;
                lblNomeM2.Text = "";
                txtNomeE3.Text = lblNomeM3.Text;
                lblNomeM3.Text = "";
                txtNomeE4.Text = lblNomeM4.Text;
                lblNomeM4.Text = "";
                txtNomeE5.Text = lblNomeM5.Text;
                lblNomeM5.Text = "";

                lblNomeM1.Text = txtNomeD1.Text;
                txtNomeD1.Text = "";
                lblNomeM2.Text = txtNomeD2.Text;
                txtNomeD2.Text = "";
                lblNomeM3.Text = txtNomeD3.Text;
                txtNomeD3.Text = "";
                lblNomeM4.Text = txtNomeD4.Text;
                txtNomeD4.Text = "";
                lblNomeM5.Text = txtNomeD5.Text;
                txtNomeD5.Text = "";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeD1.Text = "";
            txtNomeD2.Text = "";
            txtNomeD3.Text = "";
            txtNomeD4.Text = "";
            txtNomeD5.Text = "";
            lblNomeM1.Text = "";
            lblNomeM2.Text = "";
            lblNomeM3.Text = "";
            lblNomeM4.Text = "";
            lblNomeM5.Text = "";
            txtNomeE1.Text = "";
            txtNomeE2.Text = "";
            txtNomeE3.Text = "";
            txtNomeE4.Text = "";
            txtNomeE5.Text = "";
        }
    }
}