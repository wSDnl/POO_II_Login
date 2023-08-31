using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Usuario
    {

        private int id;
        private string nome;
        private string email;
        private string senha;

        public Usuario() { }

        public Usuario(int id, string nome, string email, string senha)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }


        public bool validaSenha(string acessoLogin , string acessoSenha) 
        {
            if (this.email.Equals(acessoLogin) && (this.senha.Equals(acessoSenha)))
            {
                return true;
            }
            else 
            {
                return false;
            }
            
        }

    }
}
