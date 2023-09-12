namespace PrjtAula01
{
    partial class AlterarConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarConta));
            lblAlterarContas = new Label();
            cbContas = new ComboBox();
            label1 = new Label();
            txtSenhaContaAlt = new TextBox();
            pictureBox1 = new PictureBox();
            btAlterarConta = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblAlterarContas
            // 
            lblAlterarContas.AutoSize = true;
            lblAlterarContas.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlterarContas.ForeColor = Color.White;
            lblAlterarContas.Location = new Point(28, 133);
            lblAlterarContas.Name = "lblAlterarContas";
            lblAlterarContas.Size = new Size(188, 28);
            lblAlterarContas.TabIndex = 33;
            lblAlterarContas.Text = "Alterar para a conta:";
            // 
            // cbContas
            // 
            cbContas.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbContas.FormattingEnabled = true;
            cbContas.Location = new Point(222, 136);
            cbContas.Name = "cbContas";
            cbContas.Size = new Size(90, 25);
            cbContas.TabIndex = 34;
            cbContas.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(66, 218);
            label1.Name = "label1";
            label1.Size = new Size(150, 28);
            label1.TabIndex = 35;
            label1.Text = "Senha da conta:";
            // 
            // txtSenhaContaAlt
            // 
            txtSenhaContaAlt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenhaContaAlt.Location = new Point(222, 223);
            txtSenhaContaAlt.MaxLength = 6;
            txtSenhaContaAlt.Name = "txtSenhaContaAlt";
            txtSenhaContaAlt.Size = new Size(90, 25);
            txtSenhaContaAlt.TabIndex = 36;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(411, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 124);
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // btAlterarConta
            // 
            btAlterarConta.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btAlterarConta.Location = new Point(222, 285);
            btAlterarConta.Name = "btAlterarConta";
            btAlterarConta.Size = new Size(90, 28);
            btAlterarConta.TabIndex = 39;
            btAlterarConta.Text = "Alterar";
            btAlterarConta.UseVisualStyleBackColor = true;
            btAlterarConta.Click += btAlterarConta_Click;
            // 
            // AlterarConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 143, 235);
            ClientSize = new Size(576, 410);
            Controls.Add(btAlterarConta);
            Controls.Add(pictureBox1);
            Controls.Add(txtSenhaContaAlt);
            Controls.Add(label1);
            Controls.Add(cbContas);
            Controls.Add(lblAlterarContas);
            Name = "AlterarConta";
            Text = "AlterarConta";
            Load += AlterarConta_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAlterarContas;
        private ComboBox cbContas;
        private Label label1;
        private TextBox txtSenhaContaAlt;
        private PictureBox pictureBox1;
        private Button btAlterarConta;
    }
}