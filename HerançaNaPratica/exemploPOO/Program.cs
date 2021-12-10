using System;

namespace exemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno al = new Aluno();
            al.Nome = "João";
            al.Idade = 20;
            al.Matricula = "12345";
            al.Nota = 10;

            al.Apresentar();

            Professor prof = new Professor();
            prof.Nome = "Maria";
            prof.Idade = 40;
            prof.Matricula = "12345";
            prof.Salario = 6000;

            prof.Apresentar();
        }
    }
}
