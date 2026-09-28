namespace cadastroCliente
{
    partial class telaCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaCliente));
            this.tituloPagina = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cadastrar = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.crud = new System.Windows.Forms.Label();
            this.atualizar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tituloPagina
            // 
            this.tituloPagina.AutoSize = true;
            this.tituloPagina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tituloPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloPagina.ForeColor = System.Drawing.Color.Red;
            this.tituloPagina.Location = new System.Drawing.Point(223, 9);
            this.tituloPagina.Name = "tituloPagina";
            this.tituloPagina.Padding = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.tituloPagina.Size = new System.Drawing.Size(457, 33);
            this.tituloPagina.TabIndex = 0;
            this.tituloPagina.Text = "Bem-vindo cliente!";
            this.tituloPagina.Click += new System.EventHandler(this.tituloPagina_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(539, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // cadastrar
            // 
            this.cadastrar.BackColor = System.Drawing.Color.IndianRed;
            this.cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cadastrar.FlatAppearance.BorderSize = 2;
            this.cadastrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.MintCream;
            this.cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F);
            this.cadastrar.Location = new System.Drawing.Point(505, 161);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(140, 47);
            this.cadastrar.TabIndex = 3;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = false;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // consultar
            // 
            this.consultar.BackColor = System.Drawing.Color.IndianRed;
            this.consultar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.consultar.FlatAppearance.BorderSize = 2;
            this.consultar.FlatAppearance.CheckedBackColor = System.Drawing.Color.MintCream;
            this.consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultar.Location = new System.Drawing.Point(279, 161);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(140, 47);
            this.consultar.TabIndex = 4;
            this.consultar.Text = "Consultar";
            this.consultar.UseVisualStyleBackColor = false;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // crud
            // 
            this.crud.AutoSize = true;
            this.crud.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crud.Location = new System.Drawing.Point(309, 70);
            this.crud.Name = "crud";
            this.crud.Size = new System.Drawing.Size(288, 28);
            this.crud.TabIndex = 5;
            this.crud.Text = "Escolha uma das opções abaixo";
            // 
            // atualizar
            // 
            this.atualizar.BackColor = System.Drawing.Color.IndianRed;
            this.atualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.atualizar.FlatAppearance.BorderSize = 2;
            this.atualizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.MintCream;
            this.atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atualizar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F);
            this.atualizar.Location = new System.Drawing.Point(280, 258);
            this.atualizar.Name = "atualizar";
            this.atualizar.Size = new System.Drawing.Size(139, 49);
            this.atualizar.TabIndex = 6;
            this.atualizar.Text = "Atualizar";
            this.atualizar.UseVisualStyleBackColor = false;
            this.atualizar.Click += new System.EventHandler(this.atualizar_Click);
            // 
            // excluir
            // 
            this.excluir.BackColor = System.Drawing.Color.IndianRed;
            this.excluir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.excluir.FlatAppearance.BorderSize = 2;
            this.excluir.FlatAppearance.CheckedBackColor = System.Drawing.Color.MintCream;
            this.excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluir.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F);
            this.excluir.Location = new System.Drawing.Point(505, 258);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(140, 49);
            this.excluir.TabIndex = 7;
            this.excluir.Text = "Excluir";
            this.excluir.UseVisualStyleBackColor = false;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // telaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(929, 487);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.atualizar);
            this.Controls.Add(this.crud);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tituloPagina);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(700, 300);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(945, 526);
            this.MinimumSize = new System.Drawing.Size(945, 526);
            this.Name = "telaCliente";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.telaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloPagina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.Label crud;
        private System.Windows.Forms.Button atualizar;
        private System.Windows.Forms.Button excluir;
    }
}

