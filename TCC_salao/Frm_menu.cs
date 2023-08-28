

using Org.BouncyCastle.Crypto.Engines;
using System.Windows.Forms.Design;

namespace TCC_salao
{
    public partial class Menu : Form
    {
        int resultado, contador1, contador2;
        bool cadastro = false, adm = false;
        public Menu()

        {
            InitializeComponent();
            IsMdiContainer = true;
            foreach (Control c in this.Controls)
                if (c is MdiClient)
                    c.BackColor = Color.FromArgb(255, 206, 225);

        }

        private void bto_estoque_Click(object sender, EventArgs e)
        {
            sumirmenu();
            Frm_estoque f2 = new Frm_estoque();
            f2.MdiParent = this;
            f2.Show();

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            sumirmenu();
        }

        private void bto_clientes_Click(object sender, EventArgs e)
        {
            sumirmenu();
            Frm_clientes f3 = new Frm_clientes();
            f3.MdiParent = this;
            f3.Show();
        }

        private void bto_cadastros_Click(object sender, EventArgs e)
        {
            if (adm == true)
            {
                bto_funcao.Hide();
                bto_procedimento.Hide();
                adm = false;
            }

            if (cadastro == true)
            {
                bto_clientes.Hide();
                bto_funcionarios.Hide();
                cadastro = false;
            }
            else
            {
                bto_clientes.Show();
                bto_funcionarios.Show();
                cadastro = true;
            }

 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (cadastro == true)
            {
                bto_clientes.Hide();
                bto_funcionarios.Hide();
                cadastro = false;
            }

            if (adm == true)
            {
                bto_funcao.Hide();
                bto_procedimento.Hide();
                adm = false;
            }

            else
            {
                bto_funcao.Show();
                bto_procedimento.Show();
                adm = true;
            }



        }

        private void bto_agendamento_Click(object sender, EventArgs e)
        {
            sumirmenu();
        }

        private void bto_funcionarios_Click(object sender, EventArgs e)
        {
            sumirmenu();

            Frm_funcionario f4 = new Frm_funcionario();
            f4.MdiParent = this;
            f4.Show();
        }

        private void bto_funcao_Click(object sender, EventArgs e)
        {

            sumirmenu();
            Frm_funcao f5 = new Frm_funcao();
            f5.MdiParent = this;
            f5.Show();
        }

        private void bto_procedimento_Click(object sender, EventArgs e)
        {
            sumirmenu();
        }
        private void sumirmenu()
        {
            bto_clientes.Hide();
            bto_funcionarios.Hide();
            bto_funcao.Hide();
            bto_procedimento.Hide();
        }
    }
}


