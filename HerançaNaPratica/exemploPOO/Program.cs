using System;

namespace exemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {                            
            Corrente c1 = new Corrente();
            c1.Creditar(100);

            c1.ExibirSaldo();



            //Calculadora calc = new Calculadora();//instancia da classe Calculadora
            //Console.WriteLine("Resultado da 1ª soma: " + calc.Somar(10, 20));//chamando o método somar da classe Calculadora
            //Console.WriteLine("Resultado da 2ª soma: " + calc.Somar(10, 20, 30));
            
            
            /*Aluno al = new Aluno();
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

            prof.Apresentar();*/
        }
    }
}
