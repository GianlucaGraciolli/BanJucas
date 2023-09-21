namespace PrjtAula01
{
    partial class TelaCriarConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCriarConta));
            pictureBox1 = new PictureBox();
            lblValorMin = new Label();
            lblDepInicial = new Label();
            txtValDepCad = new TextBox();
            txtConfSenhaConta = new TextBox();
            txtSenhaConta = new TextBox();
            bttCriarConta = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(336, 185);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 124);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // lblValorMin
            // 
            lblValorMin.AutoSize = true;
            lblValorMin.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorMin.ForeColor = Color.White;
            lblValorMin.Location = new Point(317, 99);
            lblValorMin.Name = "lblValorMin";
            lblValorMin.Size = new Size(161, 28);
            lblValorMin.TabIndex = 23;
            lblValorMin.Text = "(mínimo R$ 1,00)";
            // 
            // lblDepInicial
            // 
            lblDepInicial.AutoSize = true;
            lblDepInicial.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblDepInicial.ForeColor = Color.White;
            lblDepInicial.Location = new Point(246, 71);
            lblDepInicial.Name = "lblDepInicial";
            lblDepInicial.Size = new Size(295, 28);
            lblDepInicial.TabIndex = 22;
            lblDepInicial.Text = "Insira o valor do seu 1º depósito";
            // 
            // txtValDepCad
            // 
            txtValDepCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValDepCad.Location = new Point(246, 146);
            txtValDepCad.Name = "txtValDepCad";
            txtValDepCad.PlaceholderText = "R$ 0,00";
            txtValDepCad.Size = new Size(300, 29);
            txtValDepCad.TabIndex = 19;
            txtValDepCad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtConfSenhaConta
            // 
            txtConfSenhaConta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfSenhaConta.Location = new Point(246, 367);
            txtConfSenhaConta.MaxLength = 6;
            txtConfSenhaConta.Name = "txtConfSenhaConta";
            txtConfSenhaConta.PlaceholderText = "Confirme sua senha";
            txtConfSenhaConta.Size = new Size(300, 29);
            txtConfSenhaConta.TabIndex = 21;
            txtConfSenhaConta.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSenhaConta
            // 
            txtSenhaConta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenhaConta.Location = new Point(246, 316);
            txtSenhaConta.MaxLength = 6;
            txtSenhaConta.Name = "txtSenhaConta";
            txtSenhaConta.PlaceholderText = "Crie a senha da sua conta";
            txtSenhaConta.Size = new Size(300, 29);
            txtSenhaConta.TabIndex = 20;
            txtSenhaConta.TextAlign = HorizontalAlignment.Center;
            // 
            // bttCriarConta
            // 
            bttCriarConta.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            bttCriarConta.Location = new Point(349, 414);
            bttCriarConta.Name = "bttCriarConta";
            bttCriarConta.Size = new Size(108, 46);
            bttCriarConta.TabIndex = 24;
            bttCriarConta.Text = "Criar Conta";
            bttCriarConta.UseVisualStyleBackColor = true;
            bttCriarConta.Click += bttCriarConta_Click;
            // 
            // TelaCriarConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 143, 235);
            ClientSize = new Size(765, 503);
            Controls.Add(bttCriarConta);
            Controls.Add(lblValorMin);
            Controls.Add(lblDepInicial);
            Controls.Add(txtValDepCad);
            Controls.Add(txtConfSenhaConta);
            Controls.Add(txtSenhaConta);
            Controls.Add(pictureBox1);
            Name = "TelaCriarConta";
            Text = "TelaCriarConta";
            Load += TelaCriarConta_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblValorMin;
        private Label lblDepInicial;
        private TextBox txtValDepCad;
        private TextBox txtConfSenhaConta;
        private TextBox txtSenhaConta;
        private Button bttCriarConta;
    }
}