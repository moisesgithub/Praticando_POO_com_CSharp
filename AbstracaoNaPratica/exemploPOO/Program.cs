﻿using System;
using System.IO;
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
            var caminhoPathCombine = (Path.Combine(caminho, "Pasta Teste 1"));
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste.txt");
            
            FileHelper helper = new FileHelper();
            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretorios(caminho);

            //System.Console.WriteLine("Criando diretorio: " + caminhoPathCombine);
            //helper.CriarDiretorios(caminhoPathCombine);//path.combine é para juntar os caminhos
            //helper.ApagarDiretorio(caminhoPathCombine, true);//Cuidado com o true, ele apaga os arquivos dentro do diretorio
            helper.CriarArquivoTexto(caminhoArquivo, "Teste escrita de arquivo!");
            
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