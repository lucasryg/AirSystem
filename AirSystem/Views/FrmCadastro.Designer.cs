namespace AirSystem.Models
{
    partial class FrmCadastro
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereço = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.txbNascimento = new System.Windows.Forms.TextBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbConfirmarSenha = new System.Windows.Forms.TextBox();
            this.txbSobrenome = new System.Windows.Forms.TextBox();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.pcbFotoUsuario = new System.Windows.Forms.PictureBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cbxAdmin = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(42, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEndereço
            // 
            this.lblEndereço.AutoSize = true;
            this.lblEndereço.Location = new System.Drawing.Point(42, 68);
            this.lblEndereço.Name = "lblEndereço";
            this.lblEndereço.Size = new System.Drawing.Size(53, 13);
            this.lblEndereço.TabIndex = 1;
            this.lblEndereço.Text = "Endereço";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(42, 115);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(63, 13);
            this.lblNascimento.TabIndex = 2;
            this.lblNascimento.Text = "Nascimento";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(42, 171);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(42, 223);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(42, 276);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(83, 13);
            this.lblConfirmarSenha.TabIndex = 5;
            this.lblConfirmarSenha.Text = "Confirmar senha";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(148, 19);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(132, 20);
            this.tbxNome.TabIndex = 6;
            this.tbxNome.Text = "Digite seu nome...";
            this.tbxNome.TextChanged += new System.EventHandler(this.tbxNome_TextChanged);
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(148, 65);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(177, 20);
            this.txbEndereco.TabIndex = 7;
            this.txbEndereco.Text = "Digite seu endereço...";
            // 
            // txbNascimento
            // 
            this.txbNascimento.Location = new System.Drawing.Point(148, 112);
            this.txbNascimento.Name = "txbNascimento";
            this.txbNascimento.Size = new System.Drawing.Size(103, 20);
            this.txbNascimento.TabIndex = 8;
            this.txbNascimento.Text = "          /        /  ";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(148, 164);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(155, 20);
            this.txbUsuario.TabIndex = 9;
            this.txbUsuario.Text = "Insira seu Usuário...";
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(148, 220);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(155, 20);
            this.txbSenha.TabIndex = 10;
            this.txbSenha.Text = " Insira sua senha...";
            // 
            // txbConfirmarSenha
            // 
            this.txbConfirmarSenha.Location = new System.Drawing.Point(148, 273);
            this.txbConfirmarSenha.Name = "txbConfirmarSenha";
            this.txbConfirmarSenha.Size = new System.Drawing.Size(155, 20);
            this.txbConfirmarSenha.TabIndex = 11;
            this.txbConfirmarSenha.Text = "Confirme sua senha...";
            // 
            // txbSobrenome
            // 
            this.txbSobrenome.Location = new System.Drawing.Point(286, 19);
            this.txbSobrenome.Name = "txbSobrenome";
            this.txbSobrenome.Size = new System.Drawing.Size(104, 20);
            this.txbSobrenome.TabIndex = 12;
            this.txbSobrenome.Text = "Digite seu sobrenome...";
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(341, 65);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(49, 20);
            this.txbNumero.TabIndex = 13;
            this.txbNumero.Text = "N°";
            this.txbNumero.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // pcbFotoUsuario
            // 
            this.pcbFotoUsuario.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pcbFotoUsuario.Location = new System.Drawing.Point(563, 39);
            this.pcbFotoUsuario.Name = "pcbFotoUsuario";
            this.pcbFotoUsuario.Size = new System.Drawing.Size(214, 187);
            this.pcbFotoUsuario.TabIndex = 14;
            this.pcbFotoUsuario.TabStop = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(563, 232);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(103, 23);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(674, 232);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(103, 23);
            this.btnDeletar.TabIndex = 16;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(148, 334);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(103, 23);
            this.btnCadastrar.TabIndex = 17;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // cbxAdmin
            // 
            this.cbxAdmin.AutoSize = true;
            this.cbxAdmin.Location = new System.Drawing.Point(563, 276);
            this.cbxAdmin.Name = "cbxAdmin";
            this.cbxAdmin.Size = new System.Drawing.Size(64, 17);
            this.cbxAdmin.TabIndex = 18;
            this.cbxAdmin.Text = "É admin";
            this.cbxAdmin.UseVisualStyleBackColor = true;
            this.cbxAdmin.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxAdmin);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.pcbFotoUsuario);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.txbSobrenome);
            this.Controls.Add(this.txbConfirmarSenha);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.txbNascimento);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.lblConfirmarSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblEndereço);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmCadastro";
            this.Text = "FrmCadastro";
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereço;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.TextBox txbNascimento;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbConfirmarSenha;
        private System.Windows.Forms.TextBox txbSobrenome;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.PictureBox pcbFotoUsuario;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.CheckBox cbxAdmin;
    }
}