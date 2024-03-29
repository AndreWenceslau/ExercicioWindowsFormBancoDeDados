﻿namespace Exercicio01
{
    partial class PeixesForm
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblRaca = new System.Windows.Forms.Label();
            this.cbRaca = new System.Windows.Forms.ComboBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.mtbPreco = new System.Windows.Forms.MaskedTextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnApagarPeixe = new System.Windows.Forms.Button();
            this.btnSalavarPeixe = new System.Windows.Forms.Button();
            this.ColumnQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPeixes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeixes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(8, 26);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(135, 39);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(160, 26);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(36, 39);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "0";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(16, 142);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(108, 39);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(24, 183);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(288, 46);
            this.txtNome.TabIndex = 3;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaca.Location = new System.Drawing.Point(16, 234);
            this.lblRaca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(97, 39);
            this.lblRaca.TabIndex = 4;
            this.lblRaca.Text = "Raça";
            this.lblRaca.Click += new System.EventHandler(this.lblRaca_Click);
            // 
            // cbRaca
            // 
            this.cbRaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRaca.FormattingEnabled = true;
            this.cbRaca.Items.AddRange(new object[] {
            "Peixe Palhaço",
            "Cascudo",
            "Peixe Boi"});
            this.cbRaca.Location = new System.Drawing.Point(24, 279);
            this.cbRaca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRaca.Name = "cbRaca";
            this.cbRaca.Size = new System.Drawing.Size(288, 47);
            this.cbRaca.TabIndex = 5;
            this.cbRaca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbRaca_KeyDown_1);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(16, 331);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(106, 39);
            this.lblPreco.TabIndex = 6;
            this.lblPreco.Text = "Preço";
            this.lblPreco.Click += new System.EventHandler(this.lblPreco_Click);
            // 
            // mtbPreco
            // 
            this.mtbPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPreco.Location = new System.Drawing.Point(24, 373);
            this.mtbPreco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbPreco.Mask = "$9999.99";
            this.mtbPreco.Name = "mtbPreco";
            this.mtbPreco.Size = new System.Drawing.Size(288, 46);
            this.mtbPreco.TabIndex = 7;
            this.mtbPreco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbPreco_KeyDown);
            this.mtbPreco.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mtbPreco_MouseDoubleClick);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(16, 423);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(193, 39);
            this.lblQuantidade.TabIndex = 8;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(24, 465);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(288, 46);
            this.txtQuantidade.TabIndex = 9;
            this.txtQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantidade_KeyDown);
            // 
            // btnApagarPeixe
            // 
            this.btnApagarPeixe.Location = new System.Drawing.Point(908, 26);
            this.btnApagarPeixe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnApagarPeixe.Name = "btnApagarPeixe";
            this.btnApagarPeixe.Size = new System.Drawing.Size(143, 57);
            this.btnApagarPeixe.TabIndex = 11;
            this.btnApagarPeixe.Text = "Apagar";
            this.btnApagarPeixe.UseVisualStyleBackColor = true;
            this.btnApagarPeixe.Click += new System.EventHandler(this.btnApagarPeixe_Click);
            // 
            // btnSalavarPeixe
            // 
            this.btnSalavarPeixe.Location = new System.Drawing.Point(757, 26);
            this.btnSalavarPeixe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalavarPeixe.Name = "btnSalavarPeixe";
            this.btnSalavarPeixe.Size = new System.Drawing.Size(143, 54);
            this.btnSalavarPeixe.TabIndex = 12;
            this.btnSalavarPeixe.Text = "Salvar";
            this.btnSalavarPeixe.UseVisualStyleBackColor = true;
            this.btnSalavarPeixe.Click += new System.EventHandler(this.btnSalavarPeixe_Click);
            // 
            // ColumnQuantidade
            // 
            this.ColumnQuantidade.HeaderText = "Quantidade";
            this.ColumnQuantidade.Name = "ColumnQuantidade";
            this.ColumnQuantidade.ReadOnly = true;
            // 
            // ColumnPreco
            // 
            this.ColumnPreco.HeaderText = "Preço";
            this.ColumnPreco.Name = "ColumnPreco";
            this.ColumnPreco.ReadOnly = true;
            // 
            // ColumnRaca
            // 
            this.ColumnRaca.HeaderText = "Raça";
            this.ColumnRaca.Name = "ColumnRaca";
            this.ColumnRaca.ReadOnly = true;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            // 
            // dgvPeixes
            // 
            this.dgvPeixes.AllowUserToAddRows = false;
            this.dgvPeixes.AllowUserToDeleteRows = false;
            this.dgvPeixes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeixes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnNome,
            this.ColumnRaca,
            this.ColumnPreco,
            this.ColumnQuantidade});
            this.dgvPeixes.Location = new System.Drawing.Point(337, 90);
            this.dgvPeixes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPeixes.Name = "dgvPeixes";
            this.dgvPeixes.ReadOnly = true;
            this.dgvPeixes.Size = new System.Drawing.Size(713, 420);
            this.dgvPeixes.TabIndex = 10;
            this.dgvPeixes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeixes_CellDoubleClick);
            // 
            // PeixesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 634);
            this.Controls.Add(this.btnSalavarPeixe);
            this.Controls.Add(this.btnApagarPeixe);
            this.Controls.Add(this.dgvPeixes);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.mtbPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.cbRaca);
            this.Controls.Add(this.lblRaca);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblCodigo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PeixesForm";
            this.Text = "Peixes";
            this.Activated += new System.EventHandler(this.PeixesForm_Activated);
            this.Load += new System.EventHandler(this.PeixesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeixes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.ComboBox cbRaca;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.MaskedTextBox mtbPreco;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button btnApagarPeixe;
        private System.Windows.Forms.Button btnSalavarPeixe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridView dgvPeixes;
    }
}