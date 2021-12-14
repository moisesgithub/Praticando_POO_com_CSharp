namespace exemploPOO
{
    public class Corrente : Conta
    {
        public override void Creditar(double valor)//override significa que o método Creditar da classe 
                                                   //Conta será substituído pelo método Creditar da classe Corrente,
                                                   //foi subscrito.
        {
            base.saldo = valor;
        }
    }        
}