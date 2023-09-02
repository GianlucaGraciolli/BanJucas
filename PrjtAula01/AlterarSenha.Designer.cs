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
            lblAlterarSenha = new Label();
            txtConfSenhaAlt = new TextBox();
            txtSenhaAlterar = new TextBox();
            salvarBotaoAltSenha = new Button();
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
            txtConfSenhaAlt.Location = new Point(136, 258);
            txtConfSenhaAlt.Name = "txtConfSenhaAlt";
            txtConfSenhaAlt.PlaceholderText = "Confirme sua nova senha";
            txtConfSenhaAlt.Size = new Size(300, 29);
            txtConfSenhaAlt.TabIndex = 34;
            txtConfSenhaAlt.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSenhaAlterar
            // 
            txtSenhaAlterar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenhaAlterar.Location = new Point(136, 163);
            txtSenhaAlterar.Name = "txtSenhaAlterar";
            txtSenhaAlterar.PlaceholderText = "Nova senha";
            txtSenhaAlterar.Size = new Size(300, 29);
            txtSenhaAlterar.TabIndex = 33;
            txtSenhaAlterar.TextAlign = HorizontalAlignment.Center;
            // 
            // salvarBotaoAltSenha
            // 
            salvarBotaoAltSenha.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            salvarBotaoAltSenha.Location = new Point(198, 325);
            salvarBotaoAltSenha.Name = "salvarBotaoAltSenha";
            salvarBotaoAltSenha.Size = new Size(175, 53);
            salvarBotaoAltSenha.TabIndex = 35;
            salvarBotaoAltSenha.Text = "Salvar";
            salvarBotaoAltSenha.UseVisualStyleBackColor = true;
            salvarBotaoAltSenha.Click += salvarBotaoAltSenha_Click;
            // 
            // AlterarSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 143, 235);
            ClientSize = new Size(573, 450);
            Controls.Add(salvarBotaoAltSenha);
            Controls.Add(txtConfSenhaAlt);
            Controls.Add(txtSenhaAlterar);
            Controls.Add(lblAlterarSenha);
            Name = "AlterarSenha";
            Text = "AlterarSenha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAlterarSenha;
        private TextBox txtConfSenhaAlt;
        private TextBox txtSenhaAlterar;
        private Button salvarBotaoAltSenha;
    }
}