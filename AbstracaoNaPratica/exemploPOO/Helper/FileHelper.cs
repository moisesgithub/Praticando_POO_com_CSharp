using System.IO;
using System;

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
    }
}