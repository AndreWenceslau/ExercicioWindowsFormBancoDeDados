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
                Alterar();
            }
        }
        private void Inserir()
        {
            PeixeClasse peixe = new PeixeClasse();
            peixe.Nome = txtNome.Text;
            peixe.Raca = cbRaca.SelectedItem.ToString();
            peixe.Preco = Convert.ToDecimal(mtbPreco.Text.Replace("R$",""));
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
                peixe.Quantidade = Convert.ToInt32(linha["quantidade"]);
                dgvPeixes.Rows.Add(new string[] { peixe.Id.ToString(), peixe.Nome, peixe.Raca, peixe.Preco.ToString(), peixe.Quantidade.ToString() });
            }
        }
        private void Alterar()
        {
            PeixeClasse peixe = new PeixeClasse();
            peixe.Id = Convert.ToInt32(lblId.Text);
            peixe.Nome = Convert.ToString(txtNome.Text);
            peixe.Raca = cbRaca.SelectedItem.ToString();
            peixe.Preco = Convert.ToDecimal(mtbPreco.Text.Replace("R$",""));
            peixe.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Banco-de-Dados.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE peixes SET nome = @NOME, raca = @RACA, preco = @PRECO, quantidade = @QUANTIDADE WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", peixe.Id);
            comando.Parameters.AddWithValue("@NOME", peixe.Nome);
            comando.Parameters.AddWithValue("@RACA", peixe.Raca);
            comando.Parameters.AddWithValue("@PRECO", peixe.Preco);
            comando.Parameters.AddWithValue("@QUANTIDADE", peixe.Quantidade);
            comando.ExecuteNonQuery();
            conexao.Close();
            AtualizarTabela();
            LimparCampos();
        }



        private void lblPreco_Click(object sender, EventArgs e)
        {

        }

        private void PeixesForm_Activated(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void dgvPeixes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvPeixes.CurrentRow.Cells[0].Value);
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Banco-de-Dados.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.CommandText = @"SELECT id, nome, raca, preco, quantidade FROM peixes WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.Connection = conexao;
            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            DataRow linha = tabela.Rows[0];
            PeixeClasse peixe = new PeixeClasse();
            peixe.Id = Convert.ToInt32(linha["id"]);
            peixe.Nome = linha["nome"].ToString();
            peixe.Raca = linha["raca"].ToString();
            peixe.Preco = Convert.ToDecimal(linha["preco"].ToString());
            peixe.Quantidade = Convert.ToInt32(linha["quantidade"].ToString());

            lblId.Text = peixe.Id.ToString();
            txtNome.Text = peixe.Nome.ToString();
            cbRaca.SelectedItem = peixe.Raca.ToString();
            mtbPreco.Text = peixe.Preco.ToString("0000.00");
            txtQuantidade.Text = peixe.Quantidade.ToString();
            conexao.Close();

        }

        private void PeixesForm_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void btnApagarPeixe_Click(object sender, EventArgs e)
        {
            if (dgvPeixes.CurrentRow.Index == -1)
            {
                MessageBox.Show("Cadastre um veiculo");
                return;
            }
            DialogResult caixaDialogo = MessageBox.Show("Deseja Realmente apagar?", "AVISO", MessageBoxButtons.YesNo);
            if (caixaDialogo == DialogResult.Yes)
            {
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Banco-de-Dados.mdf;Integrated Security=True;Connect Timeout=30";
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = @"DELETE FROM peixes WHERE id =@ID";
                
                lblId.Text = "0";
                txtNome.Clear();
                cbRaca.SelectedIndex = -1;
                mtbPreco.Clear();
                txtQuantidade.Clear();
                int id = Convert.ToInt32(dgvPeixes.CurrentRow.Cells[0].Value);
                comando.Parameters.AddWithValue("@ID", id);
                comando.ExecuteNonQuery();
                conexao.Close();

                AtualizarTabela();
            }
            


        }
    }
}
