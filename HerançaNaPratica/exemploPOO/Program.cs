using System;

namespace exemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = "João";
            aluno.Idade = 20;
            aluno.Matricula = "12345";

            aluno.Apresentar();
        }
    }
}
