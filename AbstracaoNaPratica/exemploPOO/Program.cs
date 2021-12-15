using System;
using System.IO;
using System.Collections.Generic;
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
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste-stream.txt");
            
            var listaString = new List<string>() { "Linha 1", "Linha 2", "Linha 3" };
            var listaStringContinuacao = new List<string>() { "Linha 4", "Linha 5", "Linha 6" };
            
            
            FileHelper helper = new FileHelper();
            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretorios(caminho);

            //System.Console.WriteLine("Criando diretorio: " + caminhoPathCombine);
            //helper.CriarDiretorios(caminhoPathCombine);//path.combine é para juntar os caminhos
            //helper.ApagarDiretorio(caminhoPathCombine, true);//Cuidado com o true, ele apaga os arquivos dentro do diretorio
            //helper.CriarArquivoTexto(caminhoArquivo, "Teste escrita de arquivo!");
            //helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            //helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);    
            //helper.LerArquivoStream(caminhoArquivo);
            //helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
            //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            helper.DeletarArquivo(caminhoArquivoTesteCopia);//Cuidado com esse método, ele apaga o arquivo, não tem lixeira para recuperar!

            
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