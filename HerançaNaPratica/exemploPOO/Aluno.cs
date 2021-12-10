using System;

namespace exemploPOO
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar() //Fazer override é sobreescrever um método da classe pai        
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e sou um aluno nota {Nota}");
        }
    }
}