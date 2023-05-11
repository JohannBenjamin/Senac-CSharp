namespace WinFormsApp1
{
    partial class frmAtividade03
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblN1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnDesconto = new System.Windows.Forms.Button();
            this.btnJuros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblN1
            // 
            this.lblN1.Location = new System.Drawing.Point(14, 9);
            this.lblN1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(129, 30);
            this.lblN1.TabIndex = 0;
            this.lblN1.Text = "N1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(207, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "N2";
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(207, 42);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(131, 35);
            this.txtN2.TabIndex = 1;
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(12, 42);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(131, 35);
            this.txtN1.TabIndex = 0;
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(387, 38);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(103, 39);
            this.btnSomar.TabIndex = 2;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(387, 83);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(103, 39);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(387, 128);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(103, 39);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Moccasin;
            this.lblResult.Location = new System.Drawing.Point(14, 89);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(324, 78);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "0";
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(608, 128);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(115, 35);
            this.txtN3.TabIndex = 11;
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Location = new System.Drawing.Point(504, 38);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(98, 39);
            this.btnSubtrair.TabIndex = 6;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(504, 85);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(98, 39);
            this.btnMultiplicar.TabIndex = 7;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(504, 128);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(98, 39);
            this.btnDividir.TabIndex = 8;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnDesconto
            // 
            this.btnDesconto.Location = new System.Drawing.Point(608, 38);
            this.btnDesconto.Name = "btnDesconto";
            this.btnDesconto.Size = new System.Drawing.Size(115, 39);
            this.btnDesconto.TabIndex = 9;
            this.btnDesconto.Text = "Desconto";
            this.btnDesconto.UseVisualStyleBackColor = true;
            this.btnDesconto.Click += new System.EventHandler(this.btnDesconto_Click);
            // 
            // btnJuros
            // 
            this.btnJuros.Location = new System.Drawing.Point(608, 83);
            this.btnJuros.Name = "btnJuros";
            this.btnJuros.Size = new System.Drawing.Size(115, 39);
            this.btnJuros.TabIndex = 10;
            this.btnJuros.Text = "Juros";
            this.btnJuros.UseVisualStyleBackColor = true;
            this.btnJuros.Click += new System.EventHandler(this.btnJuros_Click);
            // 
            // frmAtividade03
            // 
            this.AcceptButton = this.btnSomar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(767, 187);
            this.Controls.Add(this.btnJuros);
            this.Controls.Add(this.btnDesconto);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblN1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmAtividade03";
            this.Text = "Atividade03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblN1;
        private Label label1;
        private TextBox txtN2;
        private TextBox txtN1;
        private Button btnSomar;
        private Button btnLimpar;
        private Button btnSair;
        private Label lblResult;
        private TextBox txtN3;
        private Button btnSubtrair;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Button btnDesconto;
        private Button btnJuros;
    }
}