namespace TCC_salao
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            bto_agendamento = new PictureBox();
            bto_clientes = new PictureBox();
            bto_funcionarios = new PictureBox();
            bto_estoque = new PictureBox();
            groupBox1 = new GroupBox();
            bto_adm = new PictureBox();
            bto_cadastros = new PictureBox();
            bto_procedimento = new PictureBox();
            bto_funcao = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)bto_agendamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bto_clientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bto_funcionarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bto_estoque).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bto_adm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bto_cadastros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bto_procedimento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bto_funcao).BeginInit();
            SuspendLayout();
            // 
            // bto_agendamento
            // 
            bto_agendamento.Cursor = Cursors.Hand;
            bto_agendamento.Image = Properties.Resources.Agendamento2;
            bto_agendamento.Location = new Point(33, 38);
            bto_agendamento.Name = "bto_agendamento";
            bto_agendamento.Size = new Size(150, 150);
            bto_agendamento.SizeMode = PictureBoxSizeMode.StretchImage;
            bto_agendamento.TabIndex = 0;
            bto_agendamento.TabStop = false;
            bto_agendamento.Click += bto_agendamento_Click;
            // 
            // bto_clientes
            // 
            bto_clientes.Cursor = Cursors.Hand;
            bto_clientes.Image = (Image)resources.GetObject("bto_clientes.Image");
            bto_clientes.Location = new Point(215, 283);
            bto_clientes.Name = "bto_clientes";
            bto_clientes.Size = new Size(100, 100);
            bto_clientes.SizeMode = PictureBoxSizeMode.StretchImage;
            bto_clientes.TabIndex = 1;
            bto_clientes.TabStop = false;
            bto_clientes.Click += bto_clientes_Click;
            // 
            // bto_funcionarios
            // 
            bto_funcionarios.Cursor = Cursors.Hand;
            bto_funcionarios.Image = (Image)resources.GetObject("bto_funcionarios.Image");
            bto_funcionarios.Location = new Point(321, 283);
            bto_funcionarios.Name = "bto_funcionarios";
            bto_funcionarios.Size = new Size(100, 100);
            bto_funcionarios.SizeMode = PictureBoxSizeMode.StretchImage;
            bto_funcionarios.TabIndex = 2;
            bto_funcionarios.TabStop = false;
            bto_funcionarios.Click += bto_funcionarios_Click;
            // 
            // bto_estoque
            // 
            bto_estoque.Cursor = Cursors.Hand;
            bto_estoque.Image = (Image)resources.GetObject("bto_estoque.Image");
            bto_estoque.Location = new Point(45, 663);
            bto_estoque.Name = "bto_estoque";
            bto_estoque.Size = new Size(150, 150);
            bto_estoque.SizeMode = PictureBoxSizeMode.StretchImage;
            bto_estoque.TabIndex = 3;
            bto_estoque.TabStop = false;
            bto_estoque.Click += bto_estoque_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bto_adm);
            groupBox1.Controls.Add(bto_cadastros);
            groupBox1.Controls.Add(bto_agendamento);
            groupBox1.ForeColor = Color.Transparent;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(210, 853);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // bto_adm
            // 
            bto_adm.Cursor = Cursors.Hand;
            bto_adm.Image = (Image)resources.GetObject("bto_adm.Image");
            bto_adm.Location = new Point(33, 451);
            bto_adm.Name = "bto_adm";
            bto_adm.Size = new Size(150, 150);
            bto_adm.SizeMode = PictureBoxSizeMode.StretchImage;
            bto_adm.TabIndex = 6;
            bto_adm.TabStop = false;
            bto_adm.Click += pictureBox1_Click;
            // 
            // bto_cadastros
            // 
            bto_cadastros.Cursor = Cursors.Hand;
            bto_cadastros.Image = (Image)resources.GetObject("bto_cadastros.Image");
            bto_cadastros.Location = new Point(33, 245);
            bto_cadastros.Name = "bto_cadastros";
            bto_cadastros.Size = new Size(150, 150);
            bto_cadastros.SizeMode = PictureBoxSizeMode.StretchImage;
            bto_cadastros.TabIndex = 5;
            bto_cadastros.TabStop = false;
            bto_cadastros.Click += bto_cadastros_Click;
            // 
            // bto_procedimento
            // 
            bto_procedimento.Cursor = Cursors.Hand;
            bto_procedimento.Image = (Image)resources.GetObject("bto_procedimento.Image");
            bto_procedimento.Location = new Point(321, 489);
            bto_procedimento.Name = "bto_procedimento";
            bto_procedimento.Size = new Size(100, 100);
            bto_procedimento.SizeMode = PictureBoxSizeMode.StretchImage;
            bto_procedimento.TabIndex = 6;
            bto_procedimento.TabStop = false;
            bto_procedimento.Click += bto_procedimento_Click;
            // 
            // bto_funcao
            // 
            bto_funcao.Cursor = Cursors.Hand;
            bto_funcao.Image = (Image)resources.GetObject("bto_funcao.Image");
            bto_funcao.Location = new Point(215, 489);
            bto_funcao.Name = "bto_funcao";
            bto_funcao.Size = new Size(100, 100);
            bto_funcao.SizeMode = PictureBoxSizeMode.StretchImage;
            bto_funcao.TabIndex = 5;
            bto_funcao.TabStop = false;
            bto_funcao.Click += bto_funcao_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 206, 225);
            ClientSize = new Size(1600, 900);
            ControlBox = false;
            Controls.Add(bto_procedimento);
            Controls.Add(bto_funcao);
            Controls.Add(bto_estoque);
            Controls.Add(bto_funcionarios);
            Controls.Add(bto_clientes);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)bto_agendamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)bto_clientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)bto_funcionarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)bto_estoque).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bto_adm).EndInit();
            ((System.ComponentModel.ISupportInitialize)bto_cadastros).EndInit();
            ((System.ComponentModel.ISupportInitialize)bto_procedimento).EndInit();
            ((System.ComponentModel.ISupportInitialize)bto_funcao).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox bto_agendamento;
        private PictureBox bto_clientes;
        private PictureBox bto_funcionarios;
        private PictureBox bto_estoque;
        private GroupBox groupBox1;
        private PictureBox bto_cadastros;
        private PictureBox bto_adm;
        private PictureBox bto_procedimento;
        private PictureBox bto_funcao;
    }
}
