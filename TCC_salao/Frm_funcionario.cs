using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace TCC_salao
{
    public partial class Frm_funcionario : Form
    {
        bool admco;
        int admca = 1;

        MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=Fatec123@;database=salaoTCC";
        public Frm_funcionario()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_adm.Checked == true)
            {
                admca = 1;
            }
            else
            {
                admca = 0;
            }
        }

        private void Frm_funcionario_Load(object sender, EventArgs e)
        {
            carregar_funcao();
            carregar_banco();
        }

        private void carregar_funcao()
        {
            try
            {

                //Criar conexao com MySQL
                Conexao = new MySqlConnection(data_source);
                string q = "'%" + tb_funcao.Text + "%'";
                string sql = "SELECT * FROM funcao WHERE nomeFuncao LIKE " + q;


                Conexao.Open();
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                MySqlDataReader reader = comando.ExecuteReader();
                tb_nome.Items.Clear();
                while (reader.Read())
                {
                    tb_funcao.Items.Add(reader["nomeFuncao"].ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void bto_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                //Criar conexao com MySQL
                Conexao = new MySqlConnection(data_source);

                string sql = "INSERT INTO funcionario (nomeFuncionario, funcao, telefoneFuncionario, login, senha, administrador) VALUES ('" + tb_nome.Text + "','" + tb_funcao.Text + "','" + tb_telefone.Text + "','" + tb_login.Text + "', '" + tb_senha.Text + "','" + admca + "')";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();
                comando.ExecuteReader();
                MessageBox.Show("Cadastro Inserido");
                //Executar comando Insert
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
            limpar();
            carregar_banco();
        }

        private void bto_buscar_Click(object sender, EventArgs e)
        {
            try
            {

                //Criar conexao com MySQL
                Conexao = new MySqlConnection(data_source);
                string q = "'%" + tb_nome.Text + "%'";
                string sql = "SELECT * FROM funcionario WHERE nomeFuncionario LIKE " + q;


                Conexao.Open();
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                MySqlDataReader reader = comando.ExecuteReader();

                tb_nome.Items.Clear();
                while (reader.Read())
                {
                    tb_id.Text = reader["idFuncionario"].ToString();
                    tb_nome.Items.Add(reader["nomeFuncionario"].ToString());
                    tb_funcao.Text = reader["funcao"].ToString();
                    tb_telefone.Text = reader["telefoneFuncionario"].ToString();
                    tb_login.Text = reader["login"].ToString();
                    tb_senha.Text = reader["senha"].ToString();
                    admco = (bool)reader["administrador"];

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }

            if (admco == true)
            {
                cb_adm.Checked = true;
            }
            else
            {
                cb_adm.Checked = false;
            }
        }

        private void carregar_banco()
        {
            try
            {

                //Criar conexao com MySQL
                Conexao = new MySqlConnection(data_source);
                string q = "'%" + tb_nome.Text + "%'";
                string sql = "SELECT * FROM funcionario WHERE nomeFuncionario LIKE " + q;


                Conexao.Open();
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                MySqlDataReader reader = comando.ExecuteReader();
                tb_nome.Items.Clear();
                while (reader.Read())
                {
                    tb_nome.Items.Add(reader["nomeFuncionario"].ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void limpar()
        {
            tb_nome.Text = "";
            tb_id.Text = "";
            tb_login.Text = "";
            tb_senha.Text = "";
            tb_telefone.Text = "";
            tb_funcao.Text = "";
            cb_adm.Checked = false;
        }

        private void bto_limpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void bto_alterar_Click(object sender, EventArgs e)
        {
            try
            {

                //Criar conexao com MySQL
                Conexao = new MySqlConnection(data_source);
                string sql = "UPDATE funcionario SET nomeFuncionario = '" + tb_nome.Text + "', funcao = '" + tb_funcao.Text + "', telefoneFuncionario = '" + tb_telefone.Text + "',login = '" + tb_login.Text + "',senha = '" + tb_senha.Text + "',administrador = '" + admca + "' WHERE idFuncionario = '" + tb_id.Text + "'";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();
                comando.ExecuteReader();
                MessageBox.Show("Cadastro atualizado");
                //Executar comando Insert
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
            limpar();
            carregar_banco();
        }

        private void bto_excluir_Click(object sender, EventArgs e)
        {
            try
            {

                //Criar conexao com MySQL
                Conexao = new MySqlConnection(data_source);

                string sql = "DELETE FROM funcionario WHERE idFuncionario = '" + tb_id.Text + "'";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();
                comando.ExecuteReader();
                MessageBox.Show("Cadastro Deletado");
                //Executar comando Insert
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
            limpar();
            carregar_banco();
        }
    }
}
