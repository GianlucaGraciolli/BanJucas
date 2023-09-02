namespace PrjtAula01
{
    partial class AlterarDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarDados));
            pictureBox1 = new PictureBox();
            dtpNascAlt = new DateTimePicker();
            cbEstadoAlt = new ComboBox();
            txtNumLogAlt = new TextBox();
            txtCidadeAlt = new TextBox();
            txtLogradAlt = new TextBox();
            txtRendaAlt = new TextBox();
            txtCEPAlt = new TextBox();
            txtGeneroAlt = new TextBox();
            txtEmailAlt = new TextBox();
            txtCelAlt = new TextBox();
            txtRgAlt = new TextBox();
            txtCpfAlt = new TextBox();
            txtNomeAlt = new TextBox();
            lblinserirCadastro = new Label();
            limparBotaoAlt = new Button();
            salvarBotaoAlt = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(176, 363);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 124);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // dtpNascAlt
            // 
            dtpNascAlt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNascAlt.Location = new Point(726, 189);
            dtpNascAlt.Name = "dtpNascAlt";
            dtpNascAlt.Size = new Size(300, 29);
            dtpNascAlt.TabIndex = 23;
            // 
            // cbEstadoAlt
            // 
            cbEstadoAlt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbEstadoAlt.FormattingEnabled = true;
            cbEstadoAlt.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbEstadoAlt.Location = new Point(641, 288);
            cbEstadoAlt.Name = "cbEstadoAlt";
            cbEstadoAlt.Size = new Size(70, 29);
            cbEstadoAlt.TabIndex = 29;
            cbEstadoAlt.Text = "UF";
            // 
            // txtNumLogAlt
            // 
            txtNumLogAlt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumLogAlt.Location = new Point(95, 288);
            txtNumLogAlt.Name = "txtNumLogAlt";
            txtNumLogAlt.PlaceholderText = "Numero Logradouro";
            txtNumLogAlt.Size = new Size(300, 29);
            txtNumLogAlt.TabIndex = 27;
            txtNumLogAlt.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCidadeAlt
            // 
            txtCidadeAlt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCidadeAlt.Location = new Point(411, 288);
            txtCidadeAlt.Name = "txtCidadeAlt";
            txtCidadeAlt.PlaceholderText = "Cidade";
            txtCidadeAlt.Size = new Size(224, 29);
            txtCidadeAlt.TabIndex = 28;
            txtCidadeAlt.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLogradAlt
            // 
            txtLogradAlt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogradAlt.Location = new Point(726, 242);
            txtLogradAlt.Name = "txtLogradAlt";
            txtLogradAlt.PlaceholderText = "Logradouro";
            txtLogradAlt.Size = new Size(300, 29);
            txtLogradAlt.TabIndex = 26;
            txtLogradAlt.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRendaAlt
            // 
            txtRendaAlt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRendaAlt.Location = new Point(726, 288);
            txtRendaAlt.Name = "txtRendaAlt";
            txtRendaAlt.PlaceholderText = "Renda Mensal";
            txtRendaAlt.Size = new Size(300, 29);
            txtRendaAlt.TabIndex = 30;
            txtRendaAlt.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCEPAlt
            // 
            txtCEPAlt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCEPAlt.Location = new Point(411, 242);
            txtCEPAlt.Name = "txtCEPAlt";
            txtCEPAlt.PlaceholderText = "CEP";
            txtCEPAlt.Size = new Size(300, 29);
            txtCEPAlt.TabIndex = 25;
            txtCEPAlt.TextAlign = HorizontalAlignment.Center;
            // 
            // txtGeneroAlt
            // 
            txtGeneroAlt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGeneroAlt.Location = new Point(95, 242);
            txtGeneroAlt.Name = "txtGeneroAlt";
            txtGeneroAlt.PlaceholderText = "Gênero";
            txtGeneroAlt.Size = new Size(300, 29);
            txtGeneroAlt.TabIndex = 24;
            txtGeneroAlt.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEmailAlt
            // 
            txtEmailAlt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailAlt.Location = new Point(411, 192);
            txtEmailAlt.Name = "txtEmailAlt";
            txtEmailAlt.PlaceholderText = "email@email.com";
            txtEmailAlt.Size = new Size(300, 29);
            txtEmailAlt.TabIndex = 22;
            txtEmailAlt.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCelAlt
            // 
            txtCelAlt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCelAlt.Location = new Point(95, 192);
            txtCelAlt.Name = "txtCelAlt";
            txtCelAlt.PlaceholderText = "Celular";
            txtCelAlt.Size = new Size(300, 29);
            txtCelAlt.TabIndex = 21;
            txtCelAlt.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRgAlt
            // 
            txtRgAlt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRgAlt.Location = new Point(726, 147);
            txtRgAlt.Name = "txtRgAlt";
            txtRgAlt.PlaceholderText = "00.000.000-0";
            txtRgAlt.Size = new Size(300, 29);
            txtRgAlt.TabIndex = 20;
            txtRgAlt.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCpfAlt
            // 
            txtCpfAlt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpfAlt.Location = new Point(411, 147);
            txtCpfAlt.Name = "txtCpfAlt";
            txtCpfAlt.PlaceholderText = "000.000.000-00";
            txtCpfAlt.Size = new Size(300, 29);
            txtCpfAlt.TabIndex = 19;
            txtCpfAlt.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNomeAlt
            // 
            txtNomeAlt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeAlt.Location = new Point(95, 147);
            txtNomeAlt.Name = "txtNomeAlt";
            txtNomeAlt.PlaceholderText = "Nome Completo";
            txtNomeAlt.Size = new Size(300, 29);
            txtNomeAlt.TabIndex = 18;
            txtNomeAlt.TextAlign = HorizontalAlignment.Center;
            // 
            // lblinserirCadastro
            // 
            lblinserirCadastro.AutoSize = true;
            lblinserirCadastro.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblinserirCadastro.ForeColor = Color.White;
            lblinserirCadastro.Location = new Point(420, 50);
            lblinserirCadastro.Name = "lblinserirCadastro";
            lblinserirCadastro.Size = new Size(291, 46);
            lblinserirCadastro.TabIndex = 31;
            lblinserirCadastro.Text = "Altere seus dados:";
            // 
            // limparBotaoAlt
            // 
            limparBotaoAlt.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            limparBotaoAlt.Location = new Point(489, 398);
            limparBotaoAlt.Name = "limparBotaoAlt";
            limparBotaoAlt.Size = new Size(175, 53);
            limparBotaoAlt.TabIndex = 32;
            limparBotaoAlt.Text = "Limpar";
            limparBotaoAlt.UseVisualStyleBackColor = true;
            // 
            // salvarBotaoAlt
            // 
            salvarBotaoAlt.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            salvarBotaoAlt.Location = new Point(801, 398);
            salvarBotaoAlt.Name = "salvarBotaoAlt";
            salvarBotaoAlt.Size = new Size(175, 53);
            salvarBotaoAlt.TabIndex = 33;
            salvarBotaoAlt.Text = "Salvar";
            salvarBotaoAlt.UseVisualStyleBackColor = true;
            // 
            // AlterarDados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 143, 235);
            ClientSize = new Size(1106, 553);
            Controls.Add(salvarBotaoAlt);
            Controls.Add(limparBotaoAlt);
            Controls.Add(lblinserirCadastro);
            Controls.Add(dtpNascAlt);
            Controls.Add(cbEstadoAlt);
            Controls.Add(txtNumLogAlt);
            Controls.Add(txtCidadeAlt);
            Controls.Add(txtLogradAlt);
            Controls.Add(txtRendaAlt);
            Controls.Add(txtCEPAlt);
            Controls.Add(txtGeneroAlt);
            Controls.Add(txtEmailAlt);
            Controls.Add(txtCelAlt);
            Controls.Add(txtRgAlt);
            Controls.Add(txtCpfAlt);
            Controls.Add(txtNomeAlt);
            Controls.Add(pictureBox1);
            Name = "AlterarDados";
            Text = "AlterarDados";
            Load += AlterarDados_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DateTimePicker dtpNascAlt;
        private ComboBox cbEstadoAlt;
        private TextBox txtNumLogAlt;
        private TextBox txtCidadeAlt;
        private TextBox txtLogradAlt;
        private TextBox txtRendaAlt;
        private TextBox txtCEPAlt;
        private TextBox txtGeneroAlt;
        private TextBox txtEmailAlt;
        private TextBox txtCelAlt;
        private TextBox txtRgAlt;
        private TextBox txtCpfAlt;
        private TextBox txtNomeAlt;
        private Label lblinserirCadastro;
        private Button limparBotaoAlt;
        private Button salvarBotaoAlt;
    }
}