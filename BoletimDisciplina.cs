using System;
namespace Escola.Library
{
    public class BoletimDisciplina
    {
        public BoletimDisciplina(decimal nota, string periodo, int idBoletim, int idDisciplina)
        {
            Nota = nota;
            Periodo = periodo;
            IdBoletim = idBoletim;
            IdDisciplina = idDisciplina;
        }

        private decimal nota;
        private string periodo;
        private int idBoletim, idDisciplina;

        public decimal Nota { get => nota; set => nota = value; }
        public string Periodo { get => periodo; set => periodo = value.Substring(0,50); }
        public int IdBoletim { get => idBoletim; set => idBoletim = value; }
        public int IdDisciplina { get => idDisciplina; set => idDisciplina = value; }
    }
}
