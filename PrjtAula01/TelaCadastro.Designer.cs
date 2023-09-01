﻿namespace PrjtAula01
{
    partial class TelaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastro));
            txtNomeCad = new TextBox();
            txtCpfCad = new TextBox();
            txtRgCad = new TextBox();
            txtCelCad = new TextBox();
            txtEmailCad = new TextBox();
            txtRendaCad = new TextBox();
            txtCEPCad = new TextBox();
            txtGeneroCad = new TextBox();
            txtConfSenhaCad = new TextBox();
            txtSenhaCad = new TextBox();
            btAcessoCad = new Button();
            btVoltarCad = new Button();
            lblinserirCadastro = new Label();
            pictureBox1 = new PictureBox();
            txtValDepCad = new TextBox();
            lblDepInicial = new Label();
            lblValorMin = new Label();
            txtLogradCad = new TextBox();
            txtCidadeCad = new TextBox();
            txtNumLogCad = new TextBox();
            cbEstado = new ComboBox();
            dtpNasc = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNomeCad
            // 
            txtNomeCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeCad.Location = new Point(135, 107);
            txtNomeCad.Name = "txtNomeCad";
            txtNomeCad.PlaceholderText = "Nome Completo";
            txtNomeCad.Size = new Size(300, 29);
            txtNomeCad.TabIndex = 0;
            txtNomeCad.TextAlign = HorizontalAlignment.Center;
            txtNomeCad.TextChanged += txtNomeCad_TextChanged;
            // 
            // txtCpfCad
            // 
            txtCpfCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpfCad.Location = new Point(135, 143);
            txtCpfCad.Name = "txtCpfCad";
            txtCpfCad.PlaceholderText = "000.000.000-00";
            txtCpfCad.Size = new Size(300, 29);
            txtCpfCad.TabIndex = 1;
            txtCpfCad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRgCad
            // 
            txtRgCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRgCad.Location = new Point(135, 178);
            txtRgCad.Name = "txtRgCad";
            txtRgCad.PlaceholderText = "00.000.000-0";
            txtRgCad.Size = new Size(300, 29);
            txtRgCad.TabIndex = 2;
            txtRgCad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCelCad
            // 
            txtCelCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCelCad.Location = new Point(135, 213);
            txtCelCad.Name = "txtCelCad";
            txtCelCad.PlaceholderText = "Celular";
            txtCelCad.Size = new Size(300, 29);
            txtCelCad.TabIndex = 3;
            txtCelCad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEmailCad
            // 
            txtEmailCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailCad.Location = new Point(135, 248);
            txtEmailCad.Name = "txtEmailCad";
            txtEmailCad.PlaceholderText = "email@email.com";
            txtEmailCad.Size = new Size(300, 29);
            txtEmailCad.TabIndex = 4;
            txtEmailCad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRendaCad
            // 
            txtRendaCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRendaCad.Location = new Point(135, 493);
            txtRendaCad.Name = "txtRendaCad";
            txtRendaCad.PlaceholderText = "Renda Mensal";
            txtRendaCad.Size = new Size(300, 29);
            txtRendaCad.TabIndex = 12;
            txtRendaCad.TextAlign = HorizontalAlignment.Center;
            txtRendaCad.TextChanged += txtRendaCad_TextChanged;
            // 
            // txtCEPCad
            // 
            txtCEPCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCEPCad.Location = new Point(135, 353);
            txtCEPCad.Name = "txtCEPCad";
            txtCEPCad.PlaceholderText = "CEP";
            txtCEPCad.Size = new Size(300, 29);
            txtCEPCad.TabIndex = 7;
            txtCEPCad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtGeneroCad
            // 
            txtGeneroCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGeneroCad.Location = new Point(135, 318);
            txtGeneroCad.Name = "txtGeneroCad";
            txtGeneroCad.PlaceholderText = "Gênero";
            txtGeneroCad.Size = new Size(300, 29);
            txtGeneroCad.TabIndex = 6;
            txtGeneroCad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtConfSenhaCad
            // 
            txtConfSenhaCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfSenhaCad.Location = new Point(784, 334);
            txtConfSenhaCad.Name = "txtConfSenhaCad";
            txtConfSenhaCad.PlaceholderText = "Confirme sua senha";
            txtConfSenhaCad.Size = new Size(300, 29);
            txtConfSenhaCad.TabIndex = 15;
            txtConfSenhaCad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSenhaCad
            // 
            txtSenhaCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenhaCad.Location = new Point(784, 283);
            txtSenhaCad.Name = "txtSenhaCad";
            txtSenhaCad.PlaceholderText = "Crie sua senha";
            txtSenhaCad.Size = new Size(300, 29);
            txtSenhaCad.TabIndex = 14;
            txtSenhaCad.TextAlign = HorizontalAlignment.Center;
            // 
            // btAcessoCad
            // 
            btAcessoCad.BackColor = Color.White;
            btAcessoCad.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btAcessoCad.Location = new Point(840, 407);
            btAcessoCad.Name = "btAcessoCad";
            btAcessoCad.Size = new Size(203, 54);
            btAcessoCad.TabIndex = 16;
            btAcessoCad.Text = "Criar Acesso";
            btAcessoCad.UseVisualStyleBackColor = false;
            btAcessoCad.Click += btAcessoCad_Click;
            // 
            // btVoltarCad
            // 
            btVoltarCad.BackColor = Color.White;
            btVoltarCad.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btVoltarCad.Location = new Point(840, 493);
            btVoltarCad.Name = "btVoltarCad";
            btVoltarCad.Size = new Size(203, 54);
            btVoltarCad.TabIndex = 17;
            btVoltarCad.Text = "Voltar";
            btVoltarCad.UseVisualStyleBackColor = false;
            // 
            // lblinserirCadastro
            // 
            lblinserirCadastro.AutoSize = true;
            lblinserirCadastro.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblinserirCadastro.ForeColor = Color.White;
            lblinserirCadastro.Location = new Point(174, 43);
            lblinserirCadastro.Name = "lblinserirCadastro";
            lblinserirCadastro.Size = new Size(218, 37);
            lblinserirCadastro.TabIndex = 15;
            lblinserirCadastro.Text = "Insira seus dados";
            lblinserirCadastro.Click += lblCriarCadastro_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(547, 255);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 124);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // txtValDepCad
            // 
            txtValDepCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValDepCad.Location = new Point(784, 124);
            txtValDepCad.Name = "txtValDepCad";
            txtValDepCad.PlaceholderText = "R$ 0,00";
            txtValDepCad.Size = new Size(300, 29);
            txtValDepCad.TabIndex = 13;
            txtValDepCad.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDepInicial
            // 
            lblDepInicial.AutoSize = true;
            lblDepInicial.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblDepInicial.ForeColor = Color.White;
            lblDepInicial.Location = new Point(784, 45);
            lblDepInicial.Name = "lblDepInicial";
            lblDepInicial.Size = new Size(295, 28);
            lblDepInicial.TabIndex = 17;
            lblDepInicial.Text = "Insira o valor do seu 1º depósito";
            lblDepInicial.Click += label1_Click;
            // 
            // lblValorMin
            // 
            lblValorMin.AutoSize = true;
            lblValorMin.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorMin.ForeColor = Color.White;
            lblValorMin.Location = new Point(855, 73);
            lblValorMin.Name = "lblValorMin";
            lblValorMin.Size = new Size(161, 28);
            lblValorMin.TabIndex = 18;
            lblValorMin.Text = "(mínimo R$ 1,00)";
            // 
            // txtLogradCad
            // 
            txtLogradCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogradCad.Location = new Point(135, 388);
            txtLogradCad.Name = "txtLogradCad";
            txtLogradCad.PlaceholderText = "Logradouro";
            txtLogradCad.Size = new Size(300, 29);
            txtLogradCad.TabIndex = 8;
            txtLogradCad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCidadeCad
            // 
            txtCidadeCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCidadeCad.Location = new Point(135, 458);
            txtCidadeCad.Name = "txtCidadeCad";
            txtCidadeCad.PlaceholderText = "Cidade";
            txtCidadeCad.Size = new Size(224, 29);
            txtCidadeCad.TabIndex = 10;
            txtCidadeCad.TextAlign = HorizontalAlignment.Center;
            txtCidadeCad.TextChanged += textBox2_TextChanged;
            // 
            // txtNumLogCad
            // 
            txtNumLogCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumLogCad.Location = new Point(135, 423);
            txtNumLogCad.Name = "txtNumLogCad";
            txtNumLogCad.PlaceholderText = "Numero Logradouro";
            txtNumLogCad.Size = new Size(300, 29);
            txtNumLogCad.TabIndex = 9;
            txtNumLogCad.TextAlign = HorizontalAlignment.Center;
            txtNumLogCad.TextChanged += txtNumLogCad_TextChanged;
            // 
            // cbEstado
            // 
            cbEstado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbEstado.Location = new Point(365, 458);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(70, 29);
            cbEstado.TabIndex = 11;
            cbEstado.Text = "UF";
            cbEstado.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dtpNasc
            // 
            dtpNasc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNasc.Location = new Point(135, 283);
            dtpNasc.Name = "dtpNasc";
            dtpNasc.Size = new Size(300, 29);
            dtpNasc.TabIndex = 5;
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 143, 235);
            ClientSize = new Size(1218, 636);
            Controls.Add(dtpNasc);
            Controls.Add(cbEstado);
            Controls.Add(txtNumLogCad);
            Controls.Add(txtCidadeCad);
            Controls.Add(txtLogradCad);
            Controls.Add(lblValorMin);
            Controls.Add(lblDepInicial);
            Controls.Add(txtValDepCad);
            Controls.Add(pictureBox1);
            Controls.Add(lblinserirCadastro);
            Controls.Add(btVoltarCad);
            Controls.Add(btAcessoCad);
            Controls.Add(txtConfSenhaCad);
            Controls.Add(txtSenhaCad);
            Controls.Add(txtRendaCad);
            Controls.Add(txtCEPCad);
            Controls.Add(txtGeneroCad);
            Controls.Add(txtEmailCad);
            Controls.Add(txtCelCad);
            Controls.Add(txtRgCad);
            Controls.Add(txtCpfCad);
            Controls.Add(txtNomeCad);
            Name = "TelaCadastro";
            Text = "Tela Cadastro";
            Load += TelaCadastro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeCad;
        private TextBox txtCpfCad;
        private TextBox txtRgCad;
        private TextBox txtCelCad;
        private TextBox txtEmailCad;
        private TextBox txtRendaCad;
        private TextBox txtCEPCad;
        private TextBox txtGeneroCad;
        private TextBox txtConfSenhaCad;
        private TextBox txtSenhaCad;
        private Button btAcessoCad;
        private Button btVoltarCad;
        private Label lblinserirCadastro;
        private PictureBox pictureBox1;
        private TextBox txtValDepCad;
        private Label lblDepInicial;
        private Label lblValorMin;
        private TextBox txtLogradCad;
        private TextBox txtCidadeCad;
        private TextBox txtNumLogCad;
        private ComboBox cbEstado;
        private DateTimePicker dtpNasc;
    }
}