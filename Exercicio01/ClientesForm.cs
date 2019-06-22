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
        private void btnSalvar_Click(object sender, EventArgs e)
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
        string texto = "";
        private void Inserir()
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Cpf = mtbCpf.Text;
            cliente.Salario = Convert.ToDecimal(mtbSalario.Text.Replace("R$", ""));
            cliente.Telefone = mtbTelefone.Text;
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
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre\Documents\banco-de-dados.mdf;Integrated Security=True;Connect Timeout=30"; //Colocar o Banco
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO clientes(nome,cpf,salario,telefone,estado,cidade,bairro,cep,logradouro,numero,complexo,nome_sujo,altura,peso) VALUES(@NOME,@CPF,@SALARIO,@TELEFONE,@ESTADO,@CIDADE,@BAIRRO,@CEP,@LOGRADOURO,@NUMERO,@COMPLEXO,@NOME_SUJO,@ALTURA,@PESO)";

            comando.Parameters.AddWithValue("@NOME", cliente.Nome);
            comando.Parameters.AddWithValue("@CPF", cliente.Cpf);
            comando.Parameters.AddWithValue("@SALARIO", cliente.Salario);
            comando.Parameters.AddWithValue("@TELEFONE", cliente.Telefone);
            comando.Parameters.AddWithValue("@ESTADO", cliente.Estado);
            comando.Parameters.AddWithValue("@CIDADE", cliente.Cidade);
            comando.Parameters.AddWithValue("@BAIRRO", cliente.Bairro);
            comando.Parameters.AddWithValue("@CEP", cliente.Cep);
            comando.Parameters.AddWithValue("@LOGRADOURO", cliente.Logradouro);
            comando.Parameters.AddWithValue("@NUMERO", cliente.Numero);
            comando.Parameters.AddWithValue("@COMPLEXO", cliente.Complexo);
            comando.Parameters.AddWithValue("@NOME_SUJO", cliente.Nome_sujo);
            comando.Parameters.AddWithValue("@ALTURA", cliente.Altura);
            comando.Parameters.AddWithValue("@PESO", cliente.Peso);
            comando.ExecuteNonQuery();
            MessageBox.Show("Salvo com sucesso");
            LimparCampos();
            conexao.Close();
            AtualizarTabela();
        }
        private void LimparCampos()
        {
            lblId.Text = "0";
            txtNome.Clear();
            mtbCpf.Clear();
            mtbSalario.Clear();
            mtbTelefone.Clear();
            txtEstado.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            mtbCep.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtComplexo.Clear();
            ckbNomeSujo.Checked = false;//Pode estar errado
            txtAltura.Clear();
            txtPeso.Clear();
        }
        private void AtualizarTabela()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre\Documents\banco-de-dados.mdf;Integrated Security=True;Connect Timeout=30"; //Colocar o banco
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT id,nome,cpf,salario,telefone,estado,cidade,bairro,cep,logradouro,numero,complexo,nome_sujo,altura,peso FROM clientes";

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            dgvClientes.RowCount = 0;
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                Cliente cliente = new Cliente();
                cliente.Id = Convert.ToInt32(linha["id"]);
                cliente.Nome = linha["nome"].ToString();
                cliente.Cpf = linha["cpf"].ToString();
                cliente.Salario = Convert.ToDecimal(linha["salario"]);
                cliente.Telefone = linha["telefone"].ToString();
                cliente.Estado = linha["estado"].ToString();
                cliente.Cidade = linha["cidade"].ToString();
                cliente.Bairro = linha["bairro"].ToString();
                cliente.Cep = linha["cep"].ToString();
                cliente.Logradouro = linha["logradouro"].ToString();
                cliente.Numero = Convert.ToInt32(linha["numero"]);
                cliente.Complexo = linha["complexo"].ToString();
                cliente.Nome_sujo = Convert.ToBoolean(linha["nome_sujo"]);
                if (cliente.Nome_sujo == true)
                {
                    texto = "sim";
                }
                else
                {
                    texto = "não";
                }
                cliente.Altura = Convert.ToDecimal(linha["altura"]);
                cliente.Peso = Convert.ToDecimal(linha["peso"]);

                dgvClientes.Rows.Add(new string[] { cliente.Id.ToString(), cliente.Nome.ToString(), cliente.Cpf.ToString(), cliente.Salario.ToString(), cliente.Telefone.ToString(), cliente.Estado.ToString(), cliente.Cidade.ToString(), cliente.Bairro.ToString(), cliente.Cep.ToString(), cliente.Logradouro.ToString(), cliente.Numero.ToString(), cliente.Complexo.ToString(), texto, cliente.Altura.ToString(), cliente.Peso.ToString() });
            }

        }
        private void Alterar()
        {
            Cliente cliente = new Cliente();
            cliente.Id = Convert.ToInt32(lblId.Text);
            cliente.Nome = Convert.ToString(txtNome.Text);
            cliente.Cpf = Convert.ToString(mtbCpf.Text);
            cliente.Salario = Convert.ToDecimal(mtbSalario.Text.Replace("R$", ""));
            cliente.Telefone = Convert.ToString(mtbTelefone.Text);
            cliente.Estado = Convert.ToString(txtEstado.Text);
            cliente.Cidade = Convert.ToString(txtCidade.Text);
            cliente.Bairro = Convert.ToString(txtBairro.Text);
            cliente.Cep = Convert.ToString(mtbCep.Text);
            cliente.Logradouro = Convert.ToString(txtLogradouro.Text);
            cliente.Numero = Convert.ToInt32(txtNumero.Text);
            if (ckbNomeSujo.Checked)
            {
                cliente.Nome_sujo = true;
            }
            else
            {
                cliente.Nome_sujo = false;
            }
            cliente.Complexo = Convert.ToString(txtComplexo.Text);
            cliente.Altura = Convert.ToDecimal(txtAltura.Text);
            cliente.Peso = Convert.ToDecimal(txtPeso.Text);

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre\Documents\banco-de-dados.mdf;Integrated Security=True;Connect Timeout=30"; // Colocar o Banco
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE clientes SET nome= @NOME,cpf = @CPF, salario = @SALARIO, telefone = @TELEFONE, estado = @ESTADO, cidade = @CIDADE, bairro = @BAIRRO, cep = @CEP,logradouro = @LOGRADOURO, numero = @Numero, nome_sujo = @NOME_SUJO, complexo = @COMPLEXO, altura = @ALTURA, peso = @PESO WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", cliente.Id);
            comando.Parameters.AddWithValue("@NOME", cliente.Nome);
            comando.Parameters.AddWithValue("@CPF", cliente.Cpf);
            comando.Parameters.AddWithValue("@SALARIO", cliente.Salario);
            comando.Parameters.AddWithValue("@TELEFONE", cliente.Telefone);
            comando.Parameters.AddWithValue("@ESTADO", cliente.Estado);
            comando.Parameters.AddWithValue("@CIDADE", cliente.Cidade);
            comando.Parameters.AddWithValue("@BAIRRO", cliente.Bairro);
            comando.Parameters.AddWithValue("@CEP", cliente.Cep);
            comando.Parameters.AddWithValue("@LOGRADOURO", cliente.Logradouro);
            comando.Parameters.AddWithValue("@NUMERO", cliente.Numero);
            comando.Parameters.AddWithValue("@NOME_SUJO", cliente.Nome_sujo);
            comando.Parameters.AddWithValue("@COMPLEXO", cliente.Complexo);
            comando.Parameters.AddWithValue("@ALTURA", cliente.Altura);
            comando.Parameters.AddWithValue("@PESO", cliente.Peso);
            comando.ExecuteNonQuery();
            LimparCampos();
            AtualizarTabela();
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre\Documents\banco-de-dados.mdf;Integrated Security=True;Connect Timeout=30"; //Colocar Banco
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.CommandText = @"SELECT id, nome, cpf, salario, telefone, estado, cidade, bairro, cep, logradouro, numero, complexo, nome_sujo, altura, peso FROM clientes";
            comando.Parameters.AddWithValue("@ID", id);
            comando.Connection = conexao;
            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            DataRow linha = tabela.Rows[0];
            Cliente cliente = new Cliente();
            cliente.Id = Convert.ToInt32(linha["id"]);
            cliente.Nome = linha["nome"].ToString();
            cliente.Cpf = linha["cpf"].ToString();
            cliente.Salario = Convert.ToDecimal(linha["salario"]);
            cliente.Telefone = linha["telefone"].ToString();
            cliente.Estado = linha["estado"].ToString();
            cliente.Cidade = linha["cidade"].ToString();
            cliente.Bairro = linha["bairro"].ToString();
            cliente.Cep = linha["cep"].ToString();
            cliente.Logradouro = linha["logradouro"].ToString();
            cliente.Numero = Convert.ToInt32(linha["numero"]);
            cliente.Complexo = linha["complexo"].ToString();
            cliente.Nome_sujo = Convert.ToBoolean(linha["nome_sujo"]);
            cliente.Altura = Convert.ToDecimal(linha["altura"]);
            cliente.Peso = Convert.ToDecimal(linha["peso"]);

            lblId.Text = cliente.Id.ToString();
            txtNome.Text = cliente.Nome.ToString();
            mtbCpf.Text = cliente.Cpf.ToString();
            mtbSalario.Text = cliente.Salario.ToString();
            mtbTelefone.Text = cliente.Telefone.ToString();
            txtEstado.Text = cliente.Estado.ToString();
            txtCidade.Text = cliente.Cidade.ToString();
            txtBairro.Text = cliente.Bairro.ToString();
            mtbCep.Text = cliente.Cep.ToString();
            txtLogradouro.Text = cliente.Logradouro.ToString();
            txtNumero.Text = cliente.Numero.ToString();
            txtComplexo.Text = cliente.Complexo.ToString();
           
            if (texto == "sim")
            {
                ckbNomeSujo.Checked = true;
            }
            else
            {
                ckbNomeSujo.Checked = false;
            }
            txtAltura.Text = cliente.Altura.ToString();
            txtPeso.Text = cliente.Peso.ToString();
            conexao.Close();
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow.Index == -1)
            {
                MessageBox.Show("Cadastre um Cliente");
                return;
            }
            DialogResult caixaDialogo = MessageBox.Show("Deseja Realmente apagar?", "AVISO", MessageBoxButtons.YesNo);
            if (caixaDialogo == DialogResult.Yes)
            {
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre\Documents\banco-de-dados.mdf;Integrated Security=True;Connect Timeout=30";//Colocar Banco
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = @"DELETE FROM clientes WHERE id =@ID";
                LimparCampos();
                int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
                comando.Parameters.AddWithValue("@ID", id);
                comando.ExecuteNonQuery();
                conexao.Close();

                AtualizarTabela();
            }
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mtbCpf.Focus();
            }
        }

        private void mtbCpf_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                mtbSalario.Focus();
            }
        }

        private void mtbSalario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                mtbTelefone.Focus();
            }
        }

        private void mtbTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtEstado.Focus();
            }
        }

        private void txtEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCidade.Focus();
            }
        }

        private void txtCidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBairro.Focus();
            }
        }

        private void txtBairro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mtbCep.Focus();
            }
        }

        private void mtbCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtLogradouro.Focus();
            }
        }

        private void txtLogradouro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNumero.Focus();
            }
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtComplexo.Focus();
            }
        }

        private void txtComplexo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAltura.Focus();
            }
        }

        private void txtAltura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPeso.Focus();
            }
        }

        private void txtPeso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar.Focus();
            }
        }
    }
}
