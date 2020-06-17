namespace AirSystem
{
    partial class FrmTelaPrincipalUsuario
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
            this.btnListarAvioes = new System.Windows.Forms.Button();
            this.btnGerenciarAviao = new System.Windows.Forms.Button();
            this.btnGerenciarCompanhia = new System.Windows.Forms.Button();
            this.btnGerenciarRelatorios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarAvioes
            // 
            this.btnListarAvioes.Location = new System.Drawing.Point(173, 96);
            this.btnListarAvioes.Name = "btnListarAvioes";
            this.btnListarAvioes.Size = new System.Drawing.Size(149, 98);
            this.btnListarAvioes.TabIndex = 2;
            this.btnListarAvioes.Text = "Listar aviões";
            this.btnListarAvioes.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarAviao
            // 
            this.btnGerenciarAviao.Location = new System.Drawing.Point(478, 96);
            this.btnGerenciarAviao.Name = "btnGerenciarAviao";
            this.btnGerenciarAviao.Size = new System.Drawing.Size(149, 98);
            this.btnGerenciarAviao.TabIndex = 4;
            this.btnGerenciarAviao.Text = "Gerenciar avião";
            this.btnGerenciarAviao.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarCompanhia
            // 
            this.btnGerenciarCompanhia.Location = new System.Drawing.Point(173, 268);
            this.btnGerenciarCompanhia.Name = "btnGerenciarCompanhia";
            this.btnGerenciarCompanhia.Size = new System.Drawing.Size(149, 98);
            this.btnGerenciarCompanhia.TabIndex = 6;
            this.btnGerenciarCompanhia.Text = "Gerenciar companhia";
            this.btnGerenciarCompanhia.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarRelatorios
            // 
            this.btnGerenciarRelatorios.Location = new System.Drawing.Point(478, 259);
            this.btnGerenciarRelatorios.Name = "btnGerenciarRelatorios";
            this.btnGerenciarRelatorios.Size = new System.Drawing.Size(149, 98);
            this.btnGerenciarRelatorios.TabIndex = 7;
            this.btnGerenciarRelatorios.Text = "Gerenciar relatórios";
            this.btnGerenciarRelatorios.UseVisualStyleBackColor = true;
            // 
            // FrmTelaPrincipalUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGerenciarRelatorios);
            this.Controls.Add(this.btnGerenciarCompanhia);
            this.Controls.Add(this.btnGerenciarAviao);
            this.Controls.Add(this.btnListarAvioes);
            this.Name = "FrmTelaPrincipalUsuario";
            this.Text = "FrmTelaPrincipalUsuario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListarAvioes;
        private System.Windows.Forms.Button btnGerenciarAviao;
        private System.Windows.Forms.Button btnGerenciarCompanhia;
        private System.Windows.Forms.Button btnGerenciarRelatorios;
    }
}