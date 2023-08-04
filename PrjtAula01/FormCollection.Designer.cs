namespace PrjtAula01
{
    partial class FormCollection
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
            txtId = new TextBox();
            txtnomecliente = new TextBox();
            Btnadicionar = new Button();
            Btnlistar = new Button();
            Lstinfo = new ListBox();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(12, 23);
            txtId.Name = "txtId";
            txtId.Size = new Size(40, 23);
            txtId.TabIndex = 0;
            // 
            // txtnomecliente
            // 
            txtnomecliente.Location = new Point(12, 61);
            txtnomecliente.Name = "txtnomecliente";
            txtnomecliente.Size = new Size(422, 23);
            txtnomecliente.TabIndex = 1;
            // 
            // Btnadicionar
            // 
            Btnadicionar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Btnadicionar.Location = new Point(53, 108);
            Btnadicionar.Name = "Btnadicionar";
            Btnadicionar.Size = new Size(103, 32);
            Btnadicionar.TabIndex = 3;
            Btnadicionar.Text = "Adicionar";
            Btnadicionar.UseVisualStyleBackColor = true;
            // 
            // Btnlistar
            // 
            Btnlistar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Btnlistar.Location = new Point(271, 108);
            Btnlistar.Name = "Btnlistar";
            Btnlistar.Size = new Size(103, 32);
            Btnlistar.TabIndex = 4;
            Btnlistar.Text = "Listar";
            Btnlistar.UseVisualStyleBackColor = true;
            // 
            // Lstinfo
            // 
            Lstinfo.FormattingEnabled = true;
            Lstinfo.ItemHeight = 15;
            Lstinfo.Location = new Point(12, 170);
            Lstinfo.Name = "Lstinfo";
            Lstinfo.Size = new Size(422, 244);
            Lstinfo.TabIndex = 5;
            // 
            // FormCollection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 450);
            Controls.Add(Lstinfo);
            Controls.Add(Btnlistar);
            Controls.Add(Btnadicionar);
            Controls.Add(txtnomecliente);
            Controls.Add(txtId);
            Name = "FormCollection";
            Text = "FormCollection";
            Load += FormCollection_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtnomecliente;
        private Button Btnadicionar;
        private Button Btnlistar;
        private ListBox Lstinfo;
    }
}