using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Formularios
{
    public partial class frmSistemaVenda : Form
    {
        public frmSistemaVenda()
        {
            InitializeComponent();
        }

        //Variáveis
        string carrinho;
        string mensagem;
        double valor;
        double valorTotal;
        float total;
        //double[] referencia = new double[9];
        //int contador;
        string teste;

        public bool Verificador()
        {
            if(cboProduto.SelectedIndex == -1)
            {
                mensagem = "Escolha um produto!";
                return false;
            }
            if (numQuantidade.Value == 0)
            {
                mensagem = "Informe uma quantidade válida!";
                return false;
            }
            foreach (string testeADD in lstCarrinho.Items)
            {
                teste = testeADD.Substring(0, 10).Trim();
                if (carrinho.Contains(teste))
                {
                    mensagem = "ERRO!! Já existe esse produto no carrinho.";
                    return false;
                }
            }
            return true;
        }

        private void cboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboProduto.SelectedIndex == 0)
            {
                valor = 39.99;
                txtValor.Text = valor.ToString("C");

            }
            if(cboProduto.SelectedIndex == 1)
            {
                valor = 49.97;
                txtValor.Text = valor.ToString("C");
            }
            if (cboProduto.SelectedIndex == 2)
            {
                valor = 35.97;
                txtValor.Text = valor.ToString("C");
            }
            if (cboProduto.SelectedIndex == 3)
            {
                valor = 24.98;
                txtValor.Text = valor.ToString("C");
            }
            if (cboProduto.SelectedIndex == 4)
            {
                valor = 29.98;
                txtValor.Text = valor.ToString("C");
            }
            if (cboProduto.SelectedIndex == 5)
            {
                valor = 39.99;
                txtValor.Text = valor.ToString("C");
            }
            if (cboProduto.SelectedIndex == 6)
            {
                valor = 44.98;
                txtValor.Text = valor.ToString("C");
            }
            if (cboProduto.SelectedIndex == 7)
            {
                valor = 29.99;
                txtValor.Text = valor.ToString("C");
            }
            if (cboProduto.SelectedIndex == 8)
            {
                valor = 34.98;
                txtValor.Text = valor.ToString("C");
            }
            if (cboProduto.SelectedIndex == 9)
            {
                valor = 44.99;
                txtValor.Text = valor.ToString("C");
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (Verificador())
            {
                total = float.Parse(txtTotal.Text);

                valorTotal = double.Parse(numQuantidade.Value.ToString()) * valor;
                carrinho = cboProduto.SelectedItem.ToString() + " - QTDE: " + numQuantidade.Value.ToString() + " - Total: " + (double.Parse(numQuantidade.Value.ToString()) * valor).ToString("C");
                
                /*contador = lstCarrinho.Items.Count;    TENTATIVAS PARA VERIFICAR PRODUTOS REPETIDOS
                if (!(lstCarrinho.Items.Count == 0))
                {
                    for (int i = 0; i < contador; i++)
                    {
                        lstCarrinho.SelectedIndex = i;
                        testeADD[i] = lstCarrinho.SelectedItem.ToString();
                        testeADD[i] = testeADD[i].Substring(0, 10).Trim();
                        if (testeADD[i].Contains(cboProduto.SelectedItem.ToString()))
                        {
                            verificadorTeste = false;
                        }
                    }
                }*/
                
                lstCarrinho.Items.Add(carrinho);
                //contador = (lstCarrinho.);
                    
                //referencia[contador] = valorTotaL
                total = total + float.Parse(valorTotal.ToString());
                txtTotal.Text = total.ToString("0.00");
                //double.Parse(txtTotal.Text) = double.Parse(txtTotal.Text) + (double.Parse(numQuantidade.Value.ToString()) * valor);
                lstCarrinho.ClearSelected();
            }
            else
            {
                MessageBox.Show(mensagem);
                lstCarrinho.ClearSelected();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(lstCarrinho.SelectedIndex != -1)
            {
                string testeRemover = lstCarrinho.Text;

                testeRemover = testeRemover.Substring(testeRemover.IndexOf("$") + 1).Trim();
                //total = total - float.Parse(referencia[lstCarrinho.SelectedIndex].ToString());
                total = total - float.Parse(testeRemover);
                lstCarrinho.Items.RemoveAt(lstCarrinho.SelectedIndex);
                //float.Parse(valorTotal.ToString());
                txtTotal.Text = (Math.Abs(total)).ToString("0.00");
            }
            else
            {
                MessageBox.Show("ERRO!! Selecione um ítem do carrinho.");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(lstCarrinho.Items.Count == 0))
            {
                MessageBox.Show("Compra Realizada com sucesso!! \n" +
                    "Ítens comprados: " + (lstCarrinho.Items.Count) + "\n" +
                    "Valor Total: " + total.ToString("C"));
            }
            else
            {
                MessageBox.Show("Compra finalizada sem nenhuma compra.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstCarrinho.Items.Clear();
            cboProduto.SelectedIndex = -1;
            txtValor.Text = "";
            numQuantidade.Value = 1;
            txtTotal.Text = "0.00";

        }
    }
}
