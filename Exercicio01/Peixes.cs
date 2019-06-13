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
    public partial class PeixesForm : Form
    {
        public PeixesForm()
        {
            InitializeComponent();
        }

        private void lblRaca_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void btnSalavarPeixe_Click(object sender, EventArgs e)
        {
            if (lblId.Text == "0")
            {
                Inserir();
            }
            else
            {
                //Alterar();
            }
        }
        private void Inserir()
        {
            PeixeClasse peixe = new PeixeClasse();
            peixe.Nome = txtNome.Text;
            peixe.Raca = cbRaca.SelectedItem.ToString();
            peixe.Preco = Convert.ToDecimal(mtbPreco.Text);
            peixe.Quantidade = Convert.ToInt32(txtQuantidade.Text);

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Banco-de-Dados.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO peixes(nome,raca,preco,quantidade) VALUES(@NOME,@RACA,@PRECO,@QUANTIDADE)";
            comando.Parameters.AddWithValue("@NOME", peixe.Nome);
            comando.Parameters.AddWithValue("@RACA", peixe.Raca);
            comando.Parameters.AddWithValue("@PRECO", peixe.Preco);
            comando.Parameters.AddWithValue("@QUANTIDADE", peixe.Quantidade);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro salvo com sucesso");
            LimparCampos();
            conexao.Close();
            AtualizarTabela();



        }
        private void LimparCampos()
        {
            lblId.Text = "0";
            txtNome.Clear();
            cbRaca.SelectedIndex = -1;
            mtbPreco.Clear();
            txtQuantidade.Clear();
        }
        private void AtualizarTabela()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Banco-de-Dados.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT id,nome,raca,preco,quantidade FROM peixes";

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            dgvPeixes.RowCount = 0;
            for (int i = 0; i < tabela.Rows.Count; i++) 
            {
                DataRow linha = tabela.Rows[i];
                PeixeClasse peixe = new PeixeClasse();
                peixe.Id = Convert.ToInt32(linha["id"]);
                peixe.Nome = linha["nome"].ToString();
                peixe.Raca = linha["raca"].ToString();
                peixe.Preco = Convert.ToDecimal(linha["preco"]);
                peixe.Preco = Convert.ToInt32(linha["quantidade"]);
                dgvPeixes.Rows.Add(new string[] {peixe.Id.ToString(),peixe.Nome,peixe.Raca,peixe.Preco.ToDecimal(), 
}

            }
        }

        private void lblPreco_Click(object sender, EventArgs e)
        {

        }
    }
}
