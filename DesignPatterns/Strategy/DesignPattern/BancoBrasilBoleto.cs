using System;

namespace Strategy.DesignPattern
{
    public class BancoBrasilBoleto : IGeradorBoleto
    {
        public void Gerar()
        {
            Console.WriteLine("Boleto do Banco do Brasil Gerado!!!");
        }
    }
}
