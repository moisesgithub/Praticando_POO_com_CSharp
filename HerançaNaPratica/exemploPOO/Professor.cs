using System;

namespace exemploPOO
{
    public class Professor : Pessoa
    {
        public int Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} sou professor e meu salário é de {Salario} reais");
        }
    }
}