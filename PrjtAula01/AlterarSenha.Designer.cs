namespace PrjtAula01
{
    partial class AlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarSenha));
            lblAlterarSenha = new Label();
            txtConfSenhaAlt = new TextBox();
            txtSenhaAlterar = new TextBox();
            salvarBotaoAltSenha = new Button();
            txtSenhaAtual = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblAlterarSenha
            // 
            lblAlterarSenha.AutoSize = true;
            lblAlterarSenha.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlterarSenha.ForeColor = Color.White;
            lblAlterarSenha.Location = new Point(148, 33);
            lblAlterarSenha.Name = "lblAlterarSenha";
            lblAlterarSenha.Size = new Size(272, 46);
            lblAlterarSenha.TabIndex = 32;
            lblAlterarSenha.Text = "Altere sua senha:";
            // 
            // txtConfSenhaAlt
            // 
            txtConfSenhaAlt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfSenhaAlt.Location = new Point(136, 346);
            txtConfSenhaAlt.Name = "txtConfSenhaAlt";
            txtConfSenhaAlt.PlaceholderText = "Confirme sua nova senha";
            txtConfSenhaAlt.Size = new Size(300, 29);
            txtConfSenhaAlt.TabIndex = 34;
            txtConfSenhaAlt.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSenhaAlterar
            // 
            txtSenhaAlterar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenhaAlterar.Location = new Point(136, 301);
            txtSenhaAlterar.Name = "txtSenhaAlterar";
            txtSenhaAlterar.PlaceholderText = "Nova senha";
            txtSenhaAlterar.Size = new Size(300, 29);
            txtSenhaAlterar.TabIndex = 33;
            txtSenhaAlterar.TextAlign = HorizontalAlignment.Center;
            // 
            // salvarBotaoAltSenha
            // 
            salvarBotaoAltSenha.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            salvarBotaoAltSenha.Location = new Point(207, 395);
            salvarBotaoAltSenha.Name = "salvarBotaoAltSenha";
            salvarBotaoAltSenha.Size = new Size(175, 53);
            salvarBotaoAltSenha.TabIndex = 35;
            salvarBotaoAltSenha.Text = "Salvar";
            salvarBotaoAltSenha.UseVisualStyleBackColor = true;
            salvarBotaoAltSenha.Click += salvarBotaoAltSenha_Click;
            // 
            // txtSenhaAtual
            // 
            txtSenhaAtual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenhaAtual.Location = new Point(136, 108);
            txtSenhaAtual.Name = "txtSenhaAtual";
            txtSenhaAtual.PlaceholderText = "Digite sua senha atual";
            txtSenhaAtual.Size = new Size(300, 29);
            txtSenhaAtual.TabIndex = 36;
            txtSenhaAtual.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(227, 156);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 124);
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // AlterarSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 143, 235);
            ClientSize = new Size(573, 450);
            Controls.Add(pictureBox1);
            Controls.Add(txtSenhaAtual);
            Controls.Add(salvarBotaoAltSenha);
            Controls.Add(txtConfSenhaAlt);
            Controls.Add(txtSenhaAlterar);
            Controls.Add(lblAlterarSenha);
            Name = "AlterarSenha";
            Text = "AlterarSenha";
            Load += AlterarSenha_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAlterarSenha;
        private TextBox txtConfSenhaAlt;
        private TextBox txtSenhaAlterar;
        private Button salvarBotaoAltSenha;
        private TextBox txtSenhaAtual;
        private PictureBox pictureBox1;
    }
}