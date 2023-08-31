using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Usuario usuario = new Usuario();
        public List<Usuario> lista = new List<Usuario>();

        public Form1()
        {
            lista.Add(new Usuario(1,"Nome 1","email1@email.com","123"));
            lista.Add(new Usuario(2,"Nome 2","emai2@email.com","123"));
            lista.Add(new Usuario(3,"Nome 3","emai3@email.com","123"));
            
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valida = false;
            foreach(var item in lista) {
                valida = item.validaSenha(txtEmail.Text, txtSenha.Tex);
            }

            //Usuario user = new Usuario();

            //user.Email = this.txtEmail.Text;
            //user.Senha = this.txtSenha.Text;

            //if (user.Email != "" && user.Senha != "")
            //{
            //    bool valida = user.validaSenha(user.Email, user.Senha);
            //    if (valida == true)
            //    {
            //        Sistema sistema = new Sistema();
            //        sistema.ShowDialog();
            //    }
            //    else
            //    {
            //        MessageBox.Show("SENHA INCORRETA", "Aviso", MessageBoxButtons.OK);
            //    }
            //}
            //else {
            //    MessageBox.Show("PREENCHA OS DADOS", "Aviso", MessageBoxButtons.OK);
            //}


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroUsuarios cadastroUsuarios = new CadastroUsuarios();
            cadastroUsuarios.ShowDialog();
        }
    }
}
