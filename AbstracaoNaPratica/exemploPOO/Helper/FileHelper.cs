using System.IO;
using System;
using System.Collections.Generic;

namespace exemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
          var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

          foreach (var retorno in retornoCaminho)
          {
            System.Console.WriteLine(retorno);
          }          
        }
        public void ListarArquivosDiretorios(string caminho)
        {
          var retornoArquivos = Directory.GetFiles(caminho, "*2.txt", SearchOption.AllDirectories);
                                                           //*2.txt esse é o nome do arquivo que quero listar,o (*) é um filtro, 
                                                           //o (SearchOption.AllDirectories) é para listar todos os arquivos dentro dos diretórios

          foreach (var retorno in retornoArquivos)
          {
            System.Console.WriteLine(retorno);
          }          
        }
        public void CriarDiretorios(string caminho)
        {
          var retorno = Directory.CreateDirectory(caminho);
          System.Console.WriteLine(retorno.FullName);
        }
        public void ApagarDiretorio(string caminho, bool apagarArquivos)
        {
          Directory.Delete(caminho, apagarArquivos);//Cuidado com esse método Directory.Delete, 
                                                    //ele apaga os arquivos dentro do diretorio, não tem lixeira para recuperar!
        }
        public void CriarArquivoTexto(string caminho, string conteudo)
        {
          if (!File.Exists(caminho))
          {
            File.WriteAllText(caminho, conteudo);
          }
        }

        public void CriarArquivoTextoStream(string caminho, List<string> conteudo)
        {
          using (var stream = File.CreateText(caminho))
          {
             foreach (var linha in conteudo)
            {
              stream.WriteLine(linha);
            }            
          }                                          
        }
        public void AdicionarTexto(string caminho, string conteudo)
        {
          File.AppendAllText(caminho, conteudo);
        }
        public void AdicionarTextoStream(string caminho, List<string> conteudo)
        {
          using (var stream = File.AppendText(caminho))
          {
             foreach (var linha in conteudo)
            {
              stream.WriteLine(linha);
            }            
          }                                          
        }
    }    
}