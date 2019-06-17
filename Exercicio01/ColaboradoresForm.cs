using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio01
{
    public partial class ColaboradoresForm : Form
    {
        public ColaboradoresForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(lblId.Text == "0")
            {
                //Inserir();
            }
            else
            {
                //Alterar();
            }
        }
        private void Inserir()
        {
            ColaboradoresClasse colaboradores = new ColaboradoresClasse();
            colaboradores.Nome = txtNome.Text;
            colaboradores.Cpf = mtbCPF.Text;
            colaboradores.Salario = Convert.ToDecimal(txtSalario.Text);
            colaboradores.Sexo = cbCargo.SelectedItem.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtbCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
