using System;
namespace Escola.Library
{
    public class Boletim
    {
        public Boletim(int idBoletim, int ano, int idInstituicao, int idCurso, int idAluno )
        {
            IdBoletim = idBoletim;
            Ano = ano;
            IdInstituicao = idInstituicao;
            IdCurso = idCurso;
            IdAluno = idAluno;
        }

        private int idBoletim, ano, idInstituicao, idCurso, idAluno;

        public int IdBoletim { get => idBoletim; set => idBoletim = value; }
        public int Ano { get => ano; set => ano = value; }
        public int IdInstituicao { get => idInstituicao; set => idInstituicao = value; }
        public int IdCurso { get => idCurso; set => idCurso = value; }
        public int IdAluno { get => idAluno; set => idAluno = value; }
    }
}
