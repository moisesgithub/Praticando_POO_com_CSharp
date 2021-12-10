using System;

namespace exemploPOO
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Matricula { get; set; }

        public virtual void Apresentar()//virtual permite que a classe filha sobrescreva o método
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}