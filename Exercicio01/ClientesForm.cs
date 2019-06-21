using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio01
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void lblTelefone_Click(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
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
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Cpf = mtbCpf.Text;
            cliente.Salario = Convert.ToDecimal(mtbSalario.Text.Replace("R$", ""));
            cliente.Telefone = mtbSalario.Text;
            cliente.Estado = txtEstado.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Cep = mtbCep.Text;
            cliente.Logradouro = txtLogradouro.Text;
            cliente.Numero = Convert.ToInt32(txtNumero.Text);
            cliente.Complexo = txtComplexo.Text;
            cliente.Nome_sujo = ckbNomeSujo.Checked;
            cliente.Altura = Convert.ToDecimal(txtAltura.Text);
            cliente.Peso = Convert.ToDecimal(txtPeso.Text);

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @""; //Colocar o Banco
            conexao.Open();

        }
    }
}
