using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem.Models
{
    public partial class FrmCadastro : Form
    {
        private Usuario usuario = null;

        public FrmCadastro()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            if(usuario!= null)
            {
                tbxNome.Text = usuario.nome;
                txbEndereco.Text = usuario.endereco;
                txbNumero.Text = usuario.numero;
                txbSenha.Text = usuario.senha;
                txbConfirmarSenha.Text = usuario.senha;
                txbSobrenome.Text = usuario.sobrenome;
                txbNascimento.Text = usuario.nascimento;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbxNome_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
