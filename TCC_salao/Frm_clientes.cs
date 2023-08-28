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
    public partial class Frm_clientes : Form
    {
        MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=Fatec123@;database=salaoTCC";

        public Frm_clientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                string q = "'%" + tb_nome.Text + "%'";
                string sql = "SELECT * FROM cliente WHERE nomeCliente LIKE " + q;


                Conexao.Open();
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                MySqlDataReader reader = comando.ExecuteReader();
                tb_nome.Items.Clear();
                while (reader.Read())
                {
                    tb_nome.Items.Add(reader["nomeCliente"].ToString());
                    tb_telefone.Text = reader["telefoneCliente"].ToString();
                    tb_email.Text = reader["email"].ToString();
                    tb_id.Text = reader["idCliente"].ToString();
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

        private void carregar_banco()
        {
            try
            {

                //Criar conexao com MySQL
                Conexao = new MySqlConnection(data_source);
                string q = "'%" + tb_nome.Text + "%'";
                string sql = "SELECT * FROM cliente WHERE nomeCliente LIKE " + q;


                Conexao.Open();
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                MySqlDataReader reader = comando.ExecuteReader();
                tb_nome.Items.Clear();
                while (reader.Read())
                {
                    tb_nome.Items.Add(reader["nomeCliente"].ToString());
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
            tb_telefone.Text = "";
            tb_email.Text = "";
        }

        private void bto_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                //Criar conexao com MySQL
                Conexao = new MySqlConnection(data_source);

                string sql = "INSERT INTO cliente (nomeCliente, telefoneCliente, email) VALUES ('" + tb_nome.Text + "','" + tb_telefone.Text + "','" + tb_email.Text + "')";
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

        private void Frm_clientes_Load(object sender, EventArgs e)
        {
            carregar_banco();
        }

        private void bto_alterar_Click(object sender, EventArgs e)
        {
            try
            {

                //Criar conexao com MySQL

                Conexao = new MySqlConnection(data_source);

                string sql = "UPDATE cliente SET nomeCliente = '" + tb_nome.Text + "', telefoneCliente = '" + tb_telefone.Text + "', email = '" + tb_email.Text + "' WHERE idCliente = '" + tb_id.Text + "'"; ;
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

                string sql = "DELETE FROM cliente WHERE idCliente = '" + tb_id.Text + "'";
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


