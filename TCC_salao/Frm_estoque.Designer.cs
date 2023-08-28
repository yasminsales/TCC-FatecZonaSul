namespace TCC_salao
{
    partial class Frm_estoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_produto = new ComboBox();
            tb_validade = new MaskedTextBox();
            bto_limpar = new Button();
            bto_excluir = new Button();
            bto_alterar = new Button();
            bto_cadastrar = new Button();
            label7 = new Label();
            tb_id = new TextBox();
            label6 = new Label();
            tb_obs = new TextBox();
            label5 = new Label();
            tb_marca = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tb_quantidade = new TextBox();
            label1 = new Label();
            bto_buscar = new Button();
            SuspendLayout();
            // 
            // tb_produto
            // 
            tb_produto.Font = new Font("Nirmala UI", 12F);
            tb_produto.FormattingEnabled = true;
            tb_produto.Location = new Point(81, 161);
            tb_produto.Margin = new Padding(4, 3, 4, 3);
            tb_produto.Name = "tb_produto";
            tb_produto.Size = new Size(383, 29);
            tb_produto.TabIndex = 1;
            // 
            // tb_validade
            // 
            tb_validade.Font = new Font("Nirmala UI", 12F);
            tb_validade.Location = new Point(81, 280);
            tb_validade.Margin = new Padding(4, 3, 4, 3);
            tb_validade.Mask = "00/00/0000";
            tb_validade.Name = "tb_validade";
            tb_validade.Size = new Size(128, 29);
            tb_validade.TabIndex = 4;
            tb_validade.TextAlign = HorizontalAlignment.Center;
            tb_validade.ValidatingType = typeof(DateTime);
            // 
            // bto_limpar
            // 
            bto_limpar.BackColor = Color.FromArgb(179, 84, 117);
            bto_limpar.FlatAppearance.BorderColor = Color.FromArgb(179, 84, 117);
            bto_limpar.FlatAppearance.BorderSize = 0;
            bto_limpar.FlatStyle = FlatStyle.Flat;
            bto_limpar.Font = new Font("Nirmala UI", 15F);
            bto_limpar.ForeColor = Color.White;
            bto_limpar.Location = new Point(605, 429);
            bto_limpar.Margin = new Padding(4, 3, 4, 3);
            bto_limpar.Name = "bto_limpar";
            bto_limpar.Size = new Size(120, 43);
            bto_limpar.TabIndex = 10;
            bto_limpar.Text = "limpar";
            bto_limpar.UseVisualStyleBackColor = false;
            bto_limpar.Click += bto_limpar_Click;
            // 
            // bto_excluir
            // 
            bto_excluir.BackColor = Color.FromArgb(179, 84, 117);
            bto_excluir.FlatAppearance.BorderColor = Color.FromArgb(179, 84, 117);
            bto_excluir.FlatAppearance.BorderSize = 0;
            bto_excluir.FlatStyle = FlatStyle.Flat;
            bto_excluir.Font = new Font("Nirmala UI", 15F);
            bto_excluir.ForeColor = Color.White;
            bto_excluir.Location = new Point(450, 429);
            bto_excluir.Margin = new Padding(4, 3, 4, 3);
            bto_excluir.Name = "bto_excluir";
            bto_excluir.Size = new Size(120, 43);
            bto_excluir.TabIndex = 9;
            bto_excluir.Text = "excluir";
            bto_excluir.UseVisualStyleBackColor = false;
            bto_excluir.Click += bto_excluir_Click;
            // 
            // bto_alterar
            // 
            bto_alterar.BackColor = Color.FromArgb(179, 84, 117);
            bto_alterar.FlatAppearance.BorderColor = Color.FromArgb(179, 84, 117);
            bto_alterar.FlatAppearance.BorderSize = 0;
            bto_alterar.FlatStyle = FlatStyle.Flat;
            bto_alterar.Font = new Font("Nirmala UI", 15F);
            bto_alterar.ForeColor = Color.White;
            bto_alterar.Location = new Point(294, 429);
            bto_alterar.Margin = new Padding(4, 3, 4, 3);
            bto_alterar.Name = "bto_alterar";
            bto_alterar.Size = new Size(120, 43);
            bto_alterar.TabIndex = 8;
            bto_alterar.Text = "alterar";
            bto_alterar.UseVisualStyleBackColor = false;
            bto_alterar.Click += bto_alterar_Click;
            // 
            // bto_cadastrar
            // 
            bto_cadastrar.BackColor = Color.FromArgb(179, 84, 117);
            bto_cadastrar.FlatAppearance.BorderColor = Color.FromArgb(179, 84, 117);
            bto_cadastrar.FlatAppearance.BorderSize = 0;
            bto_cadastrar.FlatStyle = FlatStyle.Flat;
            bto_cadastrar.Font = new Font("Nirmala UI", 15F);
            bto_cadastrar.ForeColor = Color.White;
            bto_cadastrar.Location = new Point(111, 429);
            bto_cadastrar.Margin = new Padding(4, 3, 4, 3);
            bto_cadastrar.Name = "bto_cadastrar";
            bto_cadastrar.Size = new Size(148, 43);
            bto_cadastrar.TabIndex = 7;
            bto_cadastrar.Text = "cadastrar";
            bto_cadastrar.UseVisualStyleBackColor = false;
            bto_cadastrar.Click += bto_cadastrar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(179, 84, 117);
            label7.Location = new Point(703, 56);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(31, 28);
            label7.TabIndex = 34;
            label7.Text = "ID";
            // 
            // tb_id
            // 
            tb_id.Enabled = false;
            tb_id.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_id.Location = new Point(742, 55);
            tb_id.Margin = new Padding(4, 3, 4, 3);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(63, 29);
            tb_id.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(179, 84, 117);
            label6.Location = new Point(537, 312);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(113, 28);
            label6.TabIndex = 32;
            label6.Text = "observação";
            // 
            // tb_obs
            // 
            tb_obs.Font = new Font("Nirmala UI", 12F);
            tb_obs.Location = new Point(537, 280);
            tb_obs.Margin = new Padding(4, 3, 4, 3);
            tb_obs.Name = "tb_obs";
            tb_obs.Size = new Size(269, 29);
            tb_obs.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(179, 84, 117);
            label5.Location = new Point(245, 312);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 28);
            label5.TabIndex = 30;
            label5.Text = "marca";
            // 
            // tb_marca
            // 
            tb_marca.Font = new Font("Nirmala UI", 12F);
            tb_marca.Location = new Point(245, 280);
            tb_marca.Margin = new Padding(4, 3, 4, 3);
            tb_marca.Name = "tb_marca";
            tb_marca.Size = new Size(250, 29);
            tb_marca.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(179, 84, 117);
            label4.Location = new Point(80, 312);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 28);
            label4.TabIndex = 28;
            label4.Text = "validade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(179, 84, 117);
            label3.Location = new Point(53, 38);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(228, 71);
            label3.TabIndex = 27;
            label3.Text = "Estoque";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(179, 84, 117);
            label2.Location = new Point(501, 193);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 26;
            label2.Text = "quantidade";
            // 
            // tb_quantidade
            // 
            tb_quantidade.Font = new Font("Nirmala UI", 12F);
            tb_quantidade.Location = new Point(501, 161);
            tb_quantidade.Margin = new Padding(4, 3, 4, 3);
            tb_quantidade.Name = "tb_quantidade";
            tb_quantidade.Size = new Size(305, 29);
            tb_quantidade.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(179, 84, 117);
            label1.Location = new Point(81, 193);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 28);
            label1.TabIndex = 24;
            label1.Text = "produto";
            // 
            // bto_buscar
            // 
            bto_buscar.BackColor = Color.FromArgb(179, 84, 117);
            bto_buscar.FlatAppearance.BorderColor = Color.FromArgb(179, 84, 117);
            bto_buscar.FlatAppearance.BorderSize = 0;
            bto_buscar.FlatStyle = FlatStyle.Flat;
            bto_buscar.Font = new Font("Nirmala UI", 15F);
            bto_buscar.ForeColor = Color.White;
            bto_buscar.Location = new Point(344, 202);
            bto_buscar.Margin = new Padding(4, 3, 4, 3);
            bto_buscar.Name = "bto_buscar";
            bto_buscar.Size = new Size(120, 43);
            bto_buscar.TabIndex = 3;
            bto_buscar.Text = "buscar";
            bto_buscar.UseVisualStyleBackColor = false;
            bto_buscar.Click += bt_buscar_Click;
            // 
            // Frm_estoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 205, 223);
            ClientSize = new Size(823, 501);
            Controls.Add(tb_produto);
            Controls.Add(tb_validade);
            Controls.Add(bto_limpar);
            Controls.Add(bto_excluir);
            Controls.Add(bto_alterar);
            Controls.Add(bto_cadastrar);
            Controls.Add(label7);
            Controls.Add(tb_id);
            Controls.Add(label6);
            Controls.Add(tb_obs);
            Controls.Add(label5);
            Controls.Add(tb_marca);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tb_quantidade);
            Controls.Add(label1);
            Controls.Add(bto_buscar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Frm_estoque";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estoque";
            Load += Frm_esto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox tb_produto;
        private MaskedTextBox tb_validade;
        private Button bto_limpar;
        private Button bto_excluir;
        private Button bto_alterar;
        private Button bto_cadastrar;
        private Label label7;
        private TextBox tb_id;
        private Label label6;
        private TextBox tb_obs;
        private Label label5;
        private TextBox tb_marca;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox tb_quantidade;
        private Label label1;
        private Button bto_buscar;
    }
}