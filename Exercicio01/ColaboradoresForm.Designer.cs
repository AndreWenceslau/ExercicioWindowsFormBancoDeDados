namespace Exercicio01
{
    partial class ColaboradoresForm
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
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.lblProgramador = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.dgvColaboradores = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProgramador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.ckbProgramador = new System.Windows.Forms.CheckBox();
            this.mtbSalario = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaboradores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(10, 75);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(71, 24);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            this.lblCodigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(85, 75);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 24);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "0";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(10, 108);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(62, 24);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(75, 108);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(135, 28);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(10, 142);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(47, 24);
            this.lblCPF.TabIndex = 4;
            this.lblCPF.Text = "CPF";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(10, 179);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(67, 24);
            this.lblSalario.TabIndex = 6;
            this.lblSalario.Text = "Salário";
            this.lblSalario.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // mtbCPF
            // 
            this.mtbCPF.Culture = new System.Globalization.CultureInfo("");
            this.mtbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCPF.Location = new System.Drawing.Point(75, 142);
            this.mtbCPF.Mask = "999.999.999-99";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(135, 28);
            this.mtbCPF.TabIndex = 7;
            this.mtbCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCPF_MaskInputRejected);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(10, 216);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(54, 24);
            this.lblSexo.TabIndex = 9;
            this.lblSexo.Text = "Sexo";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(10, 252);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(61, 24);
            this.lblCargo.TabIndex = 12;
            this.lblCargo.Text = "Cargo";
            this.lblCargo.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // cbCargo
            // 
            this.cbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "Padeiro",
            "Motorista "});
            this.cbCargo.Location = new System.Drawing.Point(75, 245);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(135, 30);
            this.cbCargo.TabIndex = 13;
            // 
            // lblProgramador
            // 
            this.lblProgramador.AutoSize = true;
            this.lblProgramador.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramador.Location = new System.Drawing.Point(10, 296);
            this.lblProgramador.Name = "lblProgramador";
            this.lblProgramador.Size = new System.Drawing.Size(120, 24);
            this.lblProgramador.TabIndex = 14;
            this.lblProgramador.Text = "Programador";
            // 
            // cbSexo
            // 
            this.cbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbSexo.Location = new System.Drawing.Point(75, 210);
            this.cbSexo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(135, 30);
            this.cbSexo.TabIndex = 17;
            // 
            // dgvColaboradores
            // 
            this.dgvColaboradores.AllowUserToAddRows = false;
            this.dgvColaboradores.AllowUserToDeleteRows = false;
            this.dgvColaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColaboradores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnNome,
            this.ColumnCPF,
            this.ColumnSalario,
            this.ColumnSexo,
            this.ColumnCargo,
            this.ColumnProgramador});
            this.dgvColaboradores.Location = new System.Drawing.Point(272, 6);
            this.dgvColaboradores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvColaboradores.Name = "dgvColaboradores";
            this.dgvColaboradores.ReadOnly = true;
            this.dgvColaboradores.RowTemplate.Height = 24;
            this.dgvColaboradores.Size = new System.Drawing.Size(542, 434);
            this.dgvColaboradores.TabIndex = 18;
            this.dgvColaboradores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvColaboradores_CellDoubleClick);
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnCPF
            // 
            this.ColumnCPF.HeaderText = "CPF";
            this.ColumnCPF.Name = "ColumnCPF";
            this.ColumnCPF.ReadOnly = true;
            // 
            // ColumnSalario
            // 
            this.ColumnSalario.HeaderText = "Salário";
            this.ColumnSalario.Name = "ColumnSalario";
            this.ColumnSalario.ReadOnly = true;
            // 
            // ColumnSexo
            // 
            this.ColumnSexo.HeaderText = "Sexo";
            this.ColumnSexo.Name = "ColumnSexo";
            this.ColumnSexo.ReadOnly = true;
            // 
            // ColumnCargo
            // 
            this.ColumnCargo.HeaderText = "Cargo";
            this.ColumnCargo.Name = "ColumnCargo";
            this.ColumnCargo.ReadOnly = true;
            // 
            // ColumnProgramador
            // 
            this.ColumnProgramador.HeaderText = "Programador";
            this.ColumnProgramador.Name = "ColumnProgramador";
            this.ColumnProgramador.ReadOnly = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(132, 337);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(119, 58);
            this.btnExcluir.TabIndex = 19;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(7, 337);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(119, 58);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // ckbProgramador
            // 
            this.ckbProgramador.AutoSize = true;
            this.ckbProgramador.Location = new System.Drawing.Point(132, 301);
            this.ckbProgramador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckbProgramador.Name = "ckbProgramador";
            this.ckbProgramador.Size = new System.Drawing.Size(43, 17);
            this.ckbProgramador.TabIndex = 21;
            this.ckbProgramador.Text = "Sim";
            this.ckbProgramador.UseVisualStyleBackColor = true;
            // 
            // mtbSalario
            // 
            this.mtbSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbSalario.Location = new System.Drawing.Point(75, 179);
            this.mtbSalario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbSalario.Mask = "$9999.99";
            this.mtbSalario.Name = "mtbSalario";
            this.mtbSalario.Size = new System.Drawing.Size(135, 28);
            this.mtbSalario.TabIndex = 22;
            // 
            // ColaboradoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.mtbSalario);
            this.Controls.Add(this.ckbProgramador);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvColaboradores);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.lblProgramador);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblCodigo);
            this.Name = "ColaboradoresForm";
            this.Text = "ColaboradoresForm";
            this.Load += new System.EventHandler(this.ColaboradoresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaboradores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Label lblProgramador;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.DataGridView dgvColaboradores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProgramador;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.CheckBox ckbProgramador;
        private System.Windows.Forms.MaskedTextBox mtbSalario;
    }
}