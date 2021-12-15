using System;
using exemploPOO.Helper;
using exemploPOO.Interfaces;

using exemploPOO.Models;

namespace exemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\DEV\\POO_Exemplos\\AbstracaoNaPratica\\exemploPOO\\Helper";
            
            FileHelper helper = new FileHelper();
            //helper.ListarDiretorios(caminho);
            helper.ListarArquivosDiretorios(caminho);
            
            //ICAlculadora calc = new Calculadora();
            //Console.WriteLine(calc.Somar(10, 20));            
            
            //Computador comp = new Computador();
            //System.Console.WriteLine(comp.ToString());

                                    
            /*Pessoa p1 = new Pessoa();

            p1.Nome = "Maria";
            p1.Idade = 20;

            p1.Apresentar();*/
        }
    }
}