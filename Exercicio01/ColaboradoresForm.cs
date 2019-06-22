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
            Colaborador colaboradores = new Colaborador();
            colaboradores.Nome = txtNome.Text;
            colaboradores.Cpf = mtbCPF.Text;
            colaboradores.Salario = Convert.ToDecimal(mtbSalario.Text.Replace("R$", ""));
            colaboradores.Sexo = cbSexo.SelectedItem.ToString();
            colaboradores.Cargo = cbCargo.SelectedItem.ToString();
            colaboradores.Programador = ckbProgramador.Checked;


            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre\Documents\banco-de-dados.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO colaboradores(nome, cpf, salario, sexo, cargo,programador)VALUES(@NOME,@CPF,@SALARIO,@SEXO,@CARGO,@PROGRAMADOR)";
            comando.Parameters.AddWithValue("@NOME", colaboradores.Nome);
            comando.Parameters.AddWithValue("@CPF", colaboradores.Cpf);
            comando.Parameters.AddWithValue("@SALARIO", colaboradores.Salario);
            comando.Parameters.AddWithValue("@SEXO", colaboradores.Sexo);
            comando.Parameters.AddWithValue("@CARGO", colaboradores.Cargo);
            comando.Parameters.AddWithValue("@PROGRAMADOR", colaboradores.Programador);
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
            mtbCPF.Clear();
            mtbSalario.Clear();
            cbSexo.SelectedIndex = -1;
            cbCargo.SelectedIndex = -1;
        }
        private void AtualizarTabela()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre\Documents\banco-de-dados.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT id,nome,cpf,salario,sexo,cargo,programador FROM colaboradores";
            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            dgvColaboradores.RowCount = 0;
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                Colaborador colaborador = new Colaborador();
                colaborador.Id = Convert.ToInt32(linha["id"]);
                colaborador.Nome = linha["nome"].ToString();
                colaborador.Cpf = linha["cpf"].ToString();
                colaborador.Salario = Convert.ToDecimal(linha["salario"]);
                colaborador.Sexo = linha["sexo"].ToString();
                colaborador.Cargo = linha["cargo"].ToString();
                colaborador.Programador = Convert.ToBoolean(linha["programador"]);

                if (colaborador.Programador == true)
                {
                    texto = "Sim";
                }
                else
                {
                    texto = "Não";
                }


                dgvColaboradores.Rows.Add(new string[] { colaborador.Id.ToString(), colaborador.Nome.ToString(), colaborador.Cpf.ToString(), colaborador.Salario.ToString(), colaborador.Sexo, colaborador.Cargo, texto });
            }
        }
        private void Alterar()
        {
            Colaborador colaborador = new Colaborador();
            colaborador.Id = Convert.ToInt32(lblId.Text);
            colaborador.Nome = Convert.ToString(txtNome.Text);
            colaborador.Cpf = Convert.ToString(mtbCPF.Text);
            colaborador.Salario = Convert.ToDecimal(mtbSalario.Text.Replace("R$", ""));
            colaborador.Sexo = Convert.ToString(cbSexo.Text);
            colaborador.Cargo = Convert.ToString(cbCargo.Text);
            if (ckbProgramador.Checked)
            {
                colaborador.Programador = true;
            }
            else
            {
                colaborador.Programador = false;
            }
          
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre\Documents\banco-de-dados.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE colaboradores SET nome = @NOME,cpf = @CPF, salario = @SALARIO, sexo = @SEXO, cargo = @CARGO,programador = @PROGRAMADOR WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", colaborador.Id);
            comando.Parameters.AddWithValue("@NOME", colaborador.Nome);
            comando.Parameters.AddWithValue("@CPF", colaborador.Cpf);
            comando.Parameters.AddWithValue("@SALARIO", colaborador.Salario);
            comando.Parameters.AddWithValue("@SEXO", colaborador.Sexo);
            comando.Parameters.AddWithValue("@CARGO", colaborador.Cargo);
            comando.Parameters.AddWithValue("@PROGRAMADOR", colaborador.Programador);
            comando.ExecuteNonQuery();
            conexao.Close();
            AtualizarTabela();
            LimparCampos();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtbCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dgvColaboradores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvColaboradores.CurrentRow.Cells[0].Value);
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre\Documents\banco-de-dados.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.CommandText = @"SELECT id,nome,cpf,salario,sexo,cargo,programador FROM colaboradores WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.Connection = conexao;
            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            DataRow linha = tabela.Rows[0];
            Colaborador colaborador = new Colaborador();
            colaborador.Id = Convert.ToInt32(linha["id"]);
            colaborador.Nome = linha["nome"].ToString();
            colaborador.Cpf = linha["cpf"].ToString();
            colaborador.Salario = Convert.ToDecimal(linha["salario"]);
            colaborador.Sexo = linha["sexo"].ToString();
            colaborador.Cargo = linha["cargo"].ToString();
            colaborador.Programador = Convert.ToBoolean(linha["programador"]);
            

            lblId.Text = colaborador.Id.ToString();
            txtNome.Text = colaborador.Nome.ToString();
            mtbCPF.Text = colaborador.Cpf.ToString();
            mtbSalario.Text = colaborador.Salario.ToString();
            cbSexo.SelectedItem = colaborador.Sexo.ToString();
            cbCargo.SelectedItem = colaborador.Cargo.ToString();
            string verifica = dgvColaboradores.CurrentRow.Cells[6].Value.ToString();
            if (verifica=="Sim")
            {
                ckbProgramador.Checked = true;
            }
            else
            {
                ckbProgramador.Checked = false;
            }
            conexao.Close();
        }

        private void ColaboradoresForm_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvColaboradores.CurrentRow.Index == -1)
            {
                MessageBox.Show("Cadastre um veiculo");
                return;
            }
            DialogResult caixaDialogo = MessageBox.Show("Deseja Realmente apagar?", "AVISO", MessageBoxButtons.YesNo);
            if (caixaDialogo == DialogResult.Yes)
            {
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre\Documents\banco-de-dados.mdf;Integrated Security=True;Connect Timeout=30";
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = @"DELETE FROM colaboradores WHERE id =@ID";

                lblId.Text = "0";
                txtNome.Clear();
                mtbCPF.Clear();
                mtbSalario.Clear();
                cbSexo.SelectedIndex = -1;
                cbCargo.SelectedIndex = -1;

                int id = Convert.ToInt32(dgvColaboradores.CurrentRow.Cells[0].Value);
                comando.Parameters.AddWithValue("@ID", id);
                comando.ExecuteNonQuery();
                conexao.Close();

                AtualizarTabela();
            }
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                mtbCPF.Focus();
            }
        }

        private void mtbCPF_KeyDown(object sender, KeyEventArgs e)
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
                cbSexo.Focus();
            }
        }

        private void cbSexo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                cbCargo.Focus();
            }
        }

        private void cbCargo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ckbProgramador.Focus();
            }
        }

        private void ckbProgramador_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSalvar.Focus();
            }
        }
    }
}
