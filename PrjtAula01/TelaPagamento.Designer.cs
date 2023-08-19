namespace PrjtAula01
{
    partial class TelaPagamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPagamento));
            txtIdentificacaoPag = new TextBox();
            txtNomeDestinoPag = new TextBox();
            txtNumContaPag = new TextBox();
            txtCodBarrasPag = new TextBox();
            lblSaldoVal = new Label();
            lblSaldo = new Label();
            lblPagamento = new Label();
            lblPagamentoConfirmado = new Label();
            lblVoltarPagamento = new Button();
            btConfirmarPagamento = new Button();
            lblValorPagamento = new Label();
            txtValorPagamento = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtIdentificacaoPag
            // 
            txtIdentificacaoPag.BackColor = Color.White;
            txtIdentificacaoPag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdentificacaoPag.Location = new Point(90, 461);
            txtIdentificacaoPag.Name = "txtIdentificacaoPag";
            txtIdentificacaoPag.PlaceholderText = "Quem está depositando?";
            txtIdentificacaoPag.Size = new Size(379, 29);
            txtIdentificacaoPag.TabIndex = 4;
            txtIdentificacaoPag.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNomeDestinoPag
            // 
            txtNomeDestinoPag.BackColor = Color.White;
            txtNomeDestinoPag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeDestinoPag.Location = new Point(90, 388);
            txtNomeDestinoPag.Name = "txtNomeDestinoPag";
            txtNomeDestinoPag.PlaceholderText = "Nome do beneficiário";
            txtNomeDestinoPag.Size = new Size(379, 29);
            txtNomeDestinoPag.TabIndex = 3;
            txtNomeDestinoPag.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNumContaPag
            // 
            txtNumContaPag.BackColor = Color.White;
            txtNumContaPag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumContaPag.Location = new Point(90, 315);
            txtNumContaPag.Name = "txtNumContaPag";
            txtNumContaPag.PlaceholderText = "Número da conta destino";
            txtNumContaPag.Size = new Size(379, 29);
            txtNumContaPag.TabIndex = 2;
            txtNumContaPag.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCodBarrasPag
            // 
            txtCodBarrasPag.BackColor = Color.White;
            txtCodBarrasPag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodBarrasPag.Location = new Point(90, 243);
            txtCodBarrasPag.Name = "txtCodBarrasPag";
            txtCodBarrasPag.PlaceholderText = "0000.0000.0000.0000.000000.0.000000000";
            txtCodBarrasPag.Size = new Size(379, 29);
            txtCodBarrasPag.TabIndex = 1;
            txtCodBarrasPag.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSaldoVal
            // 
            lblSaldoVal.AutoSize = true;
            lblSaldoVal.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldoVal.ForeColor = Color.Black;
            lblSaldoVal.Location = new Point(202, 141);
            lblSaldoVal.Name = "lblSaldoVal";
            lblSaldoVal.Size = new Size(121, 37);
            lblSaldoVal.TabIndex = 21;
            lblSaldoVal.Text = "R$ 50,33";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldo.ForeColor = Color.Black;
            lblSaldo.Location = new Point(106, 141);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(90, 37);
            lblSaldo.TabIndex = 20;
            lblSaldo.Text = "Saldo:";
            // 
            // lblPagamento
            // 
            lblPagamento.AutoSize = true;
            lblPagamento.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblPagamento.ForeColor = Color.Black;
            lblPagamento.Location = new Point(106, 66);
            lblPagamento.Name = "lblPagamento";
            lblPagamento.Size = new Size(163, 37);
            lblPagamento.TabIndex = 19;
            lblPagamento.Text = "Pagamentos";
            // 
            // lblPagamentoConfirmado
            // 
            lblPagamentoConfirmado.AutoSize = true;
            lblPagamentoConfirmado.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblPagamentoConfirmado.ForeColor = Color.White;
            lblPagamentoConfirmado.Location = new Point(910, 405);
            lblPagamentoConfirmado.Name = "lblPagamentoConfirmado";
            lblPagamentoConfirmado.Size = new Size(276, 37);
            lblPagamentoConfirmado.TabIndex = 30;
            lblPagamentoConfirmado.Text = "Pagamento realizado!";
            // 
            // lblVoltarPagamento
            // 
            lblVoltarPagamento.BackColor = Color.White;
            lblVoltarPagamento.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblVoltarPagamento.Location = new Point(1051, 505);
            lblVoltarPagamento.Name = "lblVoltarPagamento";
            lblVoltarPagamento.Size = new Size(133, 42);
            lblVoltarPagamento.TabIndex = 7;
            lblVoltarPagamento.Text = "Voltar";
            lblVoltarPagamento.UseVisualStyleBackColor = false;
            // 
            // btConfirmarPagamento
            // 
            btConfirmarPagamento.BackColor = Color.Black;
            btConfirmarPagamento.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btConfirmarPagamento.ForeColor = Color.White;
            btConfirmarPagamento.Location = new Point(884, 311);
            btConfirmarPagamento.Name = "btConfirmarPagamento";
            btConfirmarPagamento.Size = new Size(300, 48);
            btConfirmarPagamento.TabIndex = 6;
            btConfirmarPagamento.Text = "Confirmar Pagamento";
            btConfirmarPagamento.UseVisualStyleBackColor = false;
            // 
            // lblValorPagamento
            // 
            lblValorPagamento.AutoSize = true;
            lblValorPagamento.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorPagamento.ForeColor = Color.Black;
            lblValorPagamento.Location = new Point(896, 141);
            lblValorPagamento.Name = "lblValorPagamento";
            lblValorPagamento.Size = new Size(272, 37);
            lblValorPagamento.TabIndex = 29;
            lblValorPagamento.Text = "Insira o valor a pagar:";
            // 
            // txtValorPagamento
            // 
            txtValorPagamento.BackColor = Color.White;
            txtValorPagamento.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorPagamento.Location = new Point(884, 207);
            txtValorPagamento.Name = "txtValorPagamento";
            txtValorPagamento.PlaceholderText = "R$ 0,00";
            txtValorPagamento.Size = new Size(300, 43);
            txtValorPagamento.TabIndex = 5;
            txtValorPagamento.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(580, 204);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 177);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // TelaPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 143, 235);
            ClientSize = new Size(1208, 634);
            Controls.Add(lblPagamentoConfirmado);
            Controls.Add(lblVoltarPagamento);
            Controls.Add(btConfirmarPagamento);
            Controls.Add(lblValorPagamento);
            Controls.Add(txtValorPagamento);
            Controls.Add(pictureBox1);
            Controls.Add(txtIdentificacaoPag);
            Controls.Add(txtNomeDestinoPag);
            Controls.Add(txtNumContaPag);
            Controls.Add(txtCodBarrasPag);
            Controls.Add(lblSaldoVal);
            Controls.Add(lblSaldo);
            Controls.Add(lblPagamento);
            Name = "TelaPagamento";
            Text = "TelaPagamento";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdentificacaoPag;
        private TextBox txtNomeDestinoPag;
        private TextBox txtNumContaPag;
        private TextBox txtCodBarrasPag;
        private Label lblSaldoVal;
        private Label lblSaldo;
        private Label lblPagamento;
        private Label lblPagamentoConfirmado;
        private Button lblVoltarPagamento;
        private Button btConfirmarPagamento;
        private Label lblValorPagamento;
        private TextBox txtValorPagamento;
        private PictureBox pictureBox1;
    }
}