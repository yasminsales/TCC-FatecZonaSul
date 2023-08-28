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

namespace TCC_salao
{
    public partial class Frm_funcao : Form
    {

        MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=Fatec123@;database=salaoTCC";
        public Frm_funcao()
        {
            InitializeComponent();
        }

        private void Frm_funcao_Load(object sender, EventArgs e)
        {
            carregar_banco();
        }

        private void carregar_banco()
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
                tb_funcao.Items.Clear();
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

                string sql = "INSERT INTO funcao (nomeFuncao) VALUES ('" + tb_funcao.Text + "')";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();
                comando.ExecuteReader();
                MessageBox.Show("Cadastro Inserido");
                // Executar comando Insert
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

        private void limpar()
        {
            tb_funcao.Text = "";
            tb_id.Text = "";
        }

        private void bto_alterar_Click(object sender, EventArgs e)
        {
            try
            {

                //Criar conexao com MySQL

                Conexao = new MySqlConnection(data_source);

                string sql = "UPDATE funcao SET nomeFuncao = '" + tb_funcao.Text + "' WHERE idFuncao = '" + tb_id.Text + "'"; ;
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

                string sql = "DELETE FROM funcao WHERE idFuncao = '" + tb_id.Text + "'";
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

        private void bto_limpar_Click(object sender, EventArgs e)
        {
            limpar();

        }

        private void bto_buscar_Click(object sender, EventArgs e)
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
                tb_funcao.Items.Clear();
                while (reader.Read())
                {
                    tb_funcao.Items.Add(reader["nomeFuncao"].ToString());
                    tb_id.Text = reader["idFuncao"].ToString();
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
    }
}
