﻿using System;
namespace Escola.Library
{
    public class Disciplina
    {
        public Disciplina(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        private int id;
        private string nome;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value.Substring(0,50); }
    }
}
