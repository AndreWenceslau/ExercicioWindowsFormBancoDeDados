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
            this.lblID = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.rbdMasculino = new System.Windows.Forms.RadioButton();
            this.rbdFeminino = new System.Windows.Forms.RadioButton();
            this.lblCargo = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtProgramadorTrue = new System.Windows.Forms.RadioButton();
            this.rbtProgramadorFalse = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            this.lblCodigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(51, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(13, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "0";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(12, 65);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 4;
            this.lblCPF.Text = "CPF";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(12, 94);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 6;
            this.lblSalario.Text = "Salário";
            this.lblSalario.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(54, 58);
            this.mtbCPF.Mask = "999.999.999-99";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(100, 20);
            this.mtbCPF.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(54, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(12, 123);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 9;
            this.lblSexo.Text = "Sexo";
            // 
            // rbdMasculino
            // 
            this.rbdMasculino.AutoSize = true;
            this.rbdMasculino.Location = new System.Drawing.Point(54, 123);
            this.rbdMasculino.Name = "rbdMasculino";
            this.rbdMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbdMasculino.TabIndex = 10;
            this.rbdMasculino.TabStop = true;
            this.rbdMasculino.Text = "Masculino";
            this.rbdMasculino.UseVisualStyleBackColor = true;
            // 
            // rbdFeminino
            // 
            this.rbdFeminino.AutoSize = true;
            this.rbdFeminino.Location = new System.Drawing.Point(133, 123);
            this.rbdFeminino.Name = "rbdFeminino";
            this.rbdFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbdFeminino.TabIndex = 11;
            this.rbdFeminino.TabStop = true;
            this.rbdFeminino.Text = "Feminino";
            this.rbdFeminino.UseVisualStyleBackColor = true;
            this.rbdFeminino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(12, 151);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 12;
            this.lblCargo.Text = "Cargo";
            this.lblCargo.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // cbCargo
            // 
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(54, 148);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(121, 21);
            this.cbCargo.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // rbtProgramadorTrue
            // 
            this.rbtProgramadorTrue.AutoSize = true;
            this.rbtProgramadorTrue.Location = new System.Drawing.Point(54, 182);
            this.rbtProgramadorTrue.Name = "rbtProgramadorTrue";
            this.rbtProgramadorTrue.Size = new System.Drawing.Size(42, 17);
            this.rbtProgramadorTrue.TabIndex = 15;
            this.rbtProgramadorTrue.TabStop = true;
            this.rbtProgramadorTrue.Text = "Sim";
            this.rbtProgramadorTrue.UseVisualStyleBackColor = true;
            // 
            // rbtProgramadorFalse
            // 
            this.rbtProgramadorFalse.AutoSize = true;
            this.rbtProgramadorFalse.Location = new System.Drawing.Point(130, 182);
            this.rbtProgramadorFalse.Name = "rbtProgramadorFalse";
            this.rbtProgramadorFalse.Size = new System.Drawing.Size(45, 17);
            this.rbtProgramadorFalse.TabIndex = 16;
            this.rbtProgramadorFalse.TabStop = true;
            this.rbtProgramadorFalse.Text = "Não";
            this.rbtProgramadorFalse.UseVisualStyleBackColor = true;
            // 
            // ColaboradoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtProgramadorFalse);
            this.Controls.Add(this.rbtProgramadorTrue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.rbdFeminino);
            this.Controls.Add(this.rbdMasculino);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblCodigo);
            this.Name = "ColaboradoresForm";
            this.Text = "ColaboradoresForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.RadioButton rbdMasculino;
        private System.Windows.Forms.RadioButton rbdFeminino;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtProgramadorTrue;
        private System.Windows.Forms.RadioButton rbtProgramadorFalse;
    }
}