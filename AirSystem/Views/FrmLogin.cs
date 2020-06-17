using AirSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = this.Size;
            this.Text = "Login | AirSystem";
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            tbxUsuarios.ShortcutsEnabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

    

        private void label1_Click(object sender, EventArgs e)
        {
            TimerLogin.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerLogin.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblIdioma_Click(object sender, EventArgs e)
        {

        }

        private void txbUsuarios_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (tbxUsuarios.Text.Trim().Length == 0)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Digite o usuário.", "Erro");
            }
            else
            {
                MessageBox.Show("Bem Vindo", "Entrada");
                new FrmTelaPrincipalUsuario().ShowDialog();
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            new FrmCadastro().ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
