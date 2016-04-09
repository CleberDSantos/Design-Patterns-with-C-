using System;

namespace Strategy.DesignPattern
{
    public class ItauBoleto : IGeradorBoleto
    {
        public void Gerar()
        {
            Console.WriteLine("Boleto de Itau Gerado!!");
        }
    }
}
