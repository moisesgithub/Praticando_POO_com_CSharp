using System;
using exemploPOO;

namespace EncapslamentoNaPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
            r.DefinirMedidas(30, 30);

            System.Console.WriteLine($"Area: {r.ObterArea()}");

            //Valores inválidos
            Retangulo r2 = new Retangulo();
            r2.DefinirMedidas(0, 0);

            System.Console.WriteLine($"Area: {r2.ObterArea()}");
        }
    }
}
