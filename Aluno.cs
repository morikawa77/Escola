using System;
namespace Escola.Library
{
    public class Aluno
    {
        public Aluno(int id, string nome, string email, string senha)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
        }

        private int id;
        private string nome, email, senha;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value.Substring(0,50); }
        public string Email { get => email; set => email = value.Substring(0,100); }
        public string Senha { get => senha; set => senha = value.Substring(0,20); }
    }
}
