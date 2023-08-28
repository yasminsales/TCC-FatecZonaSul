namespace TCC_salao
{
    partial class Frm_funcao
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
            tb_funcao = new ComboBox();
            bto_limpar = new Button();
            bto_excluir = new Button();
            bto_alterar = new Button();
            bto_cadastrar = new Button();
            label7 = new Label();
            tb_id = new TextBox();
            label3 = new Label();
            label1 = new Label();
            bto_buscar = new Button();
            SuspendLayout();
            // 
            // tb_funcao
            // 
            tb_funcao.Font = new Font("Nirmala UI", 12F);
            tb_funcao.FormattingEnabled = true;
            tb_funcao.Location = new Point(39, 142);
            tb_funcao.Margin = new Padding(4, 3, 4, 3);
            tb_funcao.Name = "tb_funcao";
            tb_funcao.Size = new Size(506, 29);
            tb_funcao.TabIndex = 53;
            // 
            // bto_limpar
            // 
            bto_limpar.BackColor = Color.FromArgb(179, 84, 117);
            bto_limpar.FlatAppearance.BorderColor = Color.FromArgb(179, 84, 117);
            bto_limpar.FlatAppearance.BorderSize = 0;
            bto_limpar.FlatStyle = FlatStyle.Flat;
            bto_limpar.Font = new Font("Nirmala UI", 15F);
            bto_limpar.ForeColor = Color.White;
            bto_limpar.Location = new Point(511, 286);
            bto_limpar.Margin = new Padding(4, 3, 4, 3);
            bto_limpar.Name = "bto_limpar";
            bto_limpar.Size = new Size(120, 43);
            bto_limpar.TabIndex = 58;
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
            bto_excluir.Location = new Point(356, 286);
            bto_excluir.Margin = new Padding(4, 3, 4, 3);
            bto_excluir.Name = "bto_excluir";
            bto_excluir.Size = new Size(120, 43);
            bto_excluir.TabIndex = 57;
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
            bto_alterar.Location = new Point(215, 286);
            bto_alterar.Margin = new Padding(4, 3, 4, 3);
            bto_alterar.Name = "bto_alterar";
            bto_alterar.Size = new Size(120, 43);
            bto_alterar.TabIndex = 56;
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
            bto_cadastrar.Location = new Point(39, 286);
            bto_cadastrar.Margin = new Padding(4, 3, 4, 3);
            bto_cadastrar.Name = "bto_cadastrar";
            bto_cadastrar.Size = new Size(148, 43);
            bto_cadastrar.TabIndex = 55;
            bto_cadastrar.Text = "cadastrar";
            bto_cadastrar.UseVisualStyleBackColor = false;
            bto_cadastrar.Click += bto_cadastrar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(179, 84, 117);
            label7.Location = new Point(568, 174);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(31, 28);
            label7.TabIndex = 62;
            label7.Text = "ID";
            // 
            // tb_id
            // 
            tb_id.Enabled = false;
            tb_id.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_id.Location = new Point(568, 142);
            tb_id.Margin = new Padding(4, 3, 4, 3);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(63, 29);
            tb_id.TabIndex = 61;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(179, 84, 117);
            label3.Location = new Point(29, 20);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(543, 71);
            label3.TabIndex = 60;
            label3.Text = "Cadastro de Funções";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(179, 84, 117);
            label1.Location = new Point(39, 174);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 59;
            label1.Text = "função";
            // 
            // bto_buscar
            // 
            bto_buscar.BackColor = Color.FromArgb(179, 84, 117);
            bto_buscar.FlatAppearance.BorderColor = Color.FromArgb(179, 84, 117);
            bto_buscar.FlatAppearance.BorderSize = 0;
            bto_buscar.FlatStyle = FlatStyle.Flat;
            bto_buscar.Font = new Font("Nirmala UI", 15F);
            bto_buscar.ForeColor = Color.White;
            bto_buscar.Location = new Point(425, 177);
            bto_buscar.Margin = new Padding(4, 3, 4, 3);
            bto_buscar.Name = "bto_buscar";
            bto_buscar.Size = new Size(120, 43);
            bto_buscar.TabIndex = 54;
            bto_buscar.Text = "buscar";
            bto_buscar.UseVisualStyleBackColor = false;
            bto_buscar.Click += bto_buscar_Click;
            // 
            // Frm_funcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 205, 223);
            ClientSize = new Size(679, 369);
            Controls.Add(tb_funcao);
            Controls.Add(bto_limpar);
            Controls.Add(bto_excluir);
            Controls.Add(bto_alterar);
            Controls.Add(bto_cadastrar);
            Controls.Add(label7);
            Controls.Add(tb_id);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(bto_buscar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_funcao";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Frm_funcao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox tb_funcao;
        private Button bto_limpar;
        private Button bto_excluir;
        private Button bto_alterar;
        private Button bto_cadastrar;
        private Label label7;
        private TextBox tb_id;
        private Label label3;
        private Label label1;
        private Button bto_buscar;
    }
}