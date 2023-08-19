namespace PrjtAula01
{
    partial class TelaSaque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaSaque));
            lblSaqueConfirmado = new Label();
            lblVoltarSaque = new Button();
            btConfirmarSaque = new Button();
            lblValorSaque = new Label();
            txtValorSaque = new TextBox();
            pictureBox1 = new PictureBox();
            txtCelularSaque = new TextBox();
            txtEmailSaque = new TextBox();
            txtCpfSaque = new TextBox();
            txtNomeSaque = new TextBox();
            lblSaldoVal = new Label();
            lblSaldo = new Label();
            lblSaque = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblSaqueConfirmado
            // 
            lblSaqueConfirmado.AutoSize = true;
            lblSaqueConfirmado.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaqueConfirmado.ForeColor = Color.White;
            lblSaqueConfirmado.Location = new Point(861, 420);
            lblSaqueConfirmado.Name = "lblSaqueConfirmado";
            lblSaqueConfirmado.Size = new Size(214, 37);
            lblSaqueConfirmado.TabIndex = 37;
            lblSaqueConfirmado.Text = "Saque realizado!";
            // 
            // lblVoltarSaque
            // 
            lblVoltarSaque.BackColor = Color.White;
            lblVoltarSaque.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblVoltarSaque.Location = new Point(1002, 520);
            lblVoltarSaque.Name = "lblVoltarSaque";
            lblVoltarSaque.Size = new Size(133, 42);
            lblVoltarSaque.TabIndex = 6;
            lblVoltarSaque.Text = "Voltar";
            lblVoltarSaque.UseVisualStyleBackColor = false;
            lblVoltarSaque.Click += lblVoltarSaque_Click;
            // 
            // btConfirmarSaque
            // 
            btConfirmarSaque.BackColor = Color.Black;
            btConfirmarSaque.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btConfirmarSaque.ForeColor = Color.White;
            btConfirmarSaque.Location = new Point(835, 326);
            btConfirmarSaque.Name = "btConfirmarSaque";
            btConfirmarSaque.Size = new Size(300, 48);
            btConfirmarSaque.TabIndex = 5;
            btConfirmarSaque.Text = "Confirmar saque";
            btConfirmarSaque.UseVisualStyleBackColor = false;
            // 
            // lblValorSaque
            // 
            lblValorSaque.AutoSize = true;
            lblValorSaque.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorSaque.ForeColor = Color.Black;
            lblValorSaque.Location = new Point(820, 156);
            lblValorSaque.Name = "lblValorSaque";
            lblValorSaque.Size = new Size(327, 37);
            lblValorSaque.TabIndex = 34;
            lblValorSaque.Text = "Insira o valor a ser sacado:";
            // 
            // txtValorSaque
            // 
            txtValorSaque.BackColor = Color.White;
            txtValorSaque.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorSaque.Location = new Point(835, 222);
            txtValorSaque.Name = "txtValorSaque";
            txtValorSaque.PlaceholderText = "R$ 0,00";
            txtValorSaque.Size = new Size(300, 43);
            txtValorSaque.TabIndex = 4;
            txtValorSaque.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(531, 219);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 177);
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // txtCelularSaque
            // 
            txtCelularSaque.BackColor = Color.White;
            txtCelularSaque.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCelularSaque.Location = new Point(76, 440);
            txtCelularSaque.Name = "txtCelularSaque";
            txtCelularSaque.PlaceholderText = "(00) 00000-0000";
            txtCelularSaque.Size = new Size(300, 29);
            txtCelularSaque.TabIndex = 3;
            txtCelularSaque.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEmailSaque
            // 
            txtEmailSaque.BackColor = Color.White;
            txtEmailSaque.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailSaque.Location = new Point(76, 367);
            txtEmailSaque.Name = "txtEmailSaque";
            txtEmailSaque.PlaceholderText = "Confirme seu e-mail";
            txtEmailSaque.Size = new Size(300, 29);
            txtEmailSaque.TabIndex = 2;
            txtEmailSaque.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCpfSaque
            // 
            txtCpfSaque.BackColor = Color.White;
            txtCpfSaque.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpfSaque.Location = new Point(76, 294);
            txtCpfSaque.Name = "txtCpfSaque";
            txtCpfSaque.PlaceholderText = "Confirme seu CPF";
            txtCpfSaque.Size = new Size(300, 29);
            txtCpfSaque.TabIndex = 1;
            txtCpfSaque.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNomeSaque
            // 
            txtNomeSaque.BackColor = Color.White;
            txtNomeSaque.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeSaque.Location = new Point(76, 222);
            txtNomeSaque.Name = "txtNomeSaque";
            txtNomeSaque.PlaceholderText = "Nome Usuário";
            txtNomeSaque.Size = new Size(300, 29);
            txtNomeSaque.TabIndex = 0;
            txtNomeSaque.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSaldoVal
            // 
            lblSaldoVal.AutoSize = true;
            lblSaldoVal.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldoVal.ForeColor = Color.Black;
            lblSaldoVal.Location = new Point(188, 156);
            lblSaldoVal.Name = "lblSaldoVal";
            lblSaldoVal.Size = new Size(121, 37);
            lblSaldoVal.TabIndex = 27;
            lblSaldoVal.Text = "R$ 50,33";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldo.ForeColor = Color.Black;
            lblSaldo.Location = new Point(92, 156);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(90, 37);
            lblSaldo.TabIndex = 26;
            lblSaldo.Text = "Saldo:";
            // 
            // lblSaque
            // 
            lblSaque.AutoSize = true;
            lblSaque.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaque.ForeColor = Color.Black;
            lblSaque.Location = new Point(92, 81);
            lblSaque.Name = "lblSaque";
            lblSaque.Size = new Size(90, 37);
            lblSaque.TabIndex = 25;
            lblSaque.Text = "Saque";
            // 
            // TelaSaque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 143, 235);
            ClientSize = new Size(1210, 642);
            Controls.Add(lblSaqueConfirmado);
            Controls.Add(lblVoltarSaque);
            Controls.Add(btConfirmarSaque);
            Controls.Add(lblValorSaque);
            Controls.Add(txtValorSaque);
            Controls.Add(pictureBox1);
            Controls.Add(txtCelularSaque);
            Controls.Add(txtEmailSaque);
            Controls.Add(txtCpfSaque);
            Controls.Add(txtNomeSaque);
            Controls.Add(lblSaldoVal);
            Controls.Add(lblSaldo);
            Controls.Add(lblSaque);
            Name = "TelaSaque";
            Text = "TelaSaque";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaqueConfirmado;
        private Button lblVoltarSaque;
        private Button btConfirmarSaque;
        private Label lblValorSaque;
        private TextBox txtValorSaque;
        private PictureBox pictureBox1;
        private TextBox txtCelularSaque;
        private TextBox txtEmailSaque;
        private TextBox txtCpfSaque;
        private TextBox txtNomeSaque;
        private Label lblSaldoVal;
        private Label lblSaldo;
        private Label lblSaque;
    }
}