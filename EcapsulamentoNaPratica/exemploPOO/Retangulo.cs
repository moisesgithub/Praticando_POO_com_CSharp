using System;

namespace exemploPOO
{
    public class Retangulo
    {
        private double comprimento;
        private double largura;
        private bool validar;

        public void DefinirMedidas(double comprimento, double largura)
        {
            if (comprimento > 0 && largura > 0)
            {
                this.comprimento = comprimento;
                this.largura = largura;
                validar = true;
            }
            else
            {
                System.Console.WriteLine("Medidas inválidas");
            }            
        }

        public double ObterArea()
        {
            if(validar)
            {
                return comprimento * largura;
            }
            else
            {
                System.Console.WriteLine("Preencha valores válidos");
                return 0;
            }            
        }
    }
}