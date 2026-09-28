namespace cadastroCliente
{
    partial class Cadastrar
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.botCadastrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.telefone = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cadastrarCliente = new System.Windows.Forms.Label();
            this.endereco = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.cpf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(256, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(277, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(256, 232);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(277, 20);
            this.textBox4.TabIndex = 3;
            // 
            // botCadastrar
            // 
            this.botCadastrar.Location = new System.Drawing.Point(195, 298);
            this.botCadastrar.Name = "botCadastrar";
            this.botCadastrar.Size = new System.Drawing.Size(141, 58);
            this.botCadastrar.TabIndex = 4;
            this.botCadastrar.Text = "CADASTRAR";
            this.botCadastrar.UseVisualStyleBackColor = true;
            this.botCadastrar.Click += new System.EventHandler(this.botCadastrar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(437, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 58);
            this.button2.TabIndex = 5;
            this.button2.Text = "VOLTAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // telefone
            // 
            this.telefone.AutoSize = true;
            this.telefone.Location = new System.Drawing.Point(184, 209);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(66, 13);
            this.telefone.TabIndex = 6;
            this.telefone.Text = "TELEFONE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "NOME:";
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Location = new System.Drawing.Point(192, 125);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(52, 13);
            this.codigo.TabIndex = 8;
            this.codigo.Text = "CODIGO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 9;
            // 
            // cadastrarCliente
            // 
            this.cadastrarCliente.AutoSize = true;
            this.cadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarCliente.Location = new System.Drawing.Point(238, 37);
            this.cadastrarCliente.Name = "cadastrarCliente";
            this.cadastrarCliente.Size = new System.Drawing.Size(306, 31);
            this.cadastrarCliente.TabIndex = 10;
            this.cadastrarCliente.Text = "CADASTRAR CLIENTE";
            // 
            // endereco
            // 
            this.endereco.AutoSize = true;
            this.endereco.Location = new System.Drawing.Point(180, 235);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(70, 13);
            this.endereco.TabIndex = 11;
            this.endereco.Text = "ENDEREÇO:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(256, 206);
            this.maskedTextBox1.Mask = "(999)99999-9999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(277, 20);
            this.maskedTextBox1.TabIndex = 12;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(256, 180);
            this.maskedTextBox2.Mask = "999.999.999-99";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(277, 20);
            this.maskedTextBox2.TabIndex = 13;
            // 
            // cpf
            // 
            this.cpf.AutoSize = true;
            this.cpf.Location = new System.Drawing.Point(199, 183);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(30, 13);
            this.cpf.TabIndex = 14;
            this.cpf.Text = "CPF:";
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.cadastrarCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.botCadastrar);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button botCadastrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label telefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label codigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cadastrarCliente;
        private System.Windows.Forms.Label endereco;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label cpf;
    }
}