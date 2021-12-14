using System;

namespace exemploPOO.Models
{
    public /*sealed*/ class Professor : Pessoa//sealed para não poder herdar, e 
                                          //o sealed para não poder ser criado outro objeto
    {
        public int Salario { get; set; }

        public /*sealed*/ override void Apresentar()//Sealed não permite que a classe filha 
                                                //sobrescreva o método, mas permite que 
                                                //a classe filha seja herdada.

        {
          Console.WriteLine($"Olá, meu nome é {Nome} sou professor e meu salário é {Salario} reais");
        }
    }
} 